using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.Utils.Classes.Data;

namespace Rewired.Utils
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal static class TempListPool
	{
		private static class ohtzVAfhXqCcWfbzttxZDavGZEV
		{
			private static ADictionary<Type, List<object>> sMJcDrYxylapdYzHjaicPONqhMv;

			private static ADictionary<Type, List<object>> irNeHTdBvfhyEVgZnOuFTaPCKBSc
			{
				get
				{
					if (sMJcDrYxylapdYzHjaicPONqhMv == null)
					{
						return sMJcDrYxylapdYzHjaicPONqhMv = new ADictionary<Type, List<object>>();
					}
					return sMJcDrYxylapdYzHjaicPONqhMv;
				}
			}

			public static TList<T> rDKxChtDNsieXfOckVhIIKbyGxDA<T>(List<T> P_0)
			{
				if (P_0 == null)
				{
					throw new ArgumentNullException("list");
				}
				if (!irNeHTdBvfhyEVgZnOuFTaPCKBSc.ContainsKey(typeof(T)))
				{
					irNeHTdBvfhyEVgZnOuFTaPCKBSc.Add(typeof(T), new List<object>(3));
				}
				List<object> list = irNeHTdBvfhyEVgZnOuFTaPCKBSc[typeof(T)];
				if (list.Count == 0)
				{
					TList<T> tList = TList<T>.Create();
					((ITListSetter<T>)tList).SetList(P_0);
					return tList;
				}
				int index = list.Count - 1;
				TList<T> tList2 = list[index] as TList<T>;
				list.RemoveAt(index);
				((ITListSetter<T>)tList2).SetList(P_0);
				return tList2;
			}

			public static void GKiwrjjKcRhkScgfIpbHFJlhsoGj<T>(TList<T> P_0)
			{
				if (P_0 != null)
				{
					if (!irNeHTdBvfhyEVgZnOuFTaPCKBSc.TryGetValue(typeof(T), out var value))
					{
						value = new List<object>(3);
						irNeHTdBvfhyEVgZnOuFTaPCKBSc.Add(typeof(T), value);
					}
					if (value.Count < 3)
					{
						ListTools.AddIfUnique(value, P_0);
					}
				}
			}

			public static void LlCkzvOeJVaCziTDPktzBWuYotAZ()
			{
				sMJcDrYxylapdYzHjaicPONqhMv = null;
			}

			public static void LlCkzvOeJVaCziTDPktzBWuYotAZ(Type P_0)
			{
				if ((object)P_0 == null)
				{
					throw new ArgumentNullException("listType");
				}
				if (sMJcDrYxylapdYzHjaicPONqhMv != null && sMJcDrYxylapdYzHjaicPONqhMv.ContainsKey(P_0))
				{
					sMJcDrYxylapdYzHjaicPONqhMv.Remove(P_0);
				}
			}
		}

		[CustomObfuscation(rename = false)]
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		internal interface ITListSetter<T>
		{
			void SetList(List<T> list);
		}

		[CustomObfuscation(rename = false)]
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		internal sealed class TList<T> : IDisposable, ITListSetter<T>
		{
			private List<T> giKLSgrhLNwAUMnedtVqLxbOwiO;

			private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

			public List<T> list
			{
				get
				{
					if (RFSEgUYkCipDyWyLEnlGiNDUlzz)
					{
						HXQwpTlbSIbcoEaFebDFaRDijKCG();
					}
					return giKLSgrhLNwAUMnedtVqLxbOwiO;
				}
			}

			public static TList<T> Create()
			{
				return new TList<T>();
			}

			private TList()
			{
			}

			public void Dispose()
			{
				if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
				{
					GKiwrjjKcRhkScgfIpbHFJlhsoGj();
					RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
				}
			}

			private void GKiwrjjKcRhkScgfIpbHFJlhsoGj()
			{
				if (giKLSgrhLNwAUMnedtVqLxbOwiO != null)
				{
					Return(giKLSgrhLNwAUMnedtVqLxbOwiO);
				}
				giKLSgrhLNwAUMnedtVqLxbOwiO = null;
				ohtzVAfhXqCcWfbzttxZDavGZEV.GKiwrjjKcRhkScgfIpbHFJlhsoGj(this);
			}

			private void QjDbfwqoXkLazTPeOKwjmdgZKcE(List<T> P_0)
			{
				giKLSgrhLNwAUMnedtVqLxbOwiO = P_0;
				RFSEgUYkCipDyWyLEnlGiNDUlzz = false;
			}

			void ITListSetter<T>.SetList(List<T> P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in QjDbfwqoXkLazTPeOKwjmdgZKcE
				this.QjDbfwqoXkLazTPeOKwjmdgZKcE(P_0);
			}

			private static void HXQwpTlbSIbcoEaFebDFaRDijKCG()
			{
				throw new Exception("The TList has been disposed.");
			}

			public static implicit operator List<T>(TList<T> obj)
			{
				return obj.list;
			}
		}

		private const int urZeLdKWZaxjLIqhqmbxMLKOdCj = 3;

		private const int ujyUHBTqKwkFDzCeCOpkRWvhsYg = 10;

		private static ADictionary<Type, List<IList>> ysjCKRBDMEXwbMPaqogNPjOdMJm;

		private static ADictionary<Type, List<IList>> lists
		{
			get
			{
				if (ysjCKRBDMEXwbMPaqogNPjOdMJm == null)
				{
					return ysjCKRBDMEXwbMPaqogNPjOdMJm = new ADictionary<Type, List<IList>>();
				}
				return ysjCKRBDMEXwbMPaqogNPjOdMJm;
			}
		}

		public static TList<T> GetTList<T>()
		{
			return GetTList<T>(0);
		}

		public static TList<T> GetTList<T>(int capacity)
		{
			return ohtzVAfhXqCcWfbzttxZDavGZEV.rDKxChtDNsieXfOckVhIIKbyGxDA(Get<T>(capacity));
		}

		public static void ReturnTList<T>(TList<T> tList)
		{
			tList?.Dispose();
		}

		public static List<T> Get<T>()
		{
			return Get<T>(0);
		}

		public static List<T> Get<T>(int capacity)
		{
			if (capacity < 0)
			{
				capacity = 0;
			}
			if (!lists.ContainsKey(typeof(T)))
			{
				lists.Add(typeof(T), new List<IList>(3));
			}
			List<IList> list = lists[typeof(T)];
			if (list.Count == 0)
			{
				return new List<T>((capacity == 0) ? 10 : capacity);
			}
			if (capacity > 0)
			{
				int count = list.Count;
				int num = -1;
				int index = -1;
				List<T> list2;
				for (int i = 0; i < count; i++)
				{
					list2 = list[i] as List<T>;
					int capacity2 = list2.Capacity;
					if (capacity2 > num)
					{
						num = capacity2;
						index = i;
					}
					if (capacity2 >= capacity)
					{
						list.RemoveAt(i);
						return list2;
					}
				}
				list2 = list[index] as List<T>;
				list.RemoveAt(index);
				return list2;
			}
			int index2 = list.Count - 1;
			IList list3 = list[index2];
			list.RemoveAt(index2);
			return list3 as List<T>;
		}

		public static void Return<T>(List<T> list)
		{
			if (list != null)
			{
				list.Clear();
				if (!lists.TryGetValue(typeof(T), out var value))
				{
					value = new List<IList>(3);
					lists.Add(typeof(T), value);
				}
				if (value.Count < 3)
				{
					ListTools.AddIfUnique(value, list);
				}
			}
		}

		public static void Return<T>(List<T> list1, List<T> list2)
		{
			Return(list1);
			Return(list2);
		}

		public static void Return<T>(List<T> list1, List<T> list2, List<T> list3)
		{
			Return(list1);
			Return(list2);
			Return(list3);
		}

		public static void Clear()
		{
			ysjCKRBDMEXwbMPaqogNPjOdMJm = null;
			ohtzVAfhXqCcWfbzttxZDavGZEV.LlCkzvOeJVaCziTDPktzBWuYotAZ();
		}

		public static void Clear(Type listType)
		{
			if ((object)listType == null)
			{
				throw new ArgumentNullException("listType");
			}
			if (ysjCKRBDMEXwbMPaqogNPjOdMJm != null && ysjCKRBDMEXwbMPaqogNPjOdMJm.ContainsKey(listType))
			{
				ysjCKRBDMEXwbMPaqogNPjOdMJm.Remove(listType);
				ohtzVAfhXqCcWfbzttxZDavGZEV.LlCkzvOeJVaCziTDPktzBWuYotAZ(listType);
			}
		}
	}
}
