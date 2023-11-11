using System;
using System.Collections.Generic;
using System.Threading;
using Rewired.Config;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;

namespace Rewired.InputSources.SDL2
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class SDL2InputSource : IDisposable, IInputSource
	{
		public delegate void UwVpseBRKKJofQOnyBOCEMrsakxq(int joystickId, byte rewiredElementType, byte elementIndex, short value);

		public delegate void lkaFWZBPWInbOoKVQuxChKGGynG(int joystickIndex);

		public delegate void zKvpgmNTHYLvAtbhMacggvJEqxlF(int joystickId);

		public delegate void LFAcPyHhTvbTfMaMZSizbdGblZh(int gameControllerId, byte rewiredElementType, byte sdlElementType, short value);

		private const int JYAqduqAlaCVssjKFMcPeXvnVlp = 32;

		private bool JuswGXvahdcTCFokZmumGbXdbXtf;

		private bool OPuozRtMQdvUoOWIwjDgdTyGIVa;

		private bool hWmdzzHhbaStzcVAzRSIWLqtMMc;

		private bool GEFBXlEGMVbfwnVyMeceMvDFHXV;

		private bool vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		private ADictionary<int, GhtkyNwZLPROQElMmIjqvOGKMcB> mqdAbRkCKsLDODrmCZPalaGwyaPz;

		private ADictionary<int, ynfCalBMsuLnMacVhVpWQHwhYshf> YoRVVFCSmPcBZGlZZUCDmRUsheKP;

		private fIdCQKGsUXtETiYichZnMfYilrGQ.lwiKqzgGsKEnzShORSoIoXDgZwH dOLnoPZsOPZLOhaSQjVGIyoosZi;

		private NativeBuffer UYWeDPRxCaaKyTVhyHfvImUUBWdP;

		private Action MZzDMLKCKSSDOoDIHTxbEgXkaTPJ;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public bool initialized => vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		private event Action _DeviceChangedEvent
		{
			add
			{
				Action action = MZzDMLKCKSSDOoDIHTxbEgXkaTPJ;
				Action action2;
				do
				{
					action2 = action;
					Action value2 = (Action)Delegate.Combine(action2, value);
					action = Interlocked.CompareExchange(ref MZzDMLKCKSSDOoDIHTxbEgXkaTPJ, value2, action2);
				}
				while ((object)action != action2);
			}
			remove
			{
				Action action = MZzDMLKCKSSDOoDIHTxbEgXkaTPJ;
				Action action2;
				do
				{
					action2 = action;
					Action value2 = (Action)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref MZzDMLKCKSSDOoDIHTxbEgXkaTPJ, value2, action2);
				}
				while ((object)action != action2);
			}
		}

		public event Action DeviceChangedEvent
		{
			add
			{
				_DeviceChangedEvent += value;
			}
			remove
			{
				_DeviceChangedEvent -= value;
			}
		}

		public SDL2InputSource(UpdateLoopSetting updateLoop, bool handleJoysticks, bool handleGamepads, bool handleUnifiedMouse, bool handleUnifiedKeyboard)
		{
			JuswGXvahdcTCFokZmumGbXdbXtf = handleJoysticks;
			OPuozRtMQdvUoOWIwjDgdTyGIVa = handleGamepads;
			hWmdzzHhbaStzcVAzRSIWLqtMMc = handleUnifiedMouse;
			GEFBXlEGMVbfwnVyMeceMvDFHXV = handleUnifiedKeyboard;
			mqdAbRkCKsLDODrmCZPalaGwyaPz = new ADictionary<int, GhtkyNwZLPROQElMmIjqvOGKMcB>();
			YoRVVFCSmPcBZGlZZUCDmRUsheKP = new ADictionary<int, ynfCalBMsuLnMacVhVpWQHwhYshf>();
			int num = ((!UnityTools.isEditor || UnityTools.editorPlatform != EditorPlatform.OSX) ? 29184 : 25088);
			try
			{
				fIdCQKGsUXtETiYichZnMfYilrGQ.MBxOebSJSZVcpxFzWflQEKPDxUs(UnityTools.effectivePlatform);
				if (fIdCQKGsUXtETiYichZnMfYilrGQ.YtnlkYTgPbDjBpRVsjOVIjRccgnJ((uint)num) < 0)
				{
					throw new Exception("Failed initialize SDL2!");
				}
				vqjuhdYKKuBgDKqCJHOYrBTbbEX = true;
				if (handleGamepads)
				{
					aYrGtaHQzGsHwKNNwWxrkBGHpSLe();
				}
				mfQlLwieKqeWAbHRrNTFTraCxEgv();
				UYWeDPRxCaaKyTVhyHfvImUUBWdP = new NativeBuffer(56);
			}
			catch
			{
				vqjuhdYKKuBgDKqCJHOYrBTbbEX = false;
				Dispose();
				throw;
			}
		}

		public void SystemDeviceConnected()
		{
			throw new NotImplementedException();
		}

		public void SystemDeviceDisconnected()
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			_ = vqjuhdYKKuBgDKqCJHOYrBTbbEX;
		}

		public void UpdateDevices(UpdateLoopType updateLoop)
		{
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				zEbOLdNXkfKrhYpJzWHpjFNdxIq();
			}
		}

		public void UpdateFinished()
		{
			_ = vqjuhdYKKuBgDKqCJHOYrBTbbEX;
		}

		public IList<T> GetJoysticks<T>() where T : class
		{
			if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				return null;
			}
			List<HpPUYiSsBwKxKGqHrpbgrhShPgI> list = new List<HpPUYiSsBwKxKGqHrpbgrhShPgI>();
			if (JuswGXvahdcTCFokZmumGbXdbXtf)
			{
				foreach (KeyValuePair<int, GhtkyNwZLPROQElMmIjqvOGKMcB> item in mqdAbRkCKsLDODrmCZPalaGwyaPz)
				{
					GhtkyNwZLPROQElMmIjqvOGKMcB value = item.Value;
					if (value.LXZqqcaJgmTjdtxNIuLgtFqZePA)
					{
						list.Add(item.Value);
					}
				}
			}
			if (OPuozRtMQdvUoOWIwjDgdTyGIVa)
			{
				foreach (KeyValuePair<int, ynfCalBMsuLnMacVhVpWQHwhYshf> item2 in YoRVVFCSmPcBZGlZZUCDmRUsheKP)
				{
					ynfCalBMsuLnMacVhVpWQHwhYshf value2 = item2.Value;
					if (value2.LXZqqcaJgmTjdtxNIuLgtFqZePA)
					{
						list.Add(value2);
					}
				}
			}
			return list as IList<T>;
		}

		private int SmerPyLRfTExjHakjgqyGMnDzMhL()
		{
			if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				return 0;
			}
			return Math.Min(fIdCQKGsUXtETiYichZnMfYilrGQ.sERmulMdrkpExrvvBGqLBEgiePw(), 32);
		}

		private int EiTGnAgxEXZHMWlcuZwLWtBbqFi()
		{
			if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				return 0;
			}
			int num = SmerPyLRfTExjHakjgqyGMnDzMhL();
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				if (!fIdCQKGsUXtETiYichZnMfYilrGQ.NWJVvlekJBgLTWKJQrGztKnhNQe(i))
				{
					num2++;
				}
			}
			return num2;
		}

		private GhtkyNwZLPROQElMmIjqvOGKMcB dfwijrffVQkkwFuQKllOrideLnl(int P_0)
		{
			IntPtr intPtr = fIdCQKGsUXtETiYichZnMfYilrGQ.gunTeGfOTksjLbxCwkLUzEBcMgf(P_0);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			NlsmASWTVmJsFVheQAQWfhQWLBeY nlsmASWTVmJsFVheQAQWfhQWLBeY = new NlsmASWTVmJsFVheQAQWfhQWLBeY(intPtr);
			jMKaPgLzGvaHTAThgsaZcxGXSyF jMKaPgLzGvaHTAThgsaZcxGXSyF = mNejxIrPuKKgWjkEozgkdIhwERW(P_0, nlsmASWTVmJsFVheQAQWfhQWLBeY);
			if (jMKaPgLzGvaHTAThgsaZcxGXSyF == null)
			{
				fIdCQKGsUXtETiYichZnMfYilrGQ.rwNhRmiJmblIhFdwIIFvzDmypog(intPtr);
				return null;
			}
			return new GhtkyNwZLPROQElMmIjqvOGKMcB(nlsmASWTVmJsFVheQAQWfhQWLBeY, jMKaPgLzGvaHTAThgsaZcxGXSyF);
		}

		private ynfCalBMsuLnMacVhVpWQHwhYshf LNDeMVlXpZHzpHWmBifXBhnycsk(int P_0)
		{
			IntPtr intPtr = fIdCQKGsUXtETiYichZnMfYilrGQ.doDdfyGunPrOwAkahEVHDoKfkbHs(P_0);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			WkBirhMEdkBMtEuwfIxsHwEaGYdr wkBirhMEdkBMtEuwfIxsHwEaGYdr = new WkBirhMEdkBMtEuwfIxsHwEaGYdr(intPtr);
			jMKaPgLzGvaHTAThgsaZcxGXSyF jMKaPgLzGvaHTAThgsaZcxGXSyF = ejVYryjBVsHxvIqEJFWhkNMSVqs(P_0, wkBirhMEdkBMtEuwfIxsHwEaGYdr);
			if (jMKaPgLzGvaHTAThgsaZcxGXSyF == null)
			{
				return null;
			}
			if (!jMKaPgLzGvaHTAThgsaZcxGXSyF.PxBLFWvQDgtBnhXjHtzZfVMPnUN)
			{
				fIdCQKGsUXtETiYichZnMfYilrGQ.dIxOkaJGyYtoZPOBQGAfJutFZPmD(intPtr);
				return null;
			}
			jMKaPgLzGvaHTAThgsaZcxGXSyF.cwXKEfmJwgVuncJVtimNSLaSlwa = fIdCQKGsUXtETiYichZnMfYilrGQ.JfAIyBcdjXYFjKdjalXXlBNYNaIf(wkBirhMEdkBMtEuwfIxsHwEaGYdr);
			return new ynfCalBMsuLnMacVhVpWQHwhYshf(wkBirhMEdkBMtEuwfIxsHwEaGYdr, jMKaPgLzGvaHTAThgsaZcxGXSyF);
		}

		private jMKaPgLzGvaHTAThgsaZcxGXSyF mNejxIrPuKKgWjkEozgkdIhwERW(int P_0, NlsmASWTVmJsFVheQAQWfhQWLBeY P_1)
		{
			if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				return null;
			}
			if (P_0 < 0 || P_0 >= 32)
			{
				return null;
			}
			if (P_1 == null || !P_1.IsValid)
			{
				return null;
			}
			jMKaPgLzGvaHTAThgsaZcxGXSyF jMKaPgLzGvaHTAThgsaZcxGXSyF = new jMKaPgLzGvaHTAThgsaZcxGXSyF();
			jMKaPgLzGvaHTAThgsaZcxGXSyF.QIzoBncePxUUbbqEfLpERqPqJaL = P_0;
			jMKaPgLzGvaHTAThgsaZcxGXSyF.mwTxXrbbhfRpdwAUSEMlptKkOji = fIdCQKGsUXtETiYichZnMfYilrGQ.GSOOWeivHRCajzOOVAXiGIlUFqA(P_1);
			jMKaPgLzGvaHTAThgsaZcxGXSyF.PxBLFWvQDgtBnhXjHtzZfVMPnUN = fIdCQKGsUXtETiYichZnMfYilrGQ.NWJVvlekJBgLTWKJQrGztKnhNQe(P_0);
			jMKaPgLzGvaHTAThgsaZcxGXSyF.YnFDimKfsuivjwaGSApbpFmhYUi = fIdCQKGsUXtETiYichZnMfYilrGQ.MtTaRKvfMlLphhajGbYQTQjtxcM(P_1);
			jMKaPgLzGvaHTAThgsaZcxGXSyF.QILzOfqCHZbqrubdcbPjBcElyHOf = fIdCQKGsUXtETiYichZnMfYilrGQ.aTGMZotHNzLHlrYEpwMMrqFCRzg(P_1);
			jMKaPgLzGvaHTAThgsaZcxGXSyF.QLFuWFmTJTboLBFWpXydEiPkQqb = fIdCQKGsUXtETiYichZnMfYilrGQ.slNZjvRWksQQdhRHWEbJqBWvQhz(P_0);
			jMKaPgLzGvaHTAThgsaZcxGXSyF.aumNItRblDdXZicbRkrPApteCjR = fIdCQKGsUXtETiYichZnMfYilrGQ.KoTehTIkkjKSLxgeOLLvOvpczrah(P_1);
			jMKaPgLzGvaHTAThgsaZcxGXSyF.beRmxTPYgeEljczGnIuTQeGMXoR = fIdCQKGsUXtETiYichZnMfYilrGQ.cQJAgZqCJCUXzOjEaqQgWNPbFktd(P_1);
			jMKaPgLzGvaHTAThgsaZcxGXSyF.EAGWFmBKpkybcagmIjuwLbeGjsr = fIdCQKGsUXtETiYichZnMfYilrGQ.waBpPTUHFhSKvLpEJnBjlisjuuO(P_1);
			jMKaPgLzGvaHTAThgsaZcxGXSyF.StdYsitlniAVVqdtCruyjpWnHBB = fIdCQKGsUXtETiYichZnMfYilrGQ.UCwvyJGlxdgaBcZCpkWhmNlTnvh(P_1);
			return jMKaPgLzGvaHTAThgsaZcxGXSyF;
		}

		private jMKaPgLzGvaHTAThgsaZcxGXSyF ejVYryjBVsHxvIqEJFWhkNMSVqs(int P_0, WkBirhMEdkBMtEuwfIxsHwEaGYdr P_1)
		{
			if (P_1 == null || !P_1.IsValid)
			{
				return null;
			}
			NlsmASWTVmJsFVheQAQWfhQWLBeY nlsmASWTVmJsFVheQAQWfhQWLBeY = new NlsmASWTVmJsFVheQAQWfhQWLBeY(fIdCQKGsUXtETiYichZnMfYilrGQ.preOGCQxQEtvpQSlQJnikPmcdOG(P_1));
			if (!nlsmASWTVmJsFVheQAQWfhQWLBeY.IsValid)
			{
				return null;
			}
			return mNejxIrPuKKgWjkEozgkdIhwERW(P_0, nlsmASWTVmJsFVheQAQWfhQWLBeY);
		}

		private void mfQlLwieKqeWAbHRrNTFTraCxEgv()
		{
			for (int i = 0; i < SmerPyLRfTExjHakjgqyGMnDzMhL(); i++)
			{
				if (JuswGXvahdcTCFokZmumGbXdbXtf)
				{
					jXcIleFqupiPcaNOuNJYVoHIGet(i);
				}
				if (OPuozRtMQdvUoOWIwjDgdTyGIVa)
				{
					hVsqoyUtMVRUeMmHGcqHAnlqVNq(i);
				}
			}
		}

		private void YqHeCRuFaULEaPEhDsJWIlAJPDR()
		{
			if (OPuozRtMQdvUoOWIwjDgdTyGIVa)
			{
				foreach (KeyValuePair<int, ynfCalBMsuLnMacVhVpWQHwhYshf> item in YoRVVFCSmPcBZGlZZUCDmRUsheKP)
				{
					ynfCalBMsuLnMacVhVpWQHwhYshf value = item.Value;
					value.XTQpLCclhfpSwEfobYcepsEycEx();
					value.Dispose();
				}
				YoRVVFCSmPcBZGlZZUCDmRUsheKP.Clear();
			}
			if (!JuswGXvahdcTCFokZmumGbXdbXtf)
			{
				return;
			}
			foreach (KeyValuePair<int, GhtkyNwZLPROQElMmIjqvOGKMcB> item2 in mqdAbRkCKsLDODrmCZPalaGwyaPz)
			{
				GhtkyNwZLPROQElMmIjqvOGKMcB value2 = item2.Value;
				value2.XTQpLCclhfpSwEfobYcepsEycEx();
				value2.Dispose();
			}
			mqdAbRkCKsLDODrmCZPalaGwyaPz.Clear();
		}

		private bool jXcIleFqupiPcaNOuNJYVoHIGet(int P_0)
		{
			if (P_0 < 0 || P_0 >= 32)
			{
				return false;
			}
			if (OPuozRtMQdvUoOWIwjDgdTyGIVa && fIdCQKGsUXtETiYichZnMfYilrGQ.NWJVvlekJBgLTWKJQrGztKnhNQe(P_0))
			{
				return false;
			}
			GhtkyNwZLPROQElMmIjqvOGKMcB ghtkyNwZLPROQElMmIjqvOGKMcB = dfwijrffVQkkwFuQKllOrideLnl(P_0);
			if (ghtkyNwZLPROQElMmIjqvOGKMcB == null)
			{
				return false;
			}
			int nIyzgmlOTPDIunKnZBGAUSLRKnL = ghtkyNwZLPROQElMmIjqvOGKMcB.nIyzgmlOTPDIunKnZBGAUSLRKnL;
			if (mqdAbRkCKsLDODrmCZPalaGwyaPz.ContainsKey(nIyzgmlOTPDIunKnZBGAUSLRKnL))
			{
				mqdAbRkCKsLDODrmCZPalaGwyaPz[nIyzgmlOTPDIunKnZBGAUSLRKnL].XTQpLCclhfpSwEfobYcepsEycEx();
				mqdAbRkCKsLDODrmCZPalaGwyaPz[nIyzgmlOTPDIunKnZBGAUSLRKnL] = ghtkyNwZLPROQElMmIjqvOGKMcB;
			}
			else
			{
				mqdAbRkCKsLDODrmCZPalaGwyaPz.Add(nIyzgmlOTPDIunKnZBGAUSLRKnL, ghtkyNwZLPROQElMmIjqvOGKMcB);
			}
			ghtkyNwZLPROQElMmIjqvOGKMcB.ijQPrfbohIDtyfCSvLMVhrlmSpB();
			return true;
		}

		private void JWZmhyjAyCCSfFSFTwjTOGtVJIh(int P_0)
		{
			if (mqdAbRkCKsLDODrmCZPalaGwyaPz.ContainsKey(P_0))
			{
				mqdAbRkCKsLDODrmCZPalaGwyaPz[P_0].XTQpLCclhfpSwEfobYcepsEycEx();
				mqdAbRkCKsLDODrmCZPalaGwyaPz.Remove(P_0);
			}
		}

		private bool hVsqoyUtMVRUeMmHGcqHAnlqVNq(int P_0)
		{
			if (P_0 < 0 || P_0 >= 32)
			{
				return false;
			}
			if (!fIdCQKGsUXtETiYichZnMfYilrGQ.NWJVvlekJBgLTWKJQrGztKnhNQe(P_0))
			{
				return false;
			}
			ynfCalBMsuLnMacVhVpWQHwhYshf ynfCalBMsuLnMacVhVpWQHwhYshf = LNDeMVlXpZHzpHWmBifXBhnycsk(P_0);
			if (ynfCalBMsuLnMacVhVpWQHwhYshf == null)
			{
				return false;
			}
			int nIyzgmlOTPDIunKnZBGAUSLRKnL = ynfCalBMsuLnMacVhVpWQHwhYshf.nIyzgmlOTPDIunKnZBGAUSLRKnL;
			if (YoRVVFCSmPcBZGlZZUCDmRUsheKP.ContainsKey(nIyzgmlOTPDIunKnZBGAUSLRKnL))
			{
				YoRVVFCSmPcBZGlZZUCDmRUsheKP[nIyzgmlOTPDIunKnZBGAUSLRKnL].XTQpLCclhfpSwEfobYcepsEycEx();
				YoRVVFCSmPcBZGlZZUCDmRUsheKP[nIyzgmlOTPDIunKnZBGAUSLRKnL] = ynfCalBMsuLnMacVhVpWQHwhYshf;
			}
			else
			{
				YoRVVFCSmPcBZGlZZUCDmRUsheKP.Add(nIyzgmlOTPDIunKnZBGAUSLRKnL, ynfCalBMsuLnMacVhVpWQHwhYshf);
			}
			ynfCalBMsuLnMacVhVpWQHwhYshf.ijQPrfbohIDtyfCSvLMVhrlmSpB();
			return true;
		}

		private void FwQBLSDUxaiHsiARfUMfkYIxdAp(int P_0)
		{
			if (YoRVVFCSmPcBZGlZZUCDmRUsheKP.ContainsKey(P_0))
			{
				YoRVVFCSmPcBZGlZZUCDmRUsheKP[P_0].XTQpLCclhfpSwEfobYcepsEycEx();
				YoRVVFCSmPcBZGlZZUCDmRUsheKP.Remove(P_0);
			}
		}

		private GhtkyNwZLPROQElMmIjqvOGKMcB ixLoAmVCoNHUAALFitaHqNgQpPNp(int P_0)
		{
			if (!mqdAbRkCKsLDODrmCZPalaGwyaPz.TryGetValue(P_0, out var value))
			{
				return null;
			}
			return value;
		}

		private ynfCalBMsuLnMacVhVpWQHwhYshf cwcAjFhMYfLsvAxjajmIioidnmdZ(int P_0)
		{
			if (!YoRVVFCSmPcBZGlZZUCDmRUsheKP.TryGetValue(P_0, out var value))
			{
				return null;
			}
			return value;
		}

		private void zEbOLdNXkfKrhYpJzWHpjFNdxIq()
		{
			while (fIdCQKGsUXtETiYichZnMfYilrGQ.ewhkYeEgGEmNIsrSQLNalBpuGmTA(UYWeDPRxCaaKyTVhyHfvImUUBWdP) != 0)
			{
				dOLnoPZsOPZLOhaSQjVGIyoosZi.lReKedFWmfpraDFOrJWqECXrjbz(UYWeDPRxCaaKyTVhyHfvImUUBWdP);
				fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ flYmSKXdxEbrkbApyjuUarnstyO = dOLnoPZsOPZLOhaSQjVGIyoosZi.flYmSKXdxEbrkbApyjuUarnstyO;
				double realTime = ReInput.realTime;
				switch (flYmSKXdxEbrkbApyjuUarnstyO)
				{
				case fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ.kZXfcReGKhBgkQxvzuEjfRFFjmtX:
					LEMnPeFcXRfxrCNDoMIuvtPCNjv(ref dOLnoPZsOPZLOhaSQjVGIyoosZi.pVRAuygexDETbSJDyJZsuXnrdcYI, realTime);
					break;
				case fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ.AzPKtlpYeTSLQcqXBgSvooDNUld:
				case fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ.kKngLGmbREWdlMORtqCmJmGwDjGK:
					qibLOjUMsbflxfjrXEGFcaPawbE(ref dOLnoPZsOPZLOhaSQjVGIyoosZi.PHMApzhdCxwdHRVPgUrAarUcXWsn, realTime);
					break;
				case fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ.rzYHDiHiTXpYhZnAZuZBjUeILon:
					CYSMTBTNAxqHOSmnbjRUsQHCbCUc(ref dOLnoPZsOPZLOhaSQjVGIyoosZi.KTxfPEEzjCISazkoXgrDitVduqTu);
					break;
				case fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ.kOpSEwiuFMSApWoUFkikRUorUZy:
					TvRdNxauGxGvRFxdbNnlDiJmICjV(ref dOLnoPZsOPZLOhaSQjVGIyoosZi.RbwlBLkSZxdiUPLYkJDdIgpEDzC, realTime);
					break;
				case fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ.fIlOCqZjDTnGpjglVJFZHIrBPCK:
				case fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ.OCdwJLJqjTGaYdhlvquXGEWssns:
					HhoMXXxxnPSozpCXIRkMXPMsTtC(ref dOLnoPZsOPZLOhaSQjVGIyoosZi.nZREZVMzmNNIHwmLrWEdCdgzRzg, realTime);
					break;
				case fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ.GUlFsUekHXxKpWGKPIjCjntRbYCD:
					aLwUKMVMUJyTfIdyQCyrldVUnRw(ref dOLnoPZsOPZLOhaSQjVGIyoosZi.NWagpnZwVmMpYLeGCzPgzMFGnBu, realTime);
					break;
				case fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ.LHqhGuGkBmEuFkCCQAwrWWSCtDk:
					mxHJkOIAYAwpfeKOCuCVjuXguVg(ref dOLnoPZsOPZLOhaSQjVGIyoosZi.LjBBJQrRywxErIjUyDPuWaIngyJ, realTime);
					break;
				case fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ.hXpaYsgxUzkeIxZbrLMZramjVzoj:
					klhajEIiOcUqkOkfSWXYTucPLsM(ref dOLnoPZsOPZLOhaSQjVGIyoosZi.sgJBclOidlalkDqxriOHNdSqOPhq);
					break;
				case fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ.QzGXPMdnmojtWXYqYnFqcNKsLzo:
					muhhLqIEAQndTJXVBjKigCeSPkO(ref dOLnoPZsOPZLOhaSQjVGIyoosZi.sgJBclOidlalkDqxriOHNdSqOPhq);
					break;
				case fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ.NwSaybWxcBFRoOrBCLiQaMrTUMs:
					LiYzpxhQKOnRhjyqFvumMAUCwet(ref dOLnoPZsOPZLOhaSQjVGIyoosZi.KTxfPEEzjCISazkoXgrDitVduqTu);
					break;
				case fIdCQKGsUXtETiYichZnMfYilrGQ.xlCDEQgsnTxbDFyQqXjJfkbhujLJ.mOkDJclCyMuDrUZUTTwEvEbaSEW:
					hqpsoSiHJyVxjnGnCAJYcopQadP(ref dOLnoPZsOPZLOhaSQjVGIyoosZi.KTxfPEEzjCISazkoXgrDitVduqTu);
					break;
				}
			}
		}

		private void TvRdNxauGxGvRFxdbNnlDiJmICjV(ref fIdCQKGsUXtETiYichZnMfYilrGQ.iLauQfozgjmNMoGgvLIIdrSDBEz P_0, double P_1)
		{
			if (JuswGXvahdcTCFokZmumGbXdbXtf)
			{
				RfjXkQKQWVdCsPSTtaSMcTQbdtV(P_0.KYjAoAzCuLLzNzLampqWkSygMiQ, RncNazFAMLQgcZOFyrDAFgCxXAC.fgSIqbILRPxyajGxXNQhuCfVtqPG, P_0.XeDYpikkwWPBYisYWIOjlTCqWYV, P_0.foSRcEqSuRsWnadDiKcGnhBewOU, P_1);
			}
		}

		private void HhoMXXxxnPSozpCXIRkMXPMsTtC(ref fIdCQKGsUXtETiYichZnMfYilrGQ.kvubzJAmBOFutZjejCfsQrfzQAP P_0, double P_1)
		{
			if (JuswGXvahdcTCFokZmumGbXdbXtf)
			{
				RfjXkQKQWVdCsPSTtaSMcTQbdtV(P_0.KYjAoAzCuLLzNzLampqWkSygMiQ, RncNazFAMLQgcZOFyrDAFgCxXAC.isHGkTqyOYSZKvhjDcVOXnrMZdI, P_0.nWxHcOrcxJQcxAiLNKPtKxBIgcJ, P_0.LKGKaxUOLwuJcOsjsDKYSwNaRYh, P_1);
			}
		}

		private void aLwUKMVMUJyTfIdyQCyrldVUnRw(ref fIdCQKGsUXtETiYichZnMfYilrGQ.ollceOhPFLQvZtNboLTbJvqirud P_0, double P_1)
		{
			if (JuswGXvahdcTCFokZmumGbXdbXtf)
			{
				RfjXkQKQWVdCsPSTtaSMcTQbdtV(P_0.KYjAoAzCuLLzNzLampqWkSygMiQ, RncNazFAMLQgcZOFyrDAFgCxXAC.XLKBiChkHTCugrTSZoFOPbEJOGrl, P_0.gpsFoTWsIpghHaRgviqWeITjcNgc, P_0.foSRcEqSuRsWnadDiKcGnhBewOU, P_1);
			}
		}

		private void mxHJkOIAYAwpfeKOCuCVjuXguVg(ref fIdCQKGsUXtETiYichZnMfYilrGQ.IfEOvGZwvTAOEwiScGJtCCxAKXp P_0, double P_1)
		{
			_ = JuswGXvahdcTCFokZmumGbXdbXtf;
		}

		private void klhajEIiOcUqkOkfSWXYTucPLsM(ref fIdCQKGsUXtETiYichZnMfYilrGQ.AwuALKGUqdVxaYtOQokyjfuAoXB P_0)
		{
			if (JuswGXvahdcTCFokZmumGbXdbXtf)
			{
				jXcIleFqupiPcaNOuNJYVoHIGet(P_0.KYjAoAzCuLLzNzLampqWkSygMiQ);
				if (MZzDMLKCKSSDOoDIHTxbEgXkaTPJ != null)
				{
					MZzDMLKCKSSDOoDIHTxbEgXkaTPJ();
				}
			}
		}

		private void muhhLqIEAQndTJXVBjKigCeSPkO(ref fIdCQKGsUXtETiYichZnMfYilrGQ.AwuALKGUqdVxaYtOQokyjfuAoXB P_0)
		{
			if (JuswGXvahdcTCFokZmumGbXdbXtf)
			{
				JWZmhyjAyCCSfFSFTwjTOGtVJIh(P_0.KYjAoAzCuLLzNzLampqWkSygMiQ);
				if (MZzDMLKCKSSDOoDIHTxbEgXkaTPJ != null)
				{
					MZzDMLKCKSSDOoDIHTxbEgXkaTPJ();
				}
			}
		}

		private void LEMnPeFcXRfxrCNDoMIuvtPCNjv(ref fIdCQKGsUXtETiYichZnMfYilrGQ.CqhNyCTmxXJUZijDYmXFYtvMoHw P_0, double P_1)
		{
			if (OPuozRtMQdvUoOWIwjDgdTyGIVa)
			{
				byte xeDYpikkwWPBYisYWIOjlTCqWYV = P_0.XeDYpikkwWPBYisYWIOjlTCqWYV;
				if (xeDYpikkwWPBYisYWIOjlTCqWYV != 6)
				{
					CwXqmJRzGybmMTqDGesXCZXbmZk(P_0.KYjAoAzCuLLzNzLampqWkSygMiQ, RncNazFAMLQgcZOFyrDAFgCxXAC.fgSIqbILRPxyajGxXNQhuCfVtqPG, P_0.XeDYpikkwWPBYisYWIOjlTCqWYV, P_0.foSRcEqSuRsWnadDiKcGnhBewOU, P_1);
				}
			}
		}

		private void qibLOjUMsbflxfjrXEGFcaPawbE(ref fIdCQKGsUXtETiYichZnMfYilrGQ.qupuqeyUtqAfrqhKOENDbwBKxNpc P_0, double P_1)
		{
			if (OPuozRtMQdvUoOWIwjDgdTyGIVa)
			{
				byte nWxHcOrcxJQcxAiLNKPtKxBIgcJ = P_0.nWxHcOrcxJQcxAiLNKPtKxBIgcJ;
				if (nWxHcOrcxJQcxAiLNKPtKxBIgcJ != 15)
				{
					CwXqmJRzGybmMTqDGesXCZXbmZk(P_0.KYjAoAzCuLLzNzLampqWkSygMiQ, RncNazFAMLQgcZOFyrDAFgCxXAC.isHGkTqyOYSZKvhjDcVOXnrMZdI, P_0.nWxHcOrcxJQcxAiLNKPtKxBIgcJ, P_0.LKGKaxUOLwuJcOsjsDKYSwNaRYh, P_1);
				}
			}
		}

		private void LiYzpxhQKOnRhjyqFvumMAUCwet(ref fIdCQKGsUXtETiYichZnMfYilrGQ.XuedTxamxjOgSnvOJLTvcBkkqLcK P_0)
		{
			if (OPuozRtMQdvUoOWIwjDgdTyGIVa)
			{
				hVsqoyUtMVRUeMmHGcqHAnlqVNq(P_0.KYjAoAzCuLLzNzLampqWkSygMiQ);
				if (MZzDMLKCKSSDOoDIHTxbEgXkaTPJ != null)
				{
					MZzDMLKCKSSDOoDIHTxbEgXkaTPJ();
				}
			}
		}

		private void hqpsoSiHJyVxjnGnCAJYcopQadP(ref fIdCQKGsUXtETiYichZnMfYilrGQ.XuedTxamxjOgSnvOJLTvcBkkqLcK P_0)
		{
			if (OPuozRtMQdvUoOWIwjDgdTyGIVa)
			{
				FwQBLSDUxaiHsiARfUMfkYIxdAp(P_0.KYjAoAzCuLLzNzLampqWkSygMiQ);
				if (MZzDMLKCKSSDOoDIHTxbEgXkaTPJ != null)
				{
					MZzDMLKCKSSDOoDIHTxbEgXkaTPJ();
				}
			}
		}

		private void CYSMTBTNAxqHOSmnbjRUsQHCbCUc(ref fIdCQKGsUXtETiYichZnMfYilrGQ.XuedTxamxjOgSnvOJLTvcBkkqLcK P_0)
		{
			_ = OPuozRtMQdvUoOWIwjDgdTyGIVa;
		}

		private void RfjXkQKQWVdCsPSTtaSMcTQbdtV(int P_0, RncNazFAMLQgcZOFyrDAFgCxXAC P_1, byte P_2, short P_3, double P_4)
		{
			ixLoAmVCoNHUAALFitaHqNgQpPNp(P_0)?.wAlHJoEseXwZfahDSIeyAibjNOI(P_1, P_2, P_3, P_4);
		}

		private void CwXqmJRzGybmMTqDGesXCZXbmZk(int P_0, RncNazFAMLQgcZOFyrDAFgCxXAC P_1, byte P_2, short P_3, double P_4)
		{
			cwcAjFhMYfLsvAxjajmIioidnmdZ(P_0)?.wAlHJoEseXwZfahDSIeyAibjNOI(P_1, P_2, P_3, P_4);
		}

		private void aYrGtaHQzGsHwKNNwWxrkBGHpSLe()
		{
			string[] array = fGSqjYeujslLHNCNsTsVFNSWfoS.SfyWNVmUEdWUoMnFwNXXruuvTVJ();
			if (array == null)
			{
				return;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (!string.IsNullOrEmpty(array[i]) && array[i].Length > 32 && !(fIdCQKGsUXtETiYichZnMfYilrGQ.lEvXyOfDJbhoWduwbaKmmsTRXAwl(new Guid(array[i].Substring(0, 32))) != string.Empty))
				{
					fIdCQKGsUXtETiYichZnMfYilrGQ.QXZALoUveKSHaiCRzBcaCtVUEPub(array[i]);
				}
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~SDL2InputSource()
		{
			Dispose(disposing: false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				return;
			}
			if (disposing)
			{
				if (UYWeDPRxCaaKyTVhyHfvImUUBWdP != null)
				{
					UYWeDPRxCaaKyTVhyHfvImUUBWdP.Dispose();
				}
				YqHeCRuFaULEaPEhDsJWIlAJPDR();
			}
			fIdCQKGsUXtETiYichZnMfYilrGQ.QDyGUyCfDOaogDDBaUWscGpUEAyi();
			vqjuhdYKKuBgDKqCJHOYrBTbbEX = false;
			RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
		}
	}
}
