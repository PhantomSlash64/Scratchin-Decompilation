using System;
using UnityEngine;

namespace SonicBloom.Koreo.Players
{
	[Serializable]
	public class MusicLayer
	{
		[SerializeField]
		[Tooltip("Adds a name to the layer.  This is used to rename the Music Layer entry in the list in the Inspector.")]
		private string name = string.Empty;

		[SerializeField]
		[Tooltip("Koreography to load for this layer.  The AudioClip in the Koreography will be used for playback.")]
		private Koreography koreography;

		[SerializeField]
		[Tooltip("Don’t load Koreography - simply play the AudioClip.")]
		private AudioClip audioClip;

		[SerializeField]
		[Tooltip("A reference to an AudioSource component that this Music Layer should use for playback.  If not specified the system will autogenerate one.")]
		private AudioSource audioSource;

		private AudioVisor audioVisor;

		private string clipName;

		public Koreography KoreoData => koreography;

		public AudioClip Clip => (!(koreography == null)) ? koreography.SourceClip : audioClip;

		public string ClipName
		{
			get
			{
				if (string.IsNullOrEmpty(clipName))
				{
					clipName = Clip.name;
				}
				return clipName;
			}
		}

		public AudioSource AudioSourceCom => audioSource;

		public AudioVisor Visor => audioVisor;

		public string Name => name;

		private MusicLayer()
		{
		}

		public MusicLayer(Koreography koreo, AudioSource source, string layerName = "")
		{
			koreography = koreo;
			audioClip = koreo.SourceClip;
			clipName = audioClip.name;
			audioSource = source;
			name = layerName;
		}

		public MusicLayer(AudioClip clip, AudioSource source, string layerName = "")
		{
			audioClip = clip;
			clipName = audioClip.name;
			audioSource = source;
			name = layerName;
		}

		public void Init(AudioSource source = null, Koreographer targetKoreographer = null)
		{
			if (source != null)
			{
				audioSource = source;
			}
			audioVisor = new AudioVisor(audioSource, targetKoreographer);
		}
	}
}
