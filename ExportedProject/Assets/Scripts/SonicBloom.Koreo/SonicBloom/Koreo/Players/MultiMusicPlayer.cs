using System.Collections.Generic;
using UnityEngine;

namespace SonicBloom.Koreo.Players
{
	[AddComponentMenu("Koreographer/Music Players/Multi Music Player")]
	public class MultiMusicPlayer : MonoBehaviour, IKoreographedPlayer
	{
		[SerializeField]
		[Tooltip("If synchronization fails, increase this value (in seconds) to ensure synchronization across layers.")]
		private double syncPlayDelay;

		[Tooltip("Initial pitch applied to all layers.")]
		[SerializeField]
		private float pitch = 1f;

		[Tooltip("Whether or not the music player should start up looping.")]
		[SerializeField]
		private bool loop;

		[Tooltip("When Music Layers are specified, this determines whether to play immediately on Awake() or not.")]
		[SerializeField]
		private bool autoPlayOnAwake = true;

		[SerializeField]
		[Tooltip("Music Layers.  Koreographed layers should come first.")]
		private List<MusicLayer> musicLayers = new List<MusicLayer>();

		[Tooltip("[Optional] Specify a target Koreographer component to use for Koreography Event reporting and Music Time API support.  If no Koreographer is specified, the default global Koreographer component reference will be used.")]
		[SerializeField]
		private Koreographer targetKoreographer;

		private bool bWaitingToPlay;

		public float Pitch
		{
			get
			{
				return pitch;
			}
			set
			{
				pitch = value;
				for (int i = 0; i < musicLayers.Count; i++)
				{
					musicLayers[i].AudioSourceCom.pitch = pitch;
				}
			}
		}

		public bool Loop
		{
			get
			{
				return loop;
			}
			set
			{
				loop = value;
				for (int i = 0; i < musicLayers.Count; i++)
				{
					musicLayers[i].AudioSourceCom.loop = loop;
				}
			}
		}

		public float Volume
		{
			set
			{
				for (int i = 0; i < musicLayers.Count; i++)
				{
					musicLayers[i].AudioSourceCom.volume = value;
				}
			}
		}

		public bool IsPlaying
		{
			get
			{
				bool result = false;
				if (musicLayers.Count > 0)
				{
					result = musicLayers[0].AudioSourceCom.isPlaying;
				}
				return result;
			}
		}

		private void Awake()
		{
			if (targetKoreographer == null)
			{
				targetKoreographer = Koreographer.Instance;
			}
			targetKoreographer.musicPlaybackController = this;
			InitializeLayers();
			if (musicLayers.Count > 0)
			{
				LoadKoreographyAndStart(0, autoPlayOnAwake);
			}
		}

		private void Update()
		{
			if (bWaitingToPlay && IsReadyForPlayback())
			{
				PlayInternal();
			}
			for (int i = 0; i < musicLayers.Count; i++)
			{
				musicLayers[i].Visor.Update();
			}
		}

		private void OnDestroy()
		{
			if (targetKoreographer != null)
			{
				for (int i = 0; i < musicLayers.Count; i++)
				{
					MusicLayer musicLayer = musicLayers[i];
					if (musicLayer.KoreoData != null)
					{
						targetKoreographer.UnloadKoreography(musicLayer.KoreoData);
					}
				}
			}
			musicLayers.Clear();
		}

		private void InitializeLayers()
		{
			musicLayers.RemoveAll((MusicLayer x) => x.Clip == null);
			if (musicLayers.Count <= 0)
			{
				return;
			}
			int samples = musicLayers[0].Clip.samples;
			for (int i = 1; i < musicLayers.Count; i++)
			{
				AudioClip clip = musicLayers[i].Clip;
				if (clip.samples % samples != 0 && samples % clip.samples != 0)
				{
					Debug.LogWarning(string.Concat("Music layer at index ", i, " using AudioClip '", clip, "' has unexpected sample length!\nExpected ", samples, ".\nFound ", clip.samples, ".\nThis will cause synchronization problems if/when the audio loops!"));
				}
			}
			for (int j = 0; j < musicLayers.Count; j++)
			{
				MusicLayer musicLayer = musicLayers[j];
				AudioSource source = null;
				if (musicLayer.AudioSourceCom == null)
				{
					source = base.gameObject.AddComponent<AudioSource>();
				}
				musicLayer.Init(source, targetKoreographer);
				source = musicLayer.AudioSourceCom;
				source.clip = musicLayer.Clip;
				source.pitch = pitch;
				source.loop = loop;
				source.playOnAwake = false;
				if (!musicLayer.Clip.preloadAudioData && musicLayer.Clip.loadState != AudioDataLoadState.Loading && musicLayer.Clip.loadState != AudioDataLoadState.Loaded)
				{
					musicLayer.Clip.LoadAudioData();
				}
			}
		}

		private void LoadKoreographyAndStart(int startSampleTime = 0, bool autoPlay = true)
		{
			if (musicLayers.Count <= 0)
			{
				return;
			}
			for (int i = 0; i < musicLayers.Count; i++)
			{
				MusicLayer musicLayer = musicLayers[i];
				if (musicLayer.KoreoData != null)
				{
					targetKoreographer.LoadKoreography(musicLayer.KoreoData);
				}
			}
			SeekToSample(startSampleTime);
			if (autoPlay)
			{
				Play();
			}
		}

		private void PlayInternal()
		{
			double num = AudioSettings.dspTime + syncPlayDelay;
			for (int i = 0; i < musicLayers.Count; i++)
			{
				MusicLayer musicLayer = musicLayers[i];
				musicLayer.AudioSourceCom.PlayScheduled(num);
				musicLayer.Visor.ScheduledPlayTime = num;
			}
			bWaitingToPlay = false;
		}

		private bool IsReadyForPlayback()
		{
			bool result = true;
			for (int i = 0; i < musicLayers.Count; i++)
			{
				if (musicLayers[i].Clip.loadState != AudioDataLoadState.Loaded)
				{
					result = false;
					break;
				}
			}
			return result;
		}

		private int GetIndexOfLayerWithClipName(string clipName)
		{
			int result = -1;
			for (int i = 0; i < musicLayers.Count; i++)
			{
				if (musicLayers[i].ClipName == clipName)
				{
					result = i;
					break;
				}
			}
			return result;
		}

		public void LoadSong(List<MusicLayer> layers, int startSampleTime = 0, bool autoPlay = true)
		{
			Stop();
			for (int i = 0; i < musicLayers.Count; i++)
			{
				MusicLayer musicLayer = musicLayers[i];
				if (musicLayer.KoreoData != null)
				{
					targetKoreographer.UnloadKoreography(musicLayer.KoreoData);
				}
			}
			musicLayers.Clear();
			musicLayers.AddRange(layers);
			InitializeLayers();
			LoadKoreographyAndStart(startSampleTime, autoPlay);
		}

		public void Play()
		{
			if (IsReadyForPlayback())
			{
				PlayInternal();
			}
			else
			{
				bWaitingToPlay = true;
			}
		}

		public void Stop()
		{
			for (int i = 0; i < musicLayers.Count; i++)
			{
				musicLayers[i].AudioSourceCom.Stop();
			}
		}

		public void Pause()
		{
			for (int i = 0; i < musicLayers.Count; i++)
			{
				musicLayers[i].AudioSourceCom.Pause();
			}
		}

		public void SeekToSample(int targetSample)
		{
			for (int i = 0; i < musicLayers.Count; i++)
			{
				musicLayers[i].AudioSourceCom.timeSamples = targetSample;
				musicLayers[i].Visor.ResyncTimings();
			}
		}

		public void SetVolumeForLayer(int layerNum, float volume)
		{
			if (layerNum >= 0 && layerNum < musicLayers.Count)
			{
				musicLayers[layerNum].AudioSourceCom.volume = volume;
			}
		}

		public void SetVolumeForLayer(string layerName, float volume)
		{
			SetVolumeForLayer(musicLayers.FindIndex((MusicLayer x) => x.Name == layerName), volume);
		}

		public int GetSampleTimeForClip(string clipName)
		{
			int result = 0;
			int indexOfLayerWithClipName = GetIndexOfLayerWithClipName(clipName);
			if (indexOfLayerWithClipName >= 0)
			{
				result = musicLayers[indexOfLayerWithClipName].Visor.GetCurrentTimeInSamples();
			}
			return result;
		}

		public int GetTotalSampleTimeForClip(string clipName)
		{
			int result = 0;
			int indexOfLayerWithClipName = GetIndexOfLayerWithClipName(clipName);
			if (indexOfLayerWithClipName >= 0)
			{
				result = musicLayers[indexOfLayerWithClipName].Clip.samples;
			}
			return result;
		}

		public bool GetIsPlaying(string clipName)
		{
			int indexOfLayerWithClipName = GetIndexOfLayerWithClipName(clipName);
			MusicLayer musicLayer = musicLayers[indexOfLayerWithClipName];
			return indexOfLayerWithClipName >= 0 && musicLayer.AudioSourceCom.isPlaying && musicLayer.Visor.ScheduledPlayTime <= AudioSettings.dspTime;
		}

		public float GetPitch(string clipName)
		{
			return Pitch;
		}

		public string GetCurrentClipName()
		{
			return musicLayers[0].ClipName;
		}
	}
}
