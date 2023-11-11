using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace E7.Introloop
{
	internal class IntroloopTrack : MonoBehaviour
	{
		private AudioSource[] twoSources;

		internal IntroloopSettings introloopSettings;

		private IntroloopAudio music;

		private IntroloopAudio musicAboutToPlay;

		private double nextTransitionTime;

		private double playDspTimestamp;

		private double pauseDspTimestamp;

		private double pauseDspTotal;

		private int nextSourceToPlay;

		private double rememberHowFarFromNextTransitionTime;

		private bool isPlaying;

		private bool isPausing;

		private bool isPausingOnIntro;

		private double introFinishDspTime;

		private float startPlayingUnscaledClipTime;

		private int playingSourceBeforePause;

		private double dspPlusHalfAudio;

		private double[] sourceWillPlayTime;

		private double[] sourceWillEndTime;

		private float fadeVolume;

		private const float smallPrepareTime = 0.02f;

		internal IntroloopAudio Music => music;

		internal IntroloopAudio MusicAboutToPlay => musicAboutToPlay;

		internal bool IsPlaying => isPlaying;

		internal float PlayedTimeSecondsUnscaled
		{
			get
			{
				double num = 0.0;
				if (!isPlaying && !isPausing)
				{
					return 0f;
				}
				num = ((!isPausing && isPlaying) ? AudioSettings.dspTime : pauseDspTimestamp);
				return (float)(num - playDspTimestamp - pauseDspTotal);
			}
		}

		internal float PlayheadPositionSeconds
		{
			get
			{
				if (music == null)
				{
					return 0f;
				}
				float playedTimeSecondsUnscaled = PlayedTimeSecondsUnscaled;
				if (music.nonLooping)
				{
					return Mathf.Min(startPlayingUnscaledClipTime + playedTimeSecondsUnscaled * music.Pitch, music.UnscaledClipLength);
				}
				if (music.loopWholeAudio)
				{
					return (startPlayingUnscaledClipTime + playedTimeSecondsUnscaled * music.Pitch) % music.UnscaledClipLength;
				}
				float num = startPlayingUnscaledClipTime + playedTimeSecondsUnscaled * music.Pitch;
				if (num < music.UnscaledIntroLength)
				{
					return num;
				}
				return music.UnscaledIntroLength + (num - music.UnscaledIntroLength) % music.UnscaledLoopingLength;
			}
		}

		public string[] DebugInformation => new string[12]
		{
			"Playhead position :" + PlayheadPositionSeconds.ToString(".00"),
			"Source 1 Will Play :" + sourceWillPlayTime[0].ToString(".00"),
			"Source 1 Will End :" + sourceWillEndTime[0].ToString(".00"),
			"Source 2 Will Play :" + sourceWillPlayTime[1].ToString(".00"),
			"Source 2 Will End :" + sourceWillEndTime[1].ToString(".00"),
			"Source 1 : " + (twoSources[0].isPlaying ? "PLAYING/SCHEDULED" : "STOPPED"),
			"Source 2 : " + (twoSources[1].isPlaying ? "PLAYING/SCHEDULED" : "STOPPED"),
			"Source 1 Time : " + twoSources[0].time.ToString(".00"),
			"Source 2 Time : " + twoSources[1].time.ToString(".00"),
			"Next transition time : " + nextTransitionTime.ToString(".00"),
			"Dsp plus half audio : " + dspPlusHalfAudio.ToString(".00"),
			"Is pausing : " + isPausing
		};

		internal float FadeVolume
		{
			get
			{
				return fadeVolume;
			}
			set
			{
				float num = Mathf.Clamp01(value);
				fadeVolume = num;
				ApplyVolume();
			}
		}

		internal IEnumerable<AudioSource> AllAudioSources
		{
			get
			{
				if (twoSources == null)
				{
					throw new IntroloopException("Introloop is not yet initialized. Please avoid accessing internal AudioSource on Awake.");
				}
				return twoSources;
			}
		}

		private void Awake()
		{
			twoSources = new AudioSource[2];
			sourceWillPlayTime = new double[2];
			sourceWillEndTime = new double[2];
			Transform parent = base.gameObject.transform;
			GameObject obj = new GameObject("AudioSource 1");
			AudioSource audioSource = obj.AddComponent<AudioSource>();
			audioSource.playOnAwake = false;
			audioSource.loop = false;
			obj.transform.parent = parent;
			twoSources[0] = audioSource;
			GameObject obj2 = new GameObject("AudioSource 2");
			AudioSource audioSource2 = obj2.AddComponent<AudioSource>();
			audioSource2.playOnAwake = false;
			audioSource2.loop = false;
			obj2.transform.parent = parent;
			twoSources[1] = audioSource2;
		}

		internal void Unload()
		{
			music.Unload();
			IntroloopLog($"Unloaded \"{music.AudioClip.name}\" from memory.");
			twoSources[0].clip = null;
			twoSources[1].clip = null;
			music = null;
			musicAboutToPlay = null;
		}

		internal void SchedulingUpdate()
		{
			if (isPlaying && !music.nonLooping)
			{
				dspPlusHalfAudio = AudioSettings.dspTime + (double)(music.LoopingLength / 2f);
				if (dspPlusHalfAudio > nextTransitionTime)
				{
					ScheduleNextLoop();
				}
			}
		}

		private void ScheduleNextLoop()
		{
			SetScheduledEndTime((nextSourceToPlay + 1) % 2, nextTransitionTime);
			PlayScheduled(nextSourceToPlay, nextTransitionTime);
			twoSources[nextSourceToPlay].time = music.UnscaledIntroLength;
			nextTransitionTime += (music.loopWholeAudio ? music.ClipLength : music.LoopingLength);
			nextSourceToPlay = (nextSourceToPlay + 1) % 2;
		}

		internal void Stop()
		{
			twoSources[0].Stop();
			twoSources[1].Stop();
			pauseDspTimestamp = AudioSettings.dspTime;
			isPlaying = false;
			isPausing = false;
		}

		internal bool IsPausable()
		{
			if (!isPlaying || (!twoSources[0].isPlaying && !twoSources[1].isPlaying))
			{
				return false;
			}
			return true;
		}

		internal void Pause()
		{
			if (!isPlaying)
			{
				return;
			}
			if (twoSources[0].isPlaying && twoSources[1].isPlaying)
			{
				if (AudioSettings.dspTime < sourceWillPlayTime[0])
				{
					playingSourceBeforePause = 1;
				}
				else
				{
					playingSourceBeforePause = 0;
				}
			}
			else if (twoSources[0].isPlaying)
			{
				playingSourceBeforePause = 0;
			}
			else
			{
				playingSourceBeforePause = 1;
			}
			twoSources[0].Pause();
			twoSources[1].Pause();
			double dspTime = AudioSettings.dspTime;
			rememberHowFarFromNextTransitionTime = nextTransitionTime - dspTime;
			pauseDspTimestamp = dspTime;
			if (!music.nonLooping && !music.loopWholeAudio)
			{
				if (dspTime >= introFinishDspTime)
				{
					isPausingOnIntro = false;
				}
				else
				{
					isPausingOnIntro = true;
				}
			}
			isPlaying = false;
			isPausing = true;
			IntroloopLog("\"" + music.AudioClip.name + "\" paused.");
		}

		internal bool Resume()
		{
			if (!isPausing)
			{
				return false;
			}
			int num = playingSourceBeforePause;
			double dspTime = AudioSettings.dspTime;
			pauseDspTotal += dspTime - pauseDspTimestamp;
			float num2 = ((music.nonLooping || music.loopWholeAudio) ? (music.ClipLength - twoSources[num].time / music.Pitch) : ((!isPausingOnIntro) ? (music.IntroLength + music.LoopingLength - twoSources[num].time / music.Pitch) : (music.IntroLength - twoSources[num].time / music.Pitch)));
			SetScheduledEndTime(num, dspTime + (double)num2);
			SetScheduledStartTime(num, dspTime);
			PlayScheduled(num, dspTime);
			if (!music.nonLooping)
			{
				SetScheduledStartTime((num + 1) % 2, dspTime + (double)num2);
				PlayScheduled((num + 1) % 2, dspTime + (double)num2);
			}
			if (isPausingOnIntro)
			{
				introFinishDspTime = dspTime + (double)num2;
			}
			nextTransitionTime = AudioSettings.dspTime + rememberHowFarFromNextTransitionTime;
			isPlaying = true;
			isPausing = false;
			IntroloopLog("\"" + music.AudioClip.name + "\" resumed.");
			return true;
		}

		internal void Play(IntroloopAudio music, bool isFade, float startTime)
		{
			pauseDspTimestamp = 0.0;
			pauseDspTotal = 0.0;
			twoSources[0].pitch = music.Pitch;
			twoSources[1].pitch = music.Pitch;
			AudioDataLoadState loadState = music.AudioClip.loadState;
			string text = music.AudioClip.name;
			FadeVolume = ((!isFade) ? 1 : 0);
			if (loadState != AudioDataLoadState.Loaded)
			{
				IntroloopLog("\"" + text + "\" not loaded yet. Loading into memory...");
				StartCoroutine(LoadAndPlayRoutine(music, startTime));
			}
			else
			{
				IntroloopLog("\"" + text + "\" already loaded in memory.");
				SetupPlayingSchedule(music, startTime);
			}
		}

		private IEnumerator LoadAndPlayRoutine(IntroloopAudio music, float startTime)
		{
			string musicName = music.AudioClip.name;
			float startLoadingTime = Time.unscaledTime;
			music.AudioClip.LoadAudioData();
			while (music.AudioClip.loadState != AudioDataLoadState.Loaded && music.AudioClip.loadState != AudioDataLoadState.Failed)
			{
				yield return null;
			}
			if (music.AudioClip.loadState == AudioDataLoadState.Loaded)
			{
				float unscaledTime = Time.unscaledTime;
				if (music.AudioClip.loadInBackground)
				{
					IntroloopLog(musicName + " loading successful. (Took " + (unscaledTime - startLoadingTime) + " seconds loading in background.)");
				}
				else
				{
					IntroloopLog(musicName + " loading successful.");
				}
				SetupPlayingSchedule(music, startTime);
			}
			else
			{
				IntroloopLogError(musicName + " loading failed!");
			}
		}

		private void SetupPlayingSchedule(IntroloopAudio music, float startTime)
		{
			IntroloopLog("Playing \"" + music.AudioClip.name + "\"");
			musicAboutToPlay = music;
			musicAboutToPlay = null;
			this.music = music;
			ApplyVolume();
			nextSourceToPlay = 0;
			isPausing = false;
			twoSources[0].clip = music.AudioClip;
			twoSources[1].clip = music.AudioClip;
			Stop();
			double num = AudioSettings.dspTime + 0.019999999552965164;
			if (music.nonLooping)
			{
				if (startTime < music.UnscaledClipLength)
				{
					twoSources[0].time = startTime;
					twoSources[1].time = 0f;
					startPlayingUnscaledClipTime = startTime;
					PlayScheduled(0, num);
				}
				else
				{
					twoSources[0].time = 0f;
					twoSources[1].time = 0f;
					startPlayingUnscaledClipTime = music.UnscaledClipLength;
				}
				IntroloopLog("Type : Non-looping");
			}
			else if (music.loopWholeAudio)
			{
				float time = startTime % music.UnscaledClipLength;
				twoSources[0].time = time;
				twoSources[1].time = 0f;
				double num2 = num + (double)music.ClipLength - (double)(startTime / music.Pitch);
				PlayScheduled(0, num);
				SetScheduledEndTime(0, num2);
				introFinishDspTime = num2;
				PlayScheduled(1, num2);
				nextTransitionTime = num2 + (double)music.ClipLength;
				startPlayingUnscaledClipTime = time;
				IntroloopLog("Type : Loop whole audio");
			}
			else
			{
				if (startTime < music.UnscaledIntroLength)
				{
					double num3 = num + (double)music.IntroLength - (double)(startTime / music.Pitch);
					twoSources[0].time = startTime;
					twoSources[1].time = music.UnscaledIntroLength;
					PlayScheduled(0, num);
					SetScheduledEndTime(0, num3);
					introFinishDspTime = num3;
					PlayScheduled(1, num3);
					nextTransitionTime = num3 + (double)music.LoopingLength;
					startPlayingUnscaledClipTime = startTime;
				}
				else
				{
					float num4 = music.UnscaledIntroLength + (startTime - music.UnscaledIntroLength) % music.UnscaledLoopingLength - music.UnscaledIntroLength;
					float num5 = num4 / music.Pitch;
					float num6 = music.LoopingLength - num5;
					double num7 = num + (double)num6;
					twoSources[0].time = music.UnscaledIntroLength + num4;
					twoSources[1].time = music.UnscaledIntroLength + music.UnscaledLoopingLength;
					PlayScheduled(0, num);
					nextTransitionTime = num7;
					nextSourceToPlay = 1;
					ScheduleNextLoop();
					introFinishDspTime = num - (double)num5;
					startPlayingUnscaledClipTime = music.UnscaledIntroLength + num4;
				}
				IntroloopLog("Type : Introloop");
			}
			playDspTimestamp = num;
			pauseDspTimestamp = 0.0;
			pauseDspTotal = 0.0;
			isPlaying = true;
		}

		internal void ApplyVolume()
		{
			if (music != null)
			{
				twoSources[0].volume = FadeVolume * music.Volume;
				twoSources[1].volume = FadeVolume * music.Volume;
			}
		}

		private void PlayScheduled(int sourceNumber, double absoluteTime)
		{
			twoSources[sourceNumber].PlayScheduled(absoluteTime);
			sourceWillPlayTime[sourceNumber] = absoluteTime;
		}

		private void SetScheduledEndTime(int sourceNumber, double absoluteTime)
		{
			twoSources[sourceNumber].SetScheduledEndTime(absoluteTime);
			sourceWillEndTime[sourceNumber] = absoluteTime;
		}

		private void SetScheduledStartTime(int sourceNumber, double absoluteTime)
		{
			twoSources[sourceNumber].SetScheduledStartTime(absoluteTime);
			sourceWillPlayTime[sourceNumber] = absoluteTime;
		}

		internal void IntroloopLog(string logMessage)
		{
			if (introloopSettings.logInformation)
			{
				Debug.Log("[Introloop - " + base.gameObject.name + "] " + logMessage);
			}
		}

		internal void IntroloopLogError(string logMessage)
		{
			if (introloopSettings.logInformation)
			{
				Debug.Log("<color=red>[Introloop - " + base.gameObject.name + "]</color> " + logMessage);
			}
		}
	}
}
