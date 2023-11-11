using UnityEngine;

namespace SonicBloom.Koreo.Players
{
	[AddComponentMenu("Koreographer/Music Players/Simple Music Player")]
	[RequireComponent(typeof(AudioSource))]
	public class SimpleMusicPlayer : MonoBehaviour, IKoreographedPlayer
	{
		[SerializeField]
		[Tooltip("When an initial Koreography is specified, determines whether to play immediately on Awake() or not.")]
		private bool autoPlayOnAwake = true;

		[SerializeField]
		[Tooltip("The Koreography to play back.")]
		private Koreography koreography;

		[SerializeField]
		[Tooltip("[Optional] Specify a target Koreographer component to use for Koreography Event reporting and Music Time API support.  If no Koreographer is specified, the default global Koreographer component reference will be used.")]
		private Koreographer targetKoreographer;

		private AudioVisor visor;

		private AudioSource audioCom;

		public bool IsPlaying => audioCom.isPlaying;

		private void Awake()
		{
			if (targetKoreographer == null)
			{
				targetKoreographer = Koreographer.Instance;
			}
			targetKoreographer.musicPlaybackController = this;
			audioCom = GetComponent<AudioSource>();
			visor = new AudioVisor(audioCom, targetKoreographer);
			if (koreography != null)
			{
				LoadSong(koreography, 0, autoPlayOnAwake);
			}
		}

		private void Update()
		{
			visor.Update();
		}

		public void LoadSong(Koreography koreo, int startSampleTime = 0, bool autoPlay = true)
		{
			targetKoreographer.UnloadKoreography(koreography);
			koreography = koreo;
			if (koreography != null)
			{
				targetKoreographer.LoadKoreography(koreography);
				audioCom.clip = koreography.SourceClip;
				SeekToSample(startSampleTime);
				if (autoPlay)
				{
					audioCom.Play();
				}
			}
		}

		public void Play()
		{
			if (!audioCom.isPlaying)
			{
				audioCom.Play();
			}
		}

		public void Stop()
		{
			audioCom.Stop();
		}

		public void Pause()
		{
			audioCom.Pause();
		}

		public void SeekToSample(int targetSample)
		{
			audioCom.timeSamples = targetSample;
			visor.ResyncTimings();
		}

		public int GetSampleTimeForClip(string clipName)
		{
			int result = 0;
			if (koreography != null && koreography.SourceClipName == clipName)
			{
				result = visor.GetCurrentTimeInSamples();
			}
			return result;
		}

		public int GetTotalSampleTimeForClip(string clipName)
		{
			int result = 0;
			if (koreography != null && koreography.SourceClipName == clipName)
			{
				result = audioCom.clip.samples;
			}
			return result;
		}

		public bool GetIsPlaying(string clipName)
		{
			return koreography != null && koreography.SourceClipName == clipName && audioCom.isPlaying;
		}

		public float GetPitch(string clipName)
		{
			return audioCom.pitch;
		}

		public string GetCurrentClipName()
		{
			return (!(koreography == null)) ? koreography.SourceClipName : string.Empty;
		}
	}
}
