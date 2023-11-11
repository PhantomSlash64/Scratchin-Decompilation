using UnityEngine;

namespace E7.Introloop
{
	public class IntroloopAudio : ScriptableObject
	{
		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("Regular AudioClip couldn't alter volume per-audio, but rather must be the task of AudioSource. Introloop controls 4 AudioSources and allows it to control volume as well. This is useful on composing music too, so you could master the song and maximize the volume regardless of genre, and mix it later to reasonable level here.")]
		private float volume;

		[SerializeField]
		[Range(0.1f, 3f)]
		[Tooltip("Introloop couldn't change pitch in real time because that will throw off the schedule, however, by pre-specifying the pitch, it is possible to scales the schedule accordingly. The audio stitching will still be on time.")]
		private float pitch = 1f;

		[SerializeField]
		internal AudioClip audioClip;

		[SerializeField]
		[PositiveFloat]
		private float introBoundary;

		[SerializeField]
		[PositiveFloat]
		private float loopingBoundary;

		[SerializeField]
		internal bool nonLooping;

		[SerializeField]
		internal bool loopWholeAudio;

		public AudioClip AudioClip => audioClip;

		public float ClipLength => audioClip.length / pitch;

		public bool Loop => !nonLooping;

		public float Volume
		{
			get
			{
				return volume;
			}
			set
			{
				volume = value;
			}
		}

		public float Pitch => pitch;

		internal float IntroLength => introBoundary / pitch;

		internal float LoopingLength => (loopingBoundary - introBoundary) / pitch;

		internal float UnscaledClipLength => audioClip.length;

		internal float UnscaledIntroLength => introBoundary;

		internal float UnscaledLoopingLength => loopingBoundary - introBoundary;

		internal void Preload()
		{
			audioClip.LoadAudioData();
		}

		internal void Unload()
		{
			audioClip.UnloadAudioData();
		}
	}
}
