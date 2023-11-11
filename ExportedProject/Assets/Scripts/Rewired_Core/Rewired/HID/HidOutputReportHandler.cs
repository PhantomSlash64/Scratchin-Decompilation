using System;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;

namespace Rewired.HID
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class HidOutputReportHandler : IDisposable
	{
		[CustomObfuscation(rename = false)]
		public delegate bool WriteReportDelegate(OutputReport report);

		private class dtaQrjOnUjUqLYDlmbfgVxUONfU : IDisposable
		{
			private bool gUhDUMEQpSGPpKzSkRDUuRUqUVw;

			private OutputReport AjoLUuhPmtnvehsELacHWwQPBEN;

			private NativeBuffer vsYfOtbYOjMAnAjcjAveBMNaFSiw;

			private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

			public bool oVdgfCqwOxBLFeYAvotlPUBhcDdd => gUhDUMEQpSGPpKzSkRDUuRUqUVw;

			public dtaQrjOnUjUqLYDlmbfgVxUONfU()
			{
				vsYfOtbYOjMAnAjcjAveBMNaFSiw = new NativeBuffer(0);
			}

			public void VqrAxVclnkzRRmSKDgAZeaUtfrhc(ref OutputReport P_0)
			{
				gUhDUMEQpSGPpKzSkRDUuRUqUVw = false;
				if (!P_0.IsValid)
				{
					return;
				}
				AjoLUuhPmtnvehsELacHWwQPBEN = P_0;
				if (vsYfOtbYOjMAnAjcjAveBMNaFSiw.Length >= P_0.bufferLength || vsYfOtbYOjMAnAjcjAveBMNaFSiw.Resize(P_0.bufferLength, preserveData: false))
				{
					try
					{
						vsYfOtbYOjMAnAjcjAveBMNaFSiw.Write(P_0.buffer, P_0.bufferLength, P_0.bufferLength);
					}
					catch
					{
						return;
					}
					AjoLUuhPmtnvehsELacHWwQPBEN.buffer = vsYfOtbYOjMAnAjcjAveBMNaFSiw.Pointer;
					AjoLUuhPmtnvehsELacHWwQPBEN.bufferLength = vsYfOtbYOjMAnAjcjAveBMNaFSiw.Length;
					gUhDUMEQpSGPpKzSkRDUuRUqUVw = true;
				}
			}

			public OutputReport MdstRbWEQWTznLboELxrDCkmJMF()
			{
				if (!gUhDUMEQpSGPpKzSkRDUuRUqUVw)
				{
					return default(OutputReport);
				}
				gUhDUMEQpSGPpKzSkRDUuRUqUVw = false;
				return AjoLUuhPmtnvehsELacHWwQPBEN;
			}

			public OutputReport PxwXYEOwZljUynuodTMVlMNhxgE()
			{
				if (!gUhDUMEQpSGPpKzSkRDUuRUqUVw)
				{
					return default(OutputReport);
				}
				return AjoLUuhPmtnvehsELacHWwQPBEN;
			}

			public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
			{
				AjoLUuhPmtnvehsELacHWwQPBEN.Clear();
				gUhDUMEQpSGPpKzSkRDUuRUqUVw = false;
			}

			public void Dispose()
			{
				vLCbxFvjSKbaoKsQRAbGNRMrnwI(true);
				GC.SuppressFinalize(this);
			}

			~dtaQrjOnUjUqLYDlmbfgVxUONfU()
			{
				vLCbxFvjSKbaoKsQRAbGNRMrnwI(false);
			}

			protected virtual void vLCbxFvjSKbaoKsQRAbGNRMrnwI(bool P_0)
			{
				if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
				{
					if (P_0 && vsYfOtbYOjMAnAjcjAveBMNaFSiw != null)
					{
						vsYfOtbYOjMAnAjcjAveBMNaFSiw.Dispose();
					}
					RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
				}
			}
		}

		private const bool FQRVzvXnnnuateAUYLeSVkqHGeq = false;

		private const int cwZlRQFFMVzbYmsBzdSwyjogQji = 100;

		private const int GGWZQIlBxGcvsfSNBrjjhLragtt = 10000;

		private ThreadHelper LzOmxoEMyXdHGDFTmboJhhMxKvwE;

		private dtaQrjOnUjUqLYDlmbfgVxUONfU vsYfOtbYOjMAnAjcjAveBMNaFSiw;

		private dtaQrjOnUjUqLYDlmbfgVxUONfU DZauVJwaxKauzlpiFIfPHCVfRYa;

		private bool dtKvbBomMBtVPJMfTXGUVEWnVdn;

		private bool vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		private readonly object vvbojbdubSGMdDsjibhoePvgclK;

		private WriteReportDelegate zgTJYpkXOFwvLFPfqehZVCplnmz;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public HidOutputReportHandler(WriteReportDelegate writeReportDelegate)
		{
			if (writeReportDelegate == null)
			{
				throw new ArgumentNullException("writeReportDelegate");
			}
			zgTJYpkXOFwvLFPfqehZVCplnmz = writeReportDelegate;
			vsYfOtbYOjMAnAjcjAveBMNaFSiw = new dtaQrjOnUjUqLYDlmbfgVxUONfU();
			DZauVJwaxKauzlpiFIfPHCVfRYa = new dtaQrjOnUjUqLYDlmbfgVxUONfU();
			vvbojbdubSGMdDsjibhoePvgclK = new object();
		}

		public void WriteReport(OutputReport report)
		{
			lock (vvbojbdubSGMdDsjibhoePvgclK)
			{
				if (RFSEgUYkCipDyWyLEnlGiNDUlzz || !report.IsValid || !dmyjjERgjQIVlakFlHoYvIKBXOi())
				{
					return;
				}
				lock (vsYfOtbYOjMAnAjcjAveBMNaFSiw)
				{
					vsYfOtbYOjMAnAjcjAveBMNaFSiw.VqrAxVclnkzRRmSKDgAZeaUtfrhc(ref report);
				}
			}
		}

		public void Clear()
		{
			if (vsYfOtbYOjMAnAjcjAveBMNaFSiw != null)
			{
				if (DZauVJwaxKauzlpiFIfPHCVfRYa != null)
				{
					lock (vsYfOtbYOjMAnAjcjAveBMNaFSiw)
					{
						lock (DZauVJwaxKauzlpiFIfPHCVfRYa)
						{
							vsYfOtbYOjMAnAjcjAveBMNaFSiw.LlCkzvOeJVaCziTDPktzBWuYotAZ();
							DZauVJwaxKauzlpiFIfPHCVfRYa.LlCkzvOeJVaCziTDPktzBWuYotAZ();
							return;
						}
					}
				}
				lock (vsYfOtbYOjMAnAjcjAveBMNaFSiw)
				{
					vsYfOtbYOjMAnAjcjAveBMNaFSiw.LlCkzvOeJVaCziTDPktzBWuYotAZ();
					return;
				}
			}
			if (DZauVJwaxKauzlpiFIfPHCVfRYa != null)
			{
				lock (DZauVJwaxKauzlpiFIfPHCVfRYa)
				{
					DZauVJwaxKauzlpiFIfPHCVfRYa.LlCkzvOeJVaCziTDPktzBWuYotAZ();
				}
			}
		}

		private bool dmyjjERgjQIVlakFlHoYvIKBXOi()
		{
			if (dtKvbBomMBtVPJMfTXGUVEWnVdn)
			{
				return false;
			}
			if (!vcEbiDGFdqSPNcGYdZknHnYExfTl())
			{
				return false;
			}
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				return true;
			}
			vqjuhdYKKuBgDKqCJHOYrBTbbEX = true;
			return true;
		}

		private bool vcEbiDGFdqSPNcGYdZknHnYExfTl()
		{
			if (dtKvbBomMBtVPJMfTXGUVEWnVdn)
			{
				return false;
			}
			if (LzOmxoEMyXdHGDFTmboJhhMxKvwE == null)
			{
				try
				{
					LzOmxoEMyXdHGDFTmboJhhMxKvwE = ThreadHelper.CreateFixedTimeStep(100, 10000);
					LzOmxoEMyXdHGDFTmboJhhMxKvwE.ThreadUpdateEvent += bQqgsAbWRjGlMsAyaNueMnaBOfCE;
					LzOmxoEMyXdHGDFTmboJhhMxKvwE.ThreadStartedEvent += wuUSIhqqJbrakQyRHWwUzEowMdM;
					LzOmxoEMyXdHGDFTmboJhhMxKvwE.ThreadPreStopEvent += osIzmyRzKxGBuzgEWQtsNVmvGMc;
					LzOmxoEMyXdHGDFTmboJhhMxKvwE.Start(wait: false);
					return true;
				}
				catch (Exception ex)
				{
					Logger.LogError("Exception occurred while creating thread!\n" + ex, requiredThreadSafety: true);
					if (LzOmxoEMyXdHGDFTmboJhhMxKvwE != null)
					{
						LzOmxoEMyXdHGDFTmboJhhMxKvwE.Stop(wait: false);
					}
					dtKvbBomMBtVPJMfTXGUVEWnVdn = true;
					return false;
				}
			}
			if (!LzOmxoEMyXdHGDFTmboJhhMxKvwE.isRunning)
			{
				LzOmxoEMyXdHGDFTmboJhhMxKvwE.Start(wait: false);
			}
			else
			{
				LzOmxoEMyXdHGDFTmboJhhMxKvwE.ResetTimeout();
			}
			return true;
		}

		private void QJbpRYwSPRxkrLTDOTNUIrAzhaW()
		{
			lock (vsYfOtbYOjMAnAjcjAveBMNaFSiw)
			{
				lock (DZauVJwaxKauzlpiFIfPHCVfRYa)
				{
					MiscTools.Swap(ref vsYfOtbYOjMAnAjcjAveBMNaFSiw, ref DZauVJwaxKauzlpiFIfPHCVfRYa);
				}
			}
		}

		private void wuUSIhqqJbrakQyRHWwUzEowMdM()
		{
		}

		private void osIzmyRzKxGBuzgEWQtsNVmvGMc()
		{
		}

		private void bQqgsAbWRjGlMsAyaNueMnaBOfCE()
		{
			QJbpRYwSPRxkrLTDOTNUIrAzhaW();
			lock (DZauVJwaxKauzlpiFIfPHCVfRYa)
			{
				if (!DZauVJwaxKauzlpiFIfPHCVfRYa.oVdgfCqwOxBLFeYAvotlPUBhcDdd)
				{
					return;
				}
				try
				{
					zgTJYpkXOFwvLFPfqehZVCplnmz(DZauVJwaxKauzlpiFIfPHCVfRYa.MdstRbWEQWTznLboELxrDCkmJMF());
				}
				catch (Exception ex)
				{
					Logger.LogError("An exception occurred while sending HID output report.\nMessage: " + ex.Message, requiredThreadSafety: true);
				}
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~HidOutputReportHandler()
		{
			Dispose(disposing: false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				return;
			}
			lock (vvbojbdubSGMdDsjibhoePvgclK)
			{
				if (disposing)
				{
					Clear();
					if (LzOmxoEMyXdHGDFTmboJhhMxKvwE != null)
					{
						LzOmxoEMyXdHGDFTmboJhhMxKvwE.Dispose();
					}
				}
				RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
			}
		}
	}
}
