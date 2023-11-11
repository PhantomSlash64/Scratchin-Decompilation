using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[Serializable]
	public abstract class KoreographyTrackBase : ScriptableObject, ISerializationCallbackReceiver
	{
		public struct TrackingCrumbs
		{
			internal int lastCheckedEndSample;

			internal int checkHeadIndex;

			public int LastCheckedEndSample => lastCheckedEndSample;

			public int CheckHeadIndex => checkHeadIndex;

			public void Reset()
			{
				lastCheckedEndSample = -1;
				checkHeadIndex = 0;
			}
		}

		[Tooltip("The Event ID for this Koreography Track.  Used for Event Registration.")]
		[SerializeField]
		private string mEventID = string.Empty;

		[Tooltip("The complete, ordered list of Koreography Events within this Koreography Track.")]
		[SerializeField]
		private List<KoreographyEvent> mEventList = new List<KoreographyEvent>();

		private List<KoreographyEvent> eventsInRange = new List<KoreographyEvent>();

		private TrackingCrumbs internalTrackingCrumbs;

		[SerializeField]
		[HideInInspector]
		private List<string> _SerializedPayloadTypes;

		public string EventID
		{
			get
			{
				return mEventID;
			}
			set
			{
				mEventID = value;
			}
		}

		private event KoreographyEventCallback koreographyEventCallbacks;

		private event KoreographyEventCallbackWithTime koreographyEventCallbacksWithTime;

		private void OnEnable()
		{
			internalTrackingCrumbs.Reset();
		}

		public bool CheckEventListIntegrity()
		{
			int count = mEventList.Count;
			mEventList.RemoveAll((KoreographyEvent e) => e == null);
			return count != mEventList.Count;
		}

		public int GetIDForEvent(KoreographyEvent e)
		{
			return mEventList.IndexOf(e);
		}

		public void EnsureEventOrder()
		{
			mEventList.Sort(KoreographyEvent.CompareByStartSample);
		}

		public KoreographyEvent GetEventAtStartSample(int sample)
		{
			KoreographyEvent result = null;
			for (int i = 0; i < mEventList.Count; i++)
			{
				if (mEventList[i].StartSample == sample)
				{
					result = mEventList[i];
					break;
				}
			}
			return result;
		}

		public bool AddEvent(KoreographyEvent addEvent)
		{
			bool flag = true;
			if (addEvent.IsOneOff())
			{
				KoreographyEvent eventAtStartSample = GetEventAtStartSample(addEvent.StartSample);
				if (eventAtStartSample != null && eventAtStartSample.IsOneOff())
				{
					flag = false;
				}
			}
			if (flag)
			{
				mEventList.Add(addEvent);
				EnsureEventOrder();
			}
			return flag;
		}

		public bool RemoveEvent(KoreographyEvent removeEvent)
		{
			return mEventList.Remove(removeEvent);
		}

		public void RemoveAllEvents()
		{
			mEventList.Clear();
		}

		[Obsolete("This method will be removed in a future version.  Please use the new GetEventsInRange(int, int, List) instead.")]
		public List<KoreographyEvent> GetEventsInRange(int startSample, int endSample)
		{
			eventsInRange.Clear();
			GetEventsInRange(startSample, endSample, eventsInRange);
			return eventsInRange;
		}

		public void GetEventsInRange(int startSample, int endSample, List<KoreographyEvent> listToFill)
		{
			int count = mEventList.Count;
			for (int i = 0; i < count; i++)
			{
				KoreographyEvent koreographyEvent = mEventList[i];
				if (koreographyEvent.StartSample > endSample)
				{
					break;
				}
				if (koreographyEvent.EndSample >= startSample)
				{
					listToFill.Add(koreographyEvent);
				}
			}
		}

		[Obsolete("This method will be removed in a future version.  Please use the new GetEventsInRangeTracked(int, int, TrackingCrumbs, List) instead.")]
		public List<KoreographyEvent> GetEventsInRangeTracked(int startSample, int endSample)
		{
			eventsInRange.Clear();
			GetEventsInRangeTracked(startSample, endSample, ref internalTrackingCrumbs, eventsInRange);
			return eventsInRange;
		}

		public void GetEventsInRangeTracked(int startSample, int endSample, ref TrackingCrumbs crumbs, List<KoreographyEvent> listToFill)
		{
			int count = mEventList.Count;
			int num = crumbs.checkHeadIndex;
			if (startSample != crumbs.lastCheckedEndSample + 1)
			{
				num = count;
				for (int i = 0; i < count; i++)
				{
					if (mEventList[i].EndSample >= startSample)
					{
						num = i;
						break;
					}
				}
			}
			for (int j = num; j < count; j++)
			{
				KoreographyEvent koreographyEvent = mEventList[j];
				if (koreographyEvent.EndSample < startSample)
				{
					if (j != num && koreographyEvent.EndSample >= mEventList[num].EndSample)
					{
						num = j;
					}
					continue;
				}
				if (koreographyEvent.StartSample > endSample)
				{
					break;
				}
				if (listToFill.Count == 0 && j != num)
				{
					num = j;
				}
				listToFill.Add(koreographyEvent);
			}
			crumbs.checkHeadIndex = num;
			crumbs.lastCheckedEndSample = endSample;
		}

		public List<KoreographyEvent> GetAllEvents()
		{
			return new List<KoreographyEvent>(mEventList);
		}

		public void CheckForEvents(int startTime, int endTime, DeltaSlice deltaSlice)
		{
			eventsInRange.Clear();
			GetEventsInRangeTracked(startTime, endTime, ref internalTrackingCrumbs, eventsInRange);
			int count = eventsInRange.Count;
			for (int i = 0; i < count; i++)
			{
				KoreographyEvent koreoEvent = eventsInRange[i];
				if (this.koreographyEventCallbacks != null)
				{
					this.koreographyEventCallbacks(koreoEvent);
				}
				if (this.koreographyEventCallbacksWithTime != null)
				{
					int sampleDelta = endTime - startTime;
					this.koreographyEventCallbacksWithTime(koreoEvent, endTime, sampleDelta, deltaSlice);
				}
			}
		}

		internal void RegisterForEvents(KoreographyEventCallback callback)
		{
			this.koreographyEventCallbacks = (KoreographyEventCallback)Delegate.Combine(this.koreographyEventCallbacks, callback);
		}

		internal void RegisterForEventsWithTime(KoreographyEventCallbackWithTime callback)
		{
			this.koreographyEventCallbacksWithTime = (KoreographyEventCallbackWithTime)Delegate.Combine(this.koreographyEventCallbacksWithTime, callback);
		}

		internal void UnregisterForEvents(KoreographyEventCallback callback)
		{
			this.koreographyEventCallbacks = (KoreographyEventCallback)Delegate.Remove(this.koreographyEventCallbacks, callback);
		}

		internal void UnregisterForEventsWithTime(KoreographyEventCallbackWithTime callback)
		{
			this.koreographyEventCallbacksWithTime = (KoreographyEventCallbackWithTime)Delegate.Remove(this.koreographyEventCallbacksWithTime, callback);
		}

		internal void ClearEventRegister()
		{
			this.koreographyEventCallbacks = null;
			this.koreographyEventCallbacksWithTime = null;
		}

		public void OnBeforeSerialize()
		{
			Type type = GetType();
			if (_SerializedPayloadTypes == null)
			{
				_SerializedPayloadTypes = new List<string>();
			}
			else
			{
				for (int i = 0; i < _SerializedPayloadTypes.Count; i++)
				{
					string text = _SerializedPayloadTypes[i];
					string text2 = text.Split('.').Last();
					FieldInfo fieldInfoOfListWithTypeString = GetFieldInfoOfListWithTypeString(type, text, "_" + text2 + "s");
					if ((object)fieldInfoOfListWithTypeString != null)
					{
						FieldInfo fieldInfoOfListWithTypeString2 = GetFieldInfoOfListWithTypeString(type, typeof(int).ToString(), "_" + text2 + "Idxs");
						if ((object)fieldInfoOfListWithTypeString2 != null)
						{
							fieldInfoOfListWithTypeString.SetValue(this, null);
							fieldInfoOfListWithTypeString2.SetValue(this, null);
						}
					}
				}
				_SerializedPayloadTypes.Clear();
			}
			Dictionary<Type, FieldInfo> dictionary = new Dictionary<Type, FieldInfo>();
			Dictionary<Type, FieldInfo> dictionary2 = new Dictionary<Type, FieldInfo>();
			for (int j = 0; j < mEventList.Count; j++)
			{
				IPayload payload = mEventList[j].Payload;
				if (payload == null)
				{
					continue;
				}
				Type type2 = payload.GetType();
				FieldInfo fieldInfo = null;
				FieldInfo fieldInfo2 = null;
				if (dictionary.ContainsKey(type2))
				{
					fieldInfo = dictionary[type2];
					fieldInfo2 = dictionary2[type2];
				}
				else
				{
					fieldInfo = GetFieldInfoOfListWithType(type, type2, "_" + type2.Name + "s");
					if ((object)fieldInfo == null)
					{
						continue;
					}
					fieldInfo2 = GetFieldInfoOfListWithType(type, typeof(int), "_" + type2.Name + "Idxs");
					if ((object)fieldInfo2 == null)
					{
						continue;
					}
					fieldInfo.SetValue(this, Activator.CreateInstance(fieldInfo.FieldType));
					dictionary.Add(type2, fieldInfo);
					fieldInfo2.SetValue(this, new List<int>());
					dictionary2.Add(type2, fieldInfo2);
					_SerializedPayloadTypes.Add(type2.ToString());
				}
				IList list = fieldInfo.GetValue(this) as IList;
				List<int> list2 = fieldInfo2.GetValue(this) as List<int>;
				list.Add(payload);
				list2.Add(j);
			}
		}

		public void OnAfterDeserialize()
		{
			if (_SerializedPayloadTypes == null)
			{
				return;
			}
			for (int i = 0; i < _SerializedPayloadTypes.Count; i++)
			{
				Type type = GetType();
				string text = _SerializedPayloadTypes[i];
				string text2 = text.Split('.').Last();
				FieldInfo fieldInfoOfListWithTypeString = GetFieldInfoOfListWithTypeString(type, text, "_" + text2 + "s");
				if ((object)fieldInfoOfListWithTypeString == null)
				{
					continue;
				}
				if (!(fieldInfoOfListWithTypeString.GetValue(this) is IList list))
				{
					Debug.LogError("Error retreiving Payload storage list 'List<" + text + "> _" + text2 + "s'.  This should never happen: please check your implementation.");
					continue;
				}
				FieldInfo fieldInfoOfListWithTypeString2 = GetFieldInfoOfListWithTypeString(type, text, "_" + text2 + "Idxs");
				if ((object)fieldInfoOfListWithTypeString2 == null)
				{
					continue;
				}
				if (!(fieldInfoOfListWithTypeString2.GetValue(this) is List<int> list2))
				{
					Debug.LogError(string.Concat("Payload storage indexing list '", fieldInfoOfListWithTypeString2.Name, "' probably has an incorrect type declaration.\n\tExpected: 'List<int>'\n\tFound: '", fieldInfoOfListWithTypeString2.FieldType, "'"));
				}
				else
				{
					for (int j = 0; j < list.Count; j++)
					{
						mEventList[list2[j]].Payload = list[j] as IPayload;
					}
					fieldInfoOfListWithTypeString.SetValue(this, null);
					fieldInfoOfListWithTypeString2.SetValue(this, null);
				}
			}
			_SerializedPayloadTypes = null;
		}

		private static FieldInfo GetFieldInfoOfListWithType(Type sourceType, Type lookupType, string fieldName)
		{
			FieldInfo fieldInfo = GetFieldInfoFromName(sourceType, fieldName);
			if ((object)fieldInfo == null)
			{
				Debug.LogError("Serialization Error: No 'List<" + lookupType.ToString() + "> _" + lookupType.Name + "s' defined in " + sourceType.Name + " class!");
			}
			else if (!IsGenericList(fieldInfo.FieldType))
			{
				Debug.LogError("Serialization Error: Field called '" + fieldInfo.Name + "' is not a List<>!");
				fieldInfo = null;
			}
			else if ((object)fieldInfo.FieldType.GetGenericArguments()[0] != lookupType)
			{
				Debug.LogError("Serialization Error: Field called '" + fieldInfo.Name + "' is not a list of the expected type '" + lookupType.ToString() + "'. Actual full type of field is: " + fieldInfo.FieldType.Name);
				fieldInfo = null;
			}
			return fieldInfo;
		}

		private static FieldInfo GetFieldInfoOfListWithTypeString(Type sourceType, string typeStr, string fieldName)
		{
			FieldInfo fieldInfo = GetFieldInfoFromName(sourceType, fieldName);
			if ((object)fieldInfo == null)
			{
				Debug.LogError("Payload storage list 'List<" + typeStr + "> " + fieldName + "' could not be retreived. Old data or did someone change the name?");
			}
			else if (!IsGenericList(fieldInfo.FieldType))
			{
				Debug.LogError("Payload storage list 'List<" + typeStr + "> " + fieldName + "' is not actually of type List<>. Please check your implementation.");
				fieldInfo = null;
			}
			return fieldInfo;
		}

		private static bool IsGenericList(Type type)
		{
			return (object)type.GetGenericTypeDefinition() == typeof(List<>);
		}

		private static FieldInfo GetFieldInfoFromName(Type sourceType, string name)
		{
			return sourceType.GetField(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		}
	}
}
