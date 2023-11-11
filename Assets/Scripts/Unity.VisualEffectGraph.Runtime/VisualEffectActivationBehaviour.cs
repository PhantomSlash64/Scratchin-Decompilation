using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;

[Serializable]
internal class VisualEffectActivationBehaviour : PlayableBehaviour
{
	[Serializable]
	public enum AttributeType
	{
		Float = 1,
		Float2 = 2,
		Float3 = 3,
		Float4 = 4,
		Int32 = 5,
		Uint32 = 6,
		Boolean = 17
	}

	[Serializable]
	public struct EventState
	{
		public ExposedProperty attribute;

		public AttributeType type;

		public float[] values;
	}

	[SerializeField]
	private ExposedProperty onClipEnter = "OnPlay";

	[SerializeField]
	private ExposedProperty onClipExit = "OnStop";

	[SerializeField]
	private EventState[] clipEnterEventAttributes;

	[SerializeField]
	private EventState[] clipExitEventAttributes;

	public override void OnPlayableCreate(Playable playable)
	{
	}

	public void SendEventEnter(VisualEffect component)
	{
		VFXEventAttribute eventAttribute = BuildEventAttribute(component, clipEnterEventAttributes);
		component.SendEvent(onClipEnter, eventAttribute);
	}

	public void SendEventExit(VisualEffect component)
	{
		VFXEventAttribute eventAttribute = BuildEventAttribute(component, clipExitEventAttributes);
		component.SendEvent(onClipExit, eventAttribute);
	}

	private static VFXEventAttribute BuildEventAttribute(VisualEffect component, EventState[] states)
	{
		if (states == null || states.Length == 0)
		{
			return null;
		}
		VFXEventAttribute vFXEventAttribute = component.CreateVFXEventAttribute();
		for (int i = 0; i < states.Length; i++)
		{
			EventState eventState = states[i];
			switch (eventState.type)
			{
			case AttributeType.Float:
				vFXEventAttribute.SetFloat(eventState.attribute, eventState.values[0]);
				break;
			case AttributeType.Float2:
				vFXEventAttribute.SetVector2(eventState.attribute, new Vector2(eventState.values[0], eventState.values[1]));
				break;
			case AttributeType.Float3:
				vFXEventAttribute.SetVector3(eventState.attribute, new Vector3(eventState.values[0], eventState.values[1], eventState.values[2]));
				break;
			case AttributeType.Float4:
				vFXEventAttribute.SetVector4(eventState.attribute, new Vector4(eventState.values[0], eventState.values[1], eventState.values[2], eventState.values[3]));
				break;
			case AttributeType.Int32:
				vFXEventAttribute.SetInt(eventState.attribute, (int)eventState.values[0]);
				break;
			case AttributeType.Uint32:
				vFXEventAttribute.SetUint(eventState.attribute, (uint)eventState.values[0]);
				break;
			case AttributeType.Boolean:
				vFXEventAttribute.SetBool(eventState.attribute, eventState.values[0] != 0f);
				break;
			}
		}
		return vFXEventAttribute;
	}
}
