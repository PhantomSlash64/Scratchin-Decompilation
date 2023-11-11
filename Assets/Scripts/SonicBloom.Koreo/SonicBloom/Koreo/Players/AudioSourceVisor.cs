using UnityEngine;

namespace SonicBloom.Koreo.Players
{
	[AddComponentMenu("Koreographer/Visors/Audio Source Visor")]
	public class AudioSourceVisor : MonoBehaviour
	{
		[Tooltip("[Optional] Specify a target AudioSource component for this AudioSourceVisor to watch over. If no AudioSource is specified, this component will attempt to find and use an AudioSource component located on the same GameObject. If none is found, it will log a warning and disable itself.")]
		[SerializeField]
		private AudioSource targetAudioSource;

		[SerializeField]
		[Tooltip("[Optional] Specify a target Koreographer component to use for Koreography Event reporting. If no Koreographer is specified, the default global Koreographer component reference will be used.")]
		private Koreographer targetKoreographer;

		private AudioVisor visor;

		public double ScheduledPlayTime
		{
			get
			{
				return visor.ScheduledPlayTime;
			}
			set
			{
				visor.ScheduledPlayTime = value;
			}
		}

		private void Awake()
		{
			if (targetAudioSource == null)
			{
				targetAudioSource = GetComponent<AudioSource>();
			}
			if (targetAudioSource == null)
			{
				Debug.LogWarning("No Target Audio Source specified and no AudioSource found on Game Object '" + base.gameObject.name + "'. Disabling this AudioSourceVisor.");
				base.enabled = false;
			}
			else
			{
				visor = new AudioVisor(targetAudioSource, targetKoreographer);
			}
		}

		private void Update()
		{
			visor.Update();
		}

		public void ResyncTimings(int targetSampleTime)
		{
			visor.ResyncTimings(targetSampleTime);
		}
	}
}
