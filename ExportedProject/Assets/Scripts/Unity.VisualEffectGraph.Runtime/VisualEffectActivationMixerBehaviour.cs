using UnityEngine.Playables;
using UnityEngine.VFX;

internal class VisualEffectActivationMixerBehaviour : PlayableBehaviour
{
	private bool[] enabledStates;

	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
		VisualEffect visualEffect = playerData as VisualEffect;
		if (!visualEffect)
		{
			return;
		}
		int inputCount = playable.GetInputCount();
		for (int i = 0; i < inputCount; i++)
		{
			bool flag = playable.GetInputWeight(i) != 0f;
			VisualEffectActivationBehaviour behaviour = ((ScriptPlayable<VisualEffectActivationBehaviour>)playable.GetInput(i)).GetBehaviour();
			if (enabledStates[i] != flag)
			{
				if (flag)
				{
					behaviour.SendEventEnter(visualEffect);
				}
				else
				{
					behaviour.SendEventExit(visualEffect);
				}
				enabledStates[i] = flag;
			}
		}
	}

	public override void OnPlayableCreate(Playable playable)
	{
		enabledStates = new bool[playable.GetInputCount()];
	}

	public override void OnPlayableDestroy(Playable playable)
	{
		enabledStates = null;
	}
}
