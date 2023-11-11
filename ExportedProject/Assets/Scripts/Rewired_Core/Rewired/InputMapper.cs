using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Rewired.Utils;
using UnityEngine;

namespace Rewired
{
	public sealed class InputMapper
	{
		public class Context
		{
			private int ARWjGDZdsNDKyFWsMDftBeVIijxg = -1;

			private ControllerMap dvELFlNCXsbUbhaEdTEhAKKKUbc;

			private ActionElementMap OWonTUWxRMmrSYqgHLWRLmQaTZC;

			private AxisRange ogfCEdjFZuahZmhWncaRoyqSDaIb = AxisRange.Positive;

			private bool AcAYEzUyZtGgBEKRyDcTHFnyDoG;

			public int actionId
			{
				get
				{
					return ARWjGDZdsNDKyFWsMDftBeVIijxg;
				}
				set
				{
					if (!SGPkbaswKPGTxcFoOTNSFSDEDLQ())
					{
						ARWjGDZdsNDKyFWsMDftBeVIijxg = value;
					}
				}
			}

			public string actionName
			{
				get
				{
					InputAction action = ReInput.mapping.GetAction(ARWjGDZdsNDKyFWsMDftBeVIijxg);
					if (action == null)
					{
						return string.Empty;
					}
					return action.name;
				}
				set
				{
					if (!SGPkbaswKPGTxcFoOTNSFSDEDLQ())
					{
						InputAction action = ReInput.mapping.GetAction(value);
						if (action == null)
						{
							ARWjGDZdsNDKyFWsMDftBeVIijxg = -1;
							Logger.LogError("The Action \"" + value + "\" is not a valid Action and cannot be used!");
						}
						else
						{
							ARWjGDZdsNDKyFWsMDftBeVIijxg = action.id;
						}
					}
				}
			}

			public ControllerMap controllerMap
			{
				get
				{
					return dvELFlNCXsbUbhaEdTEhAKKKUbc;
				}
				set
				{
					if (!SGPkbaswKPGTxcFoOTNSFSDEDLQ())
					{
						dvELFlNCXsbUbhaEdTEhAKKKUbc = value;
					}
				}
			}

			public ActionElementMap actionElementMapToReplace
			{
				get
				{
					return OWonTUWxRMmrSYqgHLWRLmQaTZC;
				}
				set
				{
					if (!SGPkbaswKPGTxcFoOTNSFSDEDLQ())
					{
						OWonTUWxRMmrSYqgHLWRLmQaTZC = value;
					}
				}
			}

			public AxisRange actionRange
			{
				get
				{
					return ogfCEdjFZuahZmhWncaRoyqSDaIb;
				}
				set
				{
					if (!SGPkbaswKPGTxcFoOTNSFSDEDLQ())
					{
						ogfCEdjFZuahZmhWncaRoyqSDaIb = value;
					}
				}
			}

			public Context()
			{
			}

			private Context(Context source)
				: this()
			{
				if (source == null)
				{
					throw new ArgumentNullException("source");
				}
				Copy(source, this);
			}

			public Context Clone()
			{
				return new Context(this);
			}

			internal void BAkbIlkApXCSFxjWPbXTbTVBuRRf()
			{
				AcAYEzUyZtGgBEKRyDcTHFnyDoG = true;
			}

			private bool SGPkbaswKPGTxcFoOTNSFSDEDLQ()
			{
				if (AcAYEzUyZtGgBEKRyDcTHFnyDoG)
				{
					Logger.LogError("Context is read-only and cannot be modified after Input Mapper has been started.");
					return true;
				}
				return false;
			}

			public static void Copy(Context source, Context destination)
			{
				if (source == null)
				{
					throw new ArgumentNullException("source");
				}
				if (destination == null)
				{
					throw new ArgumentNullException("destination");
				}
				destination.ARWjGDZdsNDKyFWsMDftBeVIijxg = source.ARWjGDZdsNDKyFWsMDftBeVIijxg;
				destination.dvELFlNCXsbUbhaEdTEhAKKKUbc = source.dvELFlNCXsbUbhaEdTEhAKKKUbc;
				destination.OWonTUWxRMmrSYqgHLWRLmQaTZC = source.OWonTUWxRMmrSYqgHLWRLmQaTZC;
				destination.ogfCEdjFZuahZmhWncaRoyqSDaIb = source.ogfCEdjFZuahZmhWncaRoyqSDaIb;
			}
		}

		public enum ConflictResponse
		{
			Cancel = 0,
			Replace = 1,
			Add = 2,
			Ignore = 3
		}

		public abstract class EventData
		{
			public readonly InputMapper inputMapper;

			internal EventData(InputMapper inputMapper)
			{
				this.inputMapper = inputMapper;
			}
		}

		public class InputMappedEventData : EventData
		{
			public readonly ActionElementMap actionElementMap;

			internal InputMappedEventData(InputMapper mapper, ActionElementMap actionElementMap)
				: base(mapper)
			{
				this.actionElementMap = actionElementMap;
			}
		}

		public class CanceledEventData : EventData
		{
			public readonly string message;

			internal CanceledEventData(InputMapper mapper, string message)
				: base(mapper)
			{
				this.message = message;
			}
		}

		public class ErrorEventData : EventData
		{
			public readonly string message;

			internal ErrorEventData(InputMapper mapper, string message)
				: base(mapper)
			{
				this.message = message;
			}
		}

		public class TimedOutEventData : EventData
		{
			internal TimedOutEventData(InputMapper mapper)
				: base(mapper)
			{
			}
		}

		public class StartedEventData : EventData
		{
			internal StartedEventData(InputMapper mapper)
				: base(mapper)
			{
			}
		}

		public class StoppedEventData : EventData
		{
			internal StoppedEventData(InputMapper mapper)
				: base(mapper)
			{
			}
		}

		public class ConflictFoundEventData : EventData
		{
			public readonly Action<ConflictResponse> responseCallback;

			public readonly ElementAssignmentInfo assignment;

			public readonly IList<ElementAssignmentConflictInfo> conflicts;

			public readonly bool isProtected;

			internal ConflictFoundEventData(InputMapper mapper, Action<ConflictResponse> responseCallback, ElementAssignmentInfo assignment, IList<ElementAssignmentConflictInfo> conflicts, bool isProtected)
				: base(mapper)
			{
				this.responseCallback = responseCallback;
				this.assignment = assignment;
				this.conflicts = conflicts;
				this.isProtected = isProtected;
			}
		}

		private enum ulaqcjhcskYwsStRFvlFrhabjpDb
		{
			gZjmiDufLkNJNMJoeAxlAqbQgXG = 0,
			thaJMcxCEfniPKfeXdMNDPzzNjYh = 1,
			CRfAsWlXRnTwobpjwaGhfHioZAc = 2,
			vfqfiJDUPEnxUOgPvHjPenQDivhL = 3,
			gVGLonSGYmjRsWheRUXHJADZgbt = 4,
			ilDqTmxeYoSwjPvYNRcKTJerlvH = 5,
			lIIqWAKoUkJHmWlxeFUdmeyXqQ = 6
		}

		public enum Status
		{
			Idle = 0,
			Listening = 1,
			AwaitingResponse = 2
		}

		private class PCokDknkRwDEdhJUOmafgYFqzLy
		{
			private enum hbBgNLYBTyXLHOEiQbxGFIKpJhn
			{
				JcTFwVfcIjNKdqhMQMcLAQSZWVoK = 0,
				JyotIIfJnFQzTUQVceUEZcqEQjd = 1
			}

			private enum eOlQYDiFBqdcmJhWTNvLBJPqTwB
			{
				fUyeeVFhkdEderlnmYYFoAwmZEL = 0,
				XsaYexCkpsenghfNvZoxUDTBRJU = 1
			}

			private class XpXLgXhJhYpLzVpuYDRlPRowsZx
			{
				private Player OcKThfvEDnebuGNQDMZlmlOZdOGb;

				private int ARWjGDZdsNDKyFWsMDftBeVIijxg;

				private Context LqHDanKgFigfXggLFYyleakATfb;

				private ControllerType DdmGAhnWjBkGezCJigEsEoriSFLq;

				private int BUaVcuFwTcIVxSAyrnOfAxOjuhI;

				private ControllerPollingInfo PpTPBkfPoXwQtWFcbwhvnYoFxOV;

				private ModifierKeyFlags aBfAFwkVtDFVqNZcNtZjCBdzQNF;

				public Player QFlXjfmiJabcsMblLziegHSMCLfJ => OcKThfvEDnebuGNQDMZlmlOZdOGb;

				public int cJTdHcaeBzqfrLPRWYuoPWTszLhk => ARWjGDZdsNDKyFWsMDftBeVIijxg;

				public Context kpBWwwMTmADbFDnoDjprQLxyZrr => LqHDanKgFigfXggLFYyleakATfb;

				public ControllerType kEHmRBonufPaXwWSSWlSciOdvWy => DdmGAhnWjBkGezCJigEsEoriSFLq;

				public int amFGhwgAUYKGvLkGtwdHnkUiNNi => BUaVcuFwTcIVxSAyrnOfAxOjuhI;

				public ControllerPollingInfo rdlFzQeQGjQTXOehpuOAMPFLnywy => PpTPBkfPoXwQtWFcbwhvnYoFxOV;

				public ModifierKeyFlags jePFGqZlKTAaGfjXPfbDlsoTZCPT => aBfAFwkVtDFVqNZcNtZjCBdzQNF;

				public AxisRange wFPCDDgKIQjzisCkdxAihnjtLSVb
				{
					get
					{
						AxisRange result = AxisRange.Positive;
						if (rdlFzQeQGjQTXOehpuOAMPFLnywy.elementType == ControllerElementType.Axis)
						{
							result = ((LqHDanKgFigfXggLFYyleakATfb.actionRange != 0) ? ((rdlFzQeQGjQTXOehpuOAMPFLnywy.axisPole == Pole.Positive) ? AxisRange.Positive : AxisRange.Negative) : AxisRange.Full);
						}
						return result;
					}
				}

				public string qyeKNIFpXDDGeetGatpaxEgfAHl
				{
					get
					{
						if (kEHmRBonufPaXwWSSWlSciOdvWy == ControllerType.Keyboard && jePFGqZlKTAaGfjXPfbDlsoTZCPT != 0)
						{
							return $"{Keyboard.ModifierKeyFlagsToString(jePFGqZlKTAaGfjXPfbDlsoTZCPT)} + {rdlFzQeQGjQTXOehpuOAMPFLnywy.elementIdentifierName}";
						}
						string text = rdlFzQeQGjQTXOehpuOAMPFLnywy.elementIdentifierName;
						if (rdlFzQeQGjQTXOehpuOAMPFLnywy.elementType == ControllerElementType.Axis)
						{
							if (wFPCDDgKIQjzisCkdxAihnjtLSVb == AxisRange.Positive)
							{
								text += " +";
							}
							else if (wFPCDDgKIQjzisCkdxAihnjtLSVb == AxisRange.Negative)
							{
								text += " -";
							}
						}
						return text;
					}
				}

				public void ijQPrfbohIDtyfCSvLMVhrlmSpB(Player P_0, Context P_1)
				{
					if (P_1.controllerMap == null)
					{
						throw new ArgumentNullException("controllerMap");
					}
					LlCkzvOeJVaCziTDPktzBWuYotAZ();
					OcKThfvEDnebuGNQDMZlmlOZdOGb = P_0;
					ARWjGDZdsNDKyFWsMDftBeVIijxg = P_1.actionId;
					DdmGAhnWjBkGezCJigEsEoriSFLq = P_1.controllerMap.controllerType;
					BUaVcuFwTcIVxSAyrnOfAxOjuhI = P_1.controllerMap.controllerId;
					LqHDanKgFigfXggLFYyleakATfb = P_1;
					DdmGAhnWjBkGezCJigEsEoriSFLq = P_1.controllerMap.controllerType;
					BUaVcuFwTcIVxSAyrnOfAxOjuhI = P_1.controllerMap.controllerId;
					P_1.BAkbIlkApXCSFxjWPbXTbTVBuRRf();
				}

				public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
				{
					OcKThfvEDnebuGNQDMZlmlOZdOGb = null;
					ARWjGDZdsNDKyFWsMDftBeVIijxg = -1;
					LqHDanKgFigfXggLFYyleakATfb = null;
					DdmGAhnWjBkGezCJigEsEoriSFLq = ControllerType.Keyboard;
					BUaVcuFwTcIVxSAyrnOfAxOjuhI = -1;
					PpTPBkfPoXwQtWFcbwhvnYoFxOV = default(ControllerPollingInfo);
					aBfAFwkVtDFVqNZcNtZjCBdzQNF = ModifierKeyFlags.None;
				}

				public ElementAssignment nNkgezsXGNesXdexwxQPfpumNEQ(ControllerPollingInfo P_0)
				{
					PpTPBkfPoXwQtWFcbwhvnYoFxOV = P_0;
					return nNkgezsXGNesXdexwxQPfpumNEQ();
				}

				public ElementAssignment nNkgezsXGNesXdexwxQPfpumNEQ(ControllerPollingInfo P_0, ModifierKeyFlags P_1)
				{
					PpTPBkfPoXwQtWFcbwhvnYoFxOV = P_0;
					aBfAFwkVtDFVqNZcNtZjCBdzQNF = P_1;
					return nNkgezsXGNesXdexwxQPfpumNEQ();
				}

				public ElementAssignment nNkgezsXGNesXdexwxQPfpumNEQ()
				{
					return new ElementAssignment(kEHmRBonufPaXwWSSWlSciOdvWy, PpTPBkfPoXwQtWFcbwhvnYoFxOV.elementType, PpTPBkfPoXwQtWFcbwhvnYoFxOV.elementIdentifierId, wFPCDDgKIQjzisCkdxAihnjtLSVb, PpTPBkfPoXwQtWFcbwhvnYoFxOV.keyboardKey, aBfAFwkVtDFVqNZcNtZjCBdzQNF, ARWjGDZdsNDKyFWsMDftBeVIijxg, (LqHDanKgFigfXggLFYyleakATfb.actionRange == AxisRange.Negative) ? Pole.Negative : Pole.Positive, invert: false, (LqHDanKgFigfXggLFYyleakATfb.actionElementMapToReplace != null) ? LqHDanKgFigfXggLFYyleakATfb.actionElementMapToReplace.id : (-1));
				}
			}

			private readonly InputMapper nJGvFkewuzWileOgdgvLxwmBPEU;

			private readonly Options oLwgOlxACYgaeDWHUfDxZufHRffI = new Options();

			private readonly XpXLgXhJhYpLzVpuYDRlPRowsZx MJlMoAhNQJtAJvqaDCSKrkpAarQ = new XpXLgXhJhYpLzVpuYDRlPRowsZx();

			private readonly Dictionary<ulaqcjhcskYwsStRFvlFrhabjpDb, SafeDelegate> ZAsQmVlcIzbjFBWgMJhiuyaKMjMO;

			private readonly Dictionary<string, SafeDelegate> VjNYMupbvVZvEMsuvMAZkYUmnlB;

			private Status MieBNWNoNbgNHwJKkxUXQhMGXXS;

			private eOlQYDiFBqdcmJhWTNvLBJPqTwB xAODFzDaUdNomacCztokSgPOofHQ;

			private double DfiJduYcmfxbZUygkFhhmwBiUVv;

			private bool pSrYGzosKYNwVfbqsbjnUxnkXJh;

			private List<Player> lBxLgeDHJbHpYsLJYUDSBecmOU = new List<Player>();

			private readonly List<ControllerPollingInfo> OcKaPayMUuyHNUCKKxOZkRGtSyv = new List<ControllerPollingInfo>();

			private ElementAssignment rhPeENbpBiXZmgnwHIzNEnbdwPd;

			public Status fhsLQNRdTxTZFGbrMWUBoBnbhdX => MieBNWNoNbgNHwJKkxUXQhMGXXS;

			public float yEYHzGsrNcnIQxPFJMKjDzBHDsH
			{
				get
				{
					if (MieBNWNoNbgNHwJKkxUXQhMGXXS == Status.Idle)
					{
						return 0f;
					}
					if (oLwgOlxACYgaeDWHUfDxZufHRffI.timeout <= 0f)
					{
						return 0f;
					}
					return (float)MathTools.Max(0.0, DfiJduYcmfxbZUygkFhhmwBiUVv + (double)oLwgOlxACYgaeDWHUfDxZufHRffI.timeout - ReInput.unscaledTime);
				}
			}

			public Context tMrPuKcwDNOJSFbnlMHMeHHlAdH
			{
				get
				{
					if (MieBNWNoNbgNHwJKkxUXQhMGXXS == Status.Idle)
					{
						return null;
					}
					return MJlMoAhNQJtAJvqaDCSKrkpAarQ.kpBWwwMTmADbFDnoDjprQLxyZrr;
				}
			}

			private bool knSPjpjjDryyMJekUphwuGCpHfO
			{
				get
				{
					if (pSrYGzosKYNwVfbqsbjnUxnkXJh)
					{
						return false;
					}
					if (!(oLwgOlxACYgaeDWHUfDxZufHRffI.timeout > 0f))
					{
						return false;
					}
					return true;
				}
			}

			public PCokDknkRwDEdhJUOmafgYFqzLy(InputMapper parent, Dictionary<ulaqcjhcskYwsStRFvlFrhabjpDb, SafeDelegate> events)
			{
				if (parent == null)
				{
					throw new ArgumentNullException("parent");
				}
				if (events == null)
				{
					throw new ArgumentNullException("events");
				}
				nJGvFkewuzWileOgdgvLxwmBPEU = parent;
				ZAsQmVlcIzbjFBWgMJhiuyaKMjMO = events;
				uileOmkJVJtYTHLCMEDfKtvVrfX();
			}

			~PCokDknkRwDEdhJUOmafgYFqzLy()
			{
				QnfgPHErnCiIycxlKvVvClsuTbXC();
			}

			public void tvCBgIPnqjaOIPTXBTydmcrRbzF(Context P_0, Options P_1)
			{
				if (MieBNWNoNbgNHwJKkxUXQhMGXXS != 0)
				{
					pKpmtzietPCvggwGlbHfbeQjEiAn("User started a new listening session.");
				}
				if (P_0 == null)
				{
					throw new ArgumentNullException("context");
				}
				if (P_0.controllerMap == null)
				{
					throw new ArgumentNullException("controllerMap");
				}
				if (P_1 == null)
				{
					throw new ArgumentNullException("options");
				}
				P_0 = P_0.Clone();
				Options.Copy(P_1, oLwgOlxACYgaeDWHUfDxZufHRffI);
				Player player = ReInput.players.GetPlayer(P_0.controllerMap.playerId);
				if (ReInput.mapping.GetAction(P_0.actionId) == null)
				{
					jAHtoKAAqvswkRedBFEKIPuPLFC("No Action found for actionId: " + P_0.actionId);
					return;
				}
				MJlMoAhNQJtAJvqaDCSKrkpAarQ.ijQPrfbohIDtyfCSvLMVhrlmSpB(player, P_0);
				MieBNWNoNbgNHwJKkxUXQhMGXXS = Status.Listening;
				rEXSYhPYtgAafqTqpTfOrAQRVAQ();
				WVjPuioySqaASvjkwmMpVvQVsDx();
				ouvkYNjeDofKrQCzuyaYNxgxFZS();
				tpgDOvPdjMefVRCwtnFZsFUPLYg();
			}

			public void tzaKPylTwphkLfYXQXavMgZqPVf(string P_0)
			{
				if (MieBNWNoNbgNHwJKkxUXQhMGXXS != 0)
				{
					pKpmtzietPCvggwGlbHfbeQjEiAn(P_0);
				}
			}

			private void mtiNfGzpXHszOwiOIAVYQuMZclV(UpdateLoopType P_0)
			{
				if (P_0 != 0 || MieBNWNoNbgNHwJKkxUXQhMGXXS != Status.Listening)
				{
					return;
				}
				if (knSPjpjjDryyMJekUphwuGCpHfO && yEYHzGsrNcnIQxPFJMKjDzBHDsH <= 0f)
				{
					CwVNMmvUmLRvtIXpPIFbGSXUaAei();
					return;
				}
				Controller controller = ReInput.controllers.GetController(MJlMoAhNQJtAJvqaDCSKrkpAarQ.kEHmRBonufPaXwWSSWlSciOdvWy, MJlMoAhNQJtAJvqaDCSKrkpAarQ.amFGhwgAUYKGvLkGtwdHnkUiNNi);
				ElementAssignment elementAssignment;
				if (controller == null)
				{
					jAHtoKAAqvswkRedBFEKIPuPLFC(string.Concat("Controller not found for type: ", MJlMoAhNQJtAJvqaDCSKrkpAarQ.kEHmRBonufPaXwWSSWlSciOdvWy, " id: ", MJlMoAhNQJtAJvqaDCSKrkpAarQ.amFGhwgAUYKGvLkGtwdHnkUiNNi));
				}
				else if (PjDZhWmUwwrAGunMEXHVntlYnsP(out elementAssignment) != 0 && YBbyJHrrUrKEiiSrzSCXsUuhhZg(elementAssignment) != 0)
				{
					fjkcJbffZQCJbGNJfxHZuWncWqMa(elementAssignment);
				}
			}

			private void yIdByDKOOIBtDKUNHTJwNjHwPBV()
			{
				if (MieBNWNoNbgNHwJKkxUXQhMGXXS != 0)
				{
					uileOmkJVJtYTHLCMEDfKtvVrfX();
					QnfgPHErnCiIycxlKvVvClsuTbXC();
					yAerCcoRuuRtJhAaNfqYHfflfJr();
				}
			}

			private void uileOmkJVJtYTHLCMEDfKtvVrfX()
			{
				MieBNWNoNbgNHwJKkxUXQhMGXXS = Status.Idle;
				DfiJduYcmfxbZUygkFhhmwBiUVv = 0.0;
				oLwgOlxACYgaeDWHUfDxZufHRffI.LlCkzvOeJVaCziTDPktzBWuYotAZ();
				MJlMoAhNQJtAJvqaDCSKrkpAarQ.LlCkzvOeJVaCziTDPktzBWuYotAZ();
				rhPeENbpBiXZmgnwHIzNEnbdwPd = default(ElementAssignment);
				xAODFzDaUdNomacCztokSgPOofHQ = eOlQYDiFBqdcmJhWTNvLBJPqTwB.fUyeeVFhkdEderlnmYYFoAwmZEL;
				pSrYGzosKYNwVfbqsbjnUxnkXJh = false;
				lBxLgeDHJbHpYsLJYUDSBecmOU.Clear();
			}

			private hbBgNLYBTyXLHOEiQbxGFIKpJhn PjDZhWmUwwrAGunMEXHVntlYnsP(out ElementAssignment P_0)
			{
				if (!JVFUyRyhcrACHMbDhkYGCkdIGEe(out var enumerable, out var modifierKeyFlags))
				{
					P_0 = default(ElementAssignment);
					return hbBgNLYBTyXLHOEiQbxGFIKpJhn.JcTFwVfcIjNKdqhMQMcLAQSZWVoK;
				}
				ControllerPollingInfo controllerPollingInfo = default(ControllerPollingInfo);
				foreach (ControllerPollingInfo item in enumerable)
				{
					if (item.success && !veJFdBtqRDFTfJHxdtbnLbPiTzO(item, oLwgOlxACYgaeDWHUfDxZufHRffI))
					{
						controllerPollingInfo = item;
						break;
					}
				}
				if (!controllerPollingInfo.success)
				{
					P_0 = default(ElementAssignment);
					return hbBgNLYBTyXLHOEiQbxGFIKpJhn.JcTFwVfcIjNKdqhMQMcLAQSZWVoK;
				}
				if (!kRKkLNkRyxcdkYNsDDtfpValuOb(MJlMoAhNQJtAJvqaDCSKrkpAarQ, controllerPollingInfo, oLwgOlxACYgaeDWHUfDxZufHRffI))
				{
					P_0 = default(ElementAssignment);
					return hbBgNLYBTyXLHOEiQbxGFIKpJhn.JcTFwVfcIjNKdqhMQMcLAQSZWVoK;
				}
				P_0 = MJlMoAhNQJtAJvqaDCSKrkpAarQ.nNkgezsXGNesXdexwxQPfpumNEQ(controllerPollingInfo);
				P_0.modifierKeyFlags = modifierKeyFlags;
				return hbBgNLYBTyXLHOEiQbxGFIKpJhn.JyotIIfJnFQzTUQVceUEZcqEQjd;
			}

			private bool JVFUyRyhcrACHMbDhkYGCkdIGEe(out IEnumerable<ControllerPollingInfo> P_0, out ModifierKeyFlags P_1)
			{
				P_1 = ModifierKeyFlags.None;
				ControllerType controllerType = MJlMoAhNQJtAJvqaDCSKrkpAarQ.kEHmRBonufPaXwWSSWlSciOdvWy;
				int controllerId = MJlMoAhNQJtAJvqaDCSKrkpAarQ.amFGhwgAUYKGvLkGtwdHnkUiNNi;
				if (controllerType == ControllerType.Keyboard)
				{
					P_0 = SdySndZRBOxbtjWtGtTTLjVtdfyf(out P_1);
					return true;
				}
				if (oLwgOlxACYgaeDWHUfDxZufHRffI.allowAxes)
				{
					if (oLwgOlxACYgaeDWHUfDxZufHRffI.allowButtons)
					{
						if (MJlMoAhNQJtAJvqaDCSKrkpAarQ.QFlXjfmiJabcsMblLziegHSMCLfJ != null)
						{
							P_0 = MJlMoAhNQJtAJvqaDCSKrkpAarQ.QFlXjfmiJabcsMblLziegHSMCLfJ.controllers.polling.PollControllerForAllElementsDown(controllerType, controllerId);
						}
						else
						{
							P_0 = ReInput.controllers.polling.PollControllerForAllElementsDown(MJlMoAhNQJtAJvqaDCSKrkpAarQ.kEHmRBonufPaXwWSSWlSciOdvWy, MJlMoAhNQJtAJvqaDCSKrkpAarQ.amFGhwgAUYKGvLkGtwdHnkUiNNi);
						}
					}
					else if (MJlMoAhNQJtAJvqaDCSKrkpAarQ.QFlXjfmiJabcsMblLziegHSMCLfJ != null)
					{
						P_0 = MJlMoAhNQJtAJvqaDCSKrkpAarQ.QFlXjfmiJabcsMblLziegHSMCLfJ.controllers.polling.PollControllerForAllAxes(controllerType, controllerId);
					}
					else
					{
						P_0 = ReInput.controllers.polling.PollControllerForAllAxes(controllerType, controllerId);
					}
				}
				else
				{
					if (!oLwgOlxACYgaeDWHUfDxZufHRffI.allowButtons)
					{
						jAHtoKAAqvswkRedBFEKIPuPLFC("You must enable listening for at least one element type.");
						P_0 = null;
						return false;
					}
					if (MJlMoAhNQJtAJvqaDCSKrkpAarQ.QFlXjfmiJabcsMblLziegHSMCLfJ != null)
					{
						P_0 = MJlMoAhNQJtAJvqaDCSKrkpAarQ.QFlXjfmiJabcsMblLziegHSMCLfJ.controllers.polling.PollControllerForAllButtonsDown(controllerType, controllerId);
					}
					else
					{
						P_0 = ReInput.controllers.polling.PollControllerForAllButtonsDown(controllerType, controllerId);
					}
				}
				return true;
			}

			private IEnumerable<ControllerPollingInfo> SdySndZRBOxbtjWtGtTTLjVtdfyf(out ModifierKeyFlags P_0)
			{
				P_0 = ModifierKeyFlags.None;
				OcKaPayMUuyHNUCKKxOZkRGtSyv.Clear();
				if (!oLwgOlxACYgaeDWHUfDxZufHRffI.allowButtons)
				{
					return OcKaPayMUuyHNUCKKxOZkRGtSyv;
				}
				OcKaPayMUuyHNUCKKxOZkRGtSyv.Add(sNKDQtjLpZynIShsIJqnHomgMLGv(oLwgOlxACYgaeDWHUfDxZufHRffI, out P_0));
				return OcKaPayMUuyHNUCKKxOZkRGtSyv;
			}

			private ControllerPollingInfo sNKDQtjLpZynIShsIJqnHomgMLGv(Options P_0, out ModifierKeyFlags P_1)
			{
				bool flag;
				string text;
				ControllerPollingInfo result = sNKDQtjLpZynIShsIJqnHomgMLGv(P_0, out flag, out P_1, out text);
				if (flag)
				{
					rEXSYhPYtgAafqTqpTfOrAQRVAQ();
				}
				return result;
			}

			private static ControllerPollingInfo sNKDQtjLpZynIShsIJqnHomgMLGv(Options P_0, out bool P_1, out ModifierKeyFlags P_2, out string P_3)
			{
				P_3 = string.Empty;
				P_1 = false;
				P_2 = ModifierKeyFlags.None;
				int num = 0;
				ControllerPollingInfo result = default(ControllerPollingInfo);
				ControllerPollingInfo result2 = default(ControllerPollingInfo);
				ModifierKeyFlags modifierKeyFlags = ModifierKeyFlags.None;
				foreach (ControllerPollingInfo item in ReInput.controllers.Keyboard.PollForAllKeys())
				{
					KeyCode keyboardKey = item.keyboardKey;
					if (keyboardKey == KeyCode.AltGr)
					{
						continue;
					}
					if (Keyboard.IsModifierKey(item.keyboardKey))
					{
						if (num == 0)
						{
							result2 = item;
						}
						modifierKeyFlags |= Keyboard.KeyCodeToModifierKeyFlags(keyboardKey);
						num++;
					}
					else if (result.keyboardKey == KeyCode.None)
					{
						result = item;
					}
				}
				if (result.keyboardKey != 0)
				{
					if (!ReInput.controllers.Keyboard.GetKeyDown(result.keyboardKey))
					{
						return default(ControllerPollingInfo);
					}
					if (num == 0 || !P_0.allowKeyboardKeysWithModifiers)
					{
						return result;
					}
					P_2 = modifierKeyFlags;
					return result;
				}
				if (num > 0)
				{
					P_1 = true;
					if (num == 1)
					{
						if (P_0.allowKeyboardModifierKeyAsPrimary)
						{
							if (!P_0.allowKeyboardKeysWithModifiers || P_0.holdDurationToMapKeyboardModifierKeyAsPrimary <= 0f)
							{
								if (!ReInput.controllers.Keyboard.GetKeyDown(result2.keyboardKey))
								{
									return default(ControllerPollingInfo);
								}
								return result2;
							}
							if (ReInput.controllers.Keyboard.GetKeyTimePressed(result2.keyboardKey) >= (double)P_0.holdDurationToMapKeyboardModifierKeyAsPrimary)
							{
								return result2;
							}
						}
						P_3 = Keyboard.GetKeyName(result2.keyboardKey);
					}
					else
					{
						P_3 = Keyboard.ModifierKeyFlagsToString(modifierKeyFlags);
					}
				}
				return default(ControllerPollingInfo);
			}

			private static bool veJFdBtqRDFTfJHxdtbnLbPiTzO(ControllerPollingInfo P_0, Options P_1)
			{
				if (!P_1.allowAxes && P_0.elementType == ControllerElementType.Axis)
				{
					return false;
				}
				if (!P_1.allowButtons && P_0.elementType == ControllerElementType.Button)
				{
					return false;
				}
				if (P_0.controllerType == ControllerType.Mouse && P_0.elementType == ControllerElementType.Axis)
				{
					switch (P_0.elementIndex)
					{
					case 0:
						if (P_1.ignoreMouseXAxis)
						{
							return true;
						}
						break;
					case 1:
						if (P_1.ignoreMouseYAxis)
						{
							return true;
						}
						break;
					}
				}
				SafePredicate<ControllerPollingInfo> safePredicate = P_1.ZwNeZFaryfiDvMSNibGSOXmhZUs<SafePredicate<ControllerPollingInfo>>("isElementAllowed");
				if (safePredicate != null)
				{
					return !safePredicate.Invoke(P_0);
				}
				return false;
			}

			private static bool kRKkLNkRyxcdkYNsDDtfpValuOb(XpXLgXhJhYpLzVpuYDRlPRowsZx P_0, ControllerPollingInfo P_1, Options P_2)
			{
				if (P_0 == null)
				{
					return false;
				}
				if (P_2 == null)
				{
					return true;
				}
				if (P_0.wFPCDDgKIQjzisCkdxAihnjtLSVb == AxisRange.Full && !P_2.allowButtonsOnFullAxisAssignment && P_1.elementType == ControllerElementType.Button)
				{
					return false;
				}
				return true;
			}

			private void WVjPuioySqaASvjkwmMpVvQVsDx()
			{
				if (!oLwgOlxACYgaeDWHUfDxZufHRffI.checkForConflicts)
				{
					return;
				}
				if (oLwgOlxACYgaeDWHUfDxZufHRffI.checkForConflictsWithSelf && MJlMoAhNQJtAJvqaDCSKrkpAarQ.QFlXjfmiJabcsMblLziegHSMCLfJ != null)
				{
					ListTools.AddIfUnique(lBxLgeDHJbHpYsLJYUDSBecmOU, MJlMoAhNQJtAJvqaDCSKrkpAarQ.QFlXjfmiJabcsMblLziegHSMCLfJ);
				}
				if (oLwgOlxACYgaeDWHUfDxZufHRffI.checkForConflictsWithSystemPlayer)
				{
					ListTools.AddIfUnique(lBxLgeDHJbHpYsLJYUDSBecmOU, ReInput.players.SystemPlayer);
				}
				if (oLwgOlxACYgaeDWHUfDxZufHRffI.checkForConflictsWithAllPlayers)
				{
					IList<Player> players = ReInput.players.Players;
					for (int i = 0; i < players.Count; i++)
					{
						ListTools.AddIfUnique(lBxLgeDHJbHpYsLJYUDSBecmOU, players[i]);
					}
				}
				else
				{
					if (oLwgOlxACYgaeDWHUfDxZufHRffI.checkForConflictsWithPlayerIds == null)
					{
						return;
					}
					IList<Player> allPlayers = ReInput.players.AllPlayers;
					int count = allPlayers.Count;
					for (int j = 0; j < count; j++)
					{
						if (ArrayTools.Contains(oLwgOlxACYgaeDWHUfDxZufHRffI.checkForConflictsWithPlayerIds, allPlayers[j].id))
						{
							ListTools.AddIfUnique(lBxLgeDHJbHpYsLJYUDSBecmOU, allPlayers[j]);
						}
					}
				}
			}

			private hbBgNLYBTyXLHOEiQbxGFIKpJhn YBbyJHrrUrKEiiSrzSCXsUuhhZg(ElementAssignment P_0)
			{
				if (oLwgOlxACYgaeDWHUfDxZufHRffI.checkForConflicts && MJlMoAhNQJtAJvqaDCSKrkpAarQ.QFlXjfmiJabcsMblLziegHSMCLfJ != null && grlmwobCjVkfqDLXuZCdYyQMAnY(MJlMoAhNQJtAJvqaDCSKrkpAarQ, P_0, lBxLgeDHJbHpYsLJYUDSBecmOU))
				{
					return QAnpFJjQxxEBeHPntpXPsVCZReY(P_0);
				}
				return hbBgNLYBTyXLHOEiQbxGFIKpJhn.JyotIIfJnFQzTUQVceUEZcqEQjd;
			}

			private static bool grlmwobCjVkfqDLXuZCdYyQMAnY(XpXLgXhJhYpLzVpuYDRlPRowsZx P_0, ElementAssignment P_1, List<Player> P_2)
			{
				if (P_0 == null || P_0.QFlXjfmiJabcsMblLziegHSMCLfJ == null)
				{
					return false;
				}
				if (P_2 == null || P_2.Count == 0)
				{
					return false;
				}
				if (!UXiquCmtDOeaQwAQyOjUeoIArhb(P_0, P_1, out var conflictCheck))
				{
					return false;
				}
				for (int i = 0; i < P_2.Count; i++)
				{
					if (P_2[i].controllers.conflictChecking.DoesElementAssignmentConflict(conflictCheck))
					{
						return true;
					}
				}
				return false;
			}

			private static bool KMpBKWHnpoqTDRKcNvSGueReFPmG(XpXLgXhJhYpLzVpuYDRlPRowsZx P_0, ElementAssignment P_1, List<Player> P_2)
			{
				if (P_0 == null || P_0.QFlXjfmiJabcsMblLziegHSMCLfJ == null)
				{
					return false;
				}
				if (P_2 == null || P_2.Count == 0)
				{
					return false;
				}
				if (!UXiquCmtDOeaQwAQyOjUeoIArhb(P_0, P_1, out var conflictCheck))
				{
					return false;
				}
				for (int i = 0; i < P_2.Count; i++)
				{
					foreach (ElementAssignmentConflictInfo item in P_2[i].controllers.conflictChecking.ElementAssignmentConflicts(conflictCheck))
					{
						if (!item.isUserAssignable)
						{
							return true;
						}
					}
				}
				return false;
			}

			private static IList<ElementAssignmentConflictInfo> xbdHWhjFNBZveKqGGUgyNiGGDHQ(XpXLgXhJhYpLzVpuYDRlPRowsZx P_0, ElementAssignment P_1, List<Player> P_2)
			{
				if (P_0 == null || P_0.QFlXjfmiJabcsMblLziegHSMCLfJ == null)
				{
					return null;
				}
				if (P_2 == null || P_2.Count == 0)
				{
					return null;
				}
				if (!UXiquCmtDOeaQwAQyOjUeoIArhb(P_0, P_1, out var conflictCheck))
				{
					return null;
				}
				List<ElementAssignmentConflictInfo> list = new List<ElementAssignmentConflictInfo>();
				for (int i = 0; i < P_2.Count; i++)
				{
					foreach (ElementAssignmentConflictInfo item in P_2[i].controllers.conflictChecking.ElementAssignmentConflicts(conflictCheck))
					{
						list.Add(item);
					}
				}
				return list;
			}

			private static bool UXiquCmtDOeaQwAQyOjUeoIArhb(XpXLgXhJhYpLzVpuYDRlPRowsZx P_0, ElementAssignment P_1, out ElementAssignmentConflictCheck P_2)
			{
				Player player;
				if (P_0 == null || (player = P_0.QFlXjfmiJabcsMblLziegHSMCLfJ) == null)
				{
					P_2 = default(ElementAssignmentConflictCheck);
					return false;
				}
				P_2 = P_1.ToElementAssignmentConflictCheck();
				P_2.playerId = player.id;
				P_2.controllerType = P_0.kEHmRBonufPaXwWSSWlSciOdvWy;
				P_2.controllerId = P_0.amFGhwgAUYKGvLkGtwdHnkUiNNi;
				P_2.controllerMapId = P_0.kpBWwwMTmADbFDnoDjprQLxyZrr.controllerMap.id;
				P_2.controllerMapCategoryId = P_0.kpBWwwMTmADbFDnoDjprQLxyZrr.controllerMap.categoryId;
				if (P_0.kpBWwwMTmADbFDnoDjprQLxyZrr.actionElementMapToReplace != null)
				{
					P_2.elementMapId = P_0.kpBWwwMTmADbFDnoDjprQLxyZrr.actionElementMapToReplace.id;
				}
				return true;
			}

			private static void scrZnPABZwCkofDCliWxbWxwTxN(XpXLgXhJhYpLzVpuYDRlPRowsZx P_0, ElementAssignment P_1, List<Player> P_2)
			{
				if (P_0 == null || P_0.QFlXjfmiJabcsMblLziegHSMCLfJ == null)
				{
					return;
				}
				if (!UXiquCmtDOeaQwAQyOjUeoIArhb(P_0, P_1, out var conflictCheck))
				{
					Logger.LogError("Error creating conflict check!");
					return;
				}
				for (int i = 0; i < P_2.Count; i++)
				{
					P_2[i].controllers.conflictChecking.RemoveElementAssignmentConflicts(conflictCheck);
				}
			}

			private void ouvkYNjeDofKrQCzuyaYNxgxFZS()
			{
				ReInput.UpdateEndedEvent -= mtiNfGzpXHszOwiOIAVYQuMZclV;
				ReInput.UpdateEndedEvent += mtiNfGzpXHszOwiOIAVYQuMZclV;
			}

			private void QnfgPHErnCiIycxlKvVvClsuTbXC()
			{
				ReInput.UpdateEndedEvent -= mtiNfGzpXHszOwiOIAVYQuMZclV;
			}

			private bool nvlTtOmpcEgTqqHjjTiespIZdDSh(ulaqcjhcskYwsStRFvlFrhabjpDb P_0)
			{
				SafeDelegate safeDelegate = ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[P_0];
				if (safeDelegate != null)
				{
					return safeDelegate.Count > 0;
				}
				return false;
			}

			private void KafqunbnZKYAVzahhIpWkraFgJVu<T>(ulaqcjhcskYwsStRFvlFrhabjpDb P_0, T P_1)
			{
				SafeAction<T> safeAction = (SafeAction<T>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[P_0];
				if (safeAction.Count != 0)
				{
					safeAction.Invoke(P_1);
				}
			}

			private void rEXSYhPYtgAafqTqpTfOrAQRVAQ()
			{
				DfiJduYcmfxbZUygkFhhmwBiUVv = ReInput.unscaledTime;
			}

			private void bJCzQbLZABerxmFlVdnKaaHPsDr()
			{
				pSrYGzosKYNwVfbqsbjnUxnkXJh = true;
			}

			private void kfneBLHroQGfQIaQbTXkWVQLaCyR(ActionElementMap P_0)
			{
				CPREiVIaJFMkNnQrxiAgoIxyuxNA(P_0);
				yIdByDKOOIBtDKUNHTJwNjHwPBV();
			}

			private void pKpmtzietPCvggwGlbHfbeQjEiAn(string P_0)
			{
				VqCQojPdEQCNVfXfymiorpcgILag(P_0);
				yIdByDKOOIBtDKUNHTJwNjHwPBV();
			}

			private hbBgNLYBTyXLHOEiQbxGFIKpJhn QAnpFJjQxxEBeHPntpXPsVCZReY(ElementAssignment P_0)
			{
				if (nvlTtOmpcEgTqqHjjTiespIZdDSh(ulaqcjhcskYwsStRFvlFrhabjpDb.lIIqWAKoUkJHmWlxeFUdmeyXqQ))
				{
					bool flag = KMpBKWHnpoqTDRKcNvSGueReFPmG(MJlMoAhNQJtAJvqaDCSKrkpAarQ, P_0, lBxLgeDHJbHpYsLJYUDSBecmOU);
					rhPeENbpBiXZmgnwHIzNEnbdwPd = P_0;
					IList<ElementAssignmentConflictInfo> list = xbdHWhjFNBZveKqGGUgyNiGGDHQ(MJlMoAhNQJtAJvqaDCSKrkpAarQ, P_0, lBxLgeDHJbHpYsLJYUDSBecmOU);
					xAODFzDaUdNomacCztokSgPOofHQ = eOlQYDiFBqdcmJhWTNvLBJPqTwB.XsaYexCkpsenghfNvZoxUDTBRJU;
					yObLgjAlaQPHoKEYuLuyqcOpGMK();
					VEHEVgwWCrsFPjYcfLfOdeZjzAf(new ElementAssignmentInfo(MJlMoAhNQJtAJvqaDCSKrkpAarQ.kpBWwwMTmADbFDnoDjprQLxyZrr.controllerMap, P_0), list, flag);
					return hbBgNLYBTyXLHOEiQbxGFIKpJhn.JcTFwVfcIjNKdqhMQMcLAQSZWVoK;
				}
				return sZrFrviHFfHxORgbBikVsXtFQdj(oLwgOlxACYgaeDWHUfDxZufHRffI.defaultActionWhenConflictFound, P_0);
			}

			private hbBgNLYBTyXLHOEiQbxGFIKpJhn sZrFrviHFfHxORgbBikVsXtFQdj(ConflictResponse P_0, ElementAssignment P_1)
			{
				return sZrFrviHFfHxORgbBikVsXtFQdj(P_0, P_1, KMpBKWHnpoqTDRKcNvSGueReFPmG(MJlMoAhNQJtAJvqaDCSKrkpAarQ, P_1, lBxLgeDHJbHpYsLJYUDSBecmOU));
			}

			private hbBgNLYBTyXLHOEiQbxGFIKpJhn sZrFrviHFfHxORgbBikVsXtFQdj(ConflictResponse P_0, ElementAssignment P_1, bool P_2)
			{
				switch (P_0)
				{
				case ConflictResponse.Cancel:
					pKpmtzietPCvggwGlbHfbeQjEiAn("Mapping assignment was canceled due to a conflict.");
					return hbBgNLYBTyXLHOEiQbxGFIKpJhn.JcTFwVfcIjNKdqhMQMcLAQSZWVoK;
				case ConflictResponse.Replace:
					if (P_2)
					{
						pKpmtzietPCvggwGlbHfbeQjEiAn("Mapping assignment was canceled due to a protected conflict that cannot be replaced.");
						return hbBgNLYBTyXLHOEiQbxGFIKpJhn.JcTFwVfcIjNKdqhMQMcLAQSZWVoK;
					}
					scrZnPABZwCkofDCliWxbWxwTxN(MJlMoAhNQJtAJvqaDCSKrkpAarQ, P_1, lBxLgeDHJbHpYsLJYUDSBecmOU);
					return hbBgNLYBTyXLHOEiQbxGFIKpJhn.JyotIIfJnFQzTUQVceUEZcqEQjd;
				case ConflictResponse.Add:
					return hbBgNLYBTyXLHOEiQbxGFIKpJhn.JyotIIfJnFQzTUQVceUEZcqEQjd;
				case ConflictResponse.Ignore:
					lgqjGeBtrIjNPoEmwNtILiIOhAU();
					return hbBgNLYBTyXLHOEiQbxGFIKpJhn.JcTFwVfcIjNKdqhMQMcLAQSZWVoK;
				default:
					throw new NotImplementedException();
				}
			}

			private void CwVNMmvUmLRvtIXpPIFbGSXUaAei()
			{
				IhoGevYIemVfsPxqiVdqNCBvuNI();
				yIdByDKOOIBtDKUNHTJwNjHwPBV();
			}

			private void jAHtoKAAqvswkRedBFEKIPuPLFC(string P_0)
			{
				jaiDqaqpnuACFEpercQqxnWsOcmk(P_0);
				yIdByDKOOIBtDKUNHTJwNjHwPBV();
			}

			private void yObLgjAlaQPHoKEYuLuyqcOpGMK()
			{
				bJCzQbLZABerxmFlVdnKaaHPsDr();
				QnfgPHErnCiIycxlKvVvClsuTbXC();
				MieBNWNoNbgNHwJKkxUXQhMGXXS = Status.AwaitingResponse;
			}

			private void lgqjGeBtrIjNPoEmwNtILiIOhAU()
			{
				MieBNWNoNbgNHwJKkxUXQhMGXXS = Status.Listening;
				xAODFzDaUdNomacCztokSgPOofHQ = eOlQYDiFBqdcmJhWTNvLBJPqTwB.fUyeeVFhkdEderlnmYYFoAwmZEL;
				rEXSYhPYtgAafqTqpTfOrAQRVAQ();
				ouvkYNjeDofKrQCzuyaYNxgxFZS();
			}

			private void fjkcJbffZQCJbGNJfxHZuWncWqMa(ElementAssignment P_0)
			{
				if (MJlMoAhNQJtAJvqaDCSKrkpAarQ.kpBWwwMTmADbFDnoDjprQLxyZrr.controllerMap.ReplaceOrCreateElementMap(P_0, out var result))
				{
					kfneBLHroQGfQIaQbTXkWVQLaCyR(result);
				}
				else
				{
					jAHtoKAAqvswkRedBFEKIPuPLFC("Failed to create element assignment.");
				}
			}

			private void CPREiVIaJFMkNnQrxiAgoIxyuxNA(ActionElementMap P_0)
			{
				if (nvlTtOmpcEgTqqHjjTiespIZdDSh(ulaqcjhcskYwsStRFvlFrhabjpDb.gZjmiDufLkNJNMJoeAxlAqbQgXG))
				{
					KafqunbnZKYAVzahhIpWkraFgJVu(ulaqcjhcskYwsStRFvlFrhabjpDb.gZjmiDufLkNJNMJoeAxlAqbQgXG, new InputMappedEventData(nJGvFkewuzWileOgdgvLxwmBPEU, P_0));
				}
			}

			private void IhoGevYIemVfsPxqiVdqNCBvuNI()
			{
				if (nvlTtOmpcEgTqqHjjTiespIZdDSh(ulaqcjhcskYwsStRFvlFrhabjpDb.vfqfiJDUPEnxUOgPvHjPenQDivhL))
				{
					KafqunbnZKYAVzahhIpWkraFgJVu(ulaqcjhcskYwsStRFvlFrhabjpDb.vfqfiJDUPEnxUOgPvHjPenQDivhL, new TimedOutEventData(nJGvFkewuzWileOgdgvLxwmBPEU));
				}
			}

			private void jaiDqaqpnuACFEpercQqxnWsOcmk(string P_0)
			{
				if (nvlTtOmpcEgTqqHjjTiespIZdDSh(ulaqcjhcskYwsStRFvlFrhabjpDb.thaJMcxCEfniPKfeXdMNDPzzNjYh))
				{
					KafqunbnZKYAVzahhIpWkraFgJVu(ulaqcjhcskYwsStRFvlFrhabjpDb.thaJMcxCEfniPKfeXdMNDPzzNjYh, new ErrorEventData(nJGvFkewuzWileOgdgvLxwmBPEU, P_0));
				}
			}

			private void VqCQojPdEQCNVfXfymiorpcgILag(string P_0)
			{
				if (nvlTtOmpcEgTqqHjjTiespIZdDSh(ulaqcjhcskYwsStRFvlFrhabjpDb.CRfAsWlXRnTwobpjwaGhfHioZAc))
				{
					KafqunbnZKYAVzahhIpWkraFgJVu(ulaqcjhcskYwsStRFvlFrhabjpDb.CRfAsWlXRnTwobpjwaGhfHioZAc, new CanceledEventData(nJGvFkewuzWileOgdgvLxwmBPEU, P_0));
				}
			}

			private void VEHEVgwWCrsFPjYcfLfOdeZjzAf(ElementAssignmentInfo P_0, IList<ElementAssignmentConflictInfo> P_1, bool P_2)
			{
				if (nvlTtOmpcEgTqqHjjTiespIZdDSh(ulaqcjhcskYwsStRFvlFrhabjpDb.lIIqWAKoUkJHmWlxeFUdmeyXqQ))
				{
					KafqunbnZKYAVzahhIpWkraFgJVu(ulaqcjhcskYwsStRFvlFrhabjpDb.lIIqWAKoUkJHmWlxeFUdmeyXqQ, new ConflictFoundEventData(nJGvFkewuzWileOgdgvLxwmBPEU, DFMLgisFSzHfwAJCunyyIZrkAKs, P_0, P_1, P_2));
				}
			}

			private void tpgDOvPdjMefVRCwtnFZsFUPLYg()
			{
				if (nvlTtOmpcEgTqqHjjTiespIZdDSh(ulaqcjhcskYwsStRFvlFrhabjpDb.gVGLonSGYmjRsWheRUXHJADZgbt))
				{
					KafqunbnZKYAVzahhIpWkraFgJVu(ulaqcjhcskYwsStRFvlFrhabjpDb.gVGLonSGYmjRsWheRUXHJADZgbt, new StartedEventData(nJGvFkewuzWileOgdgvLxwmBPEU));
				}
			}

			private void yAerCcoRuuRtJhAaNfqYHfflfJr()
			{
				if (nvlTtOmpcEgTqqHjjTiespIZdDSh(ulaqcjhcskYwsStRFvlFrhabjpDb.ilDqTmxeYoSwjPvYNRcKTJerlvH))
				{
					KafqunbnZKYAVzahhIpWkraFgJVu(ulaqcjhcskYwsStRFvlFrhabjpDb.ilDqTmxeYoSwjPvYNRcKTJerlvH, new StoppedEventData(nJGvFkewuzWileOgdgvLxwmBPEU));
				}
			}

			public void DFMLgisFSzHfwAJCunyyIZrkAKs(ConflictResponse P_0)
			{
				if (MieBNWNoNbgNHwJKkxUXQhMGXXS != Status.AwaitingResponse || xAODFzDaUdNomacCztokSgPOofHQ != eOlQYDiFBqdcmJhWTNvLBJPqTwB.XsaYexCkpsenghfNvZoxUDTBRJU)
				{
					Logger.LogWarning("The Mapping Listener was not waiting for a conflict checking response. The response will be ignored.");
					return;
				}
				try
				{
					if (sZrFrviHFfHxORgbBikVsXtFQdj(P_0, rhPeENbpBiXZmgnwHIzNEnbdwPd) == hbBgNLYBTyXLHOEiQbxGFIKpJhn.JyotIIfJnFQzTUQVceUEZcqEQjd)
					{
						fjkcJbffZQCJbGNJfxHZuWncWqMa(rhPeENbpBiXZmgnwHIzNEnbdwPd);
					}
				}
				catch (Exception ex)
				{
					Logger.LogError("An exception occurred in the conflict check user response callback.\n" + ex);
				}
			}
		}

		public class Options
		{
			internal const string qZQbgXTSLETHuezEMqohrCTsesv = "isElementAllowed";

			private bool PYTjBbOtnGtJYbQJRHlgwqswxLD = true;

			private bool BDGQlkPHZELrFMYoxxpzQAHkeYc = true;

			private bool DINCOBGPUXGHpeZhyhGCISHxIOX = true;

			private float eTPIOCoQUbwJlpZteOPxictSoIv;

			private bool NwtmnAhSffmvECliexMhlUaUZHn = true;

			private bool rOQToqVupgboRFrDZQvxPSRcbEg = true;

			private bool zSEnZNPdojxmOqaeTeigDCkofmrS = true;

			private bool rwMtBhXHoNTspooQCezOgsOEfPE = true;

			private int[] bpMxLtUCuhHEMgImhdCemuvXbsAe;

			private ConflictResponse RHWxWhHWbFeVetszGeyAVtZEjhE = ConflictResponse.Replace;

			private bool EgevgqifefGzIyBWGfmWhFedRrEy;

			private bool wycDUIVNdupKNfUlWtlOZEkWEYt;

			private bool kEWPSdwBgSiURIjKUxhrtlzrAgE = true;

			private bool vaycqqXdDyzKGVgZxNcAjJUwbAo = true;

			private float OCPRbJwuXRKWKIfCOzkBdnWjDfW = 1f;

			private readonly Dictionary<string, SafeDelegate> VjNYMupbvVZvEMsuvMAZkYUmnlB = new Dictionary<string, SafeDelegate> { { "isElementAllowed", null } };

			[CompilerGenerated]
			private static Action<Exception> mKQCrCmgNNDGvCWoLRJbRTDvKuH;

			public bool allowAxes
			{
				get
				{
					return PYTjBbOtnGtJYbQJRHlgwqswxLD;
				}
				set
				{
					PYTjBbOtnGtJYbQJRHlgwqswxLD = value;
				}
			}

			public bool allowButtons
			{
				get
				{
					return BDGQlkPHZELrFMYoxxpzQAHkeYc;
				}
				set
				{
					BDGQlkPHZELrFMYoxxpzQAHkeYc = value;
				}
			}

			public bool allowButtonsOnFullAxisAssignment
			{
				get
				{
					return DINCOBGPUXGHpeZhyhGCISHxIOX;
				}
				set
				{
					DINCOBGPUXGHpeZhyhGCISHxIOX = value;
				}
			}

			public float timeout
			{
				get
				{
					return eTPIOCoQUbwJlpZteOPxictSoIv;
				}
				set
				{
					eTPIOCoQUbwJlpZteOPxictSoIv = MathTools.Max(0f, value);
				}
			}

			public bool checkForConflicts
			{
				get
				{
					return NwtmnAhSffmvECliexMhlUaUZHn;
				}
				set
				{
					NwtmnAhSffmvECliexMhlUaUZHn = value;
				}
			}

			public bool checkForConflictsWithAllPlayers
			{
				get
				{
					return rOQToqVupgboRFrDZQvxPSRcbEg;
				}
				set
				{
					rOQToqVupgboRFrDZQvxPSRcbEg = value;
				}
			}

			public bool checkForConflictsWithSelf
			{
				get
				{
					return zSEnZNPdojxmOqaeTeigDCkofmrS;
				}
				set
				{
					zSEnZNPdojxmOqaeTeigDCkofmrS = value;
				}
			}

			public bool checkForConflictsWithSystemPlayer
			{
				get
				{
					return rwMtBhXHoNTspooQCezOgsOEfPE;
				}
				set
				{
					rwMtBhXHoNTspooQCezOgsOEfPE = value;
				}
			}

			public int[] checkForConflictsWithPlayerIds
			{
				get
				{
					return bpMxLtUCuhHEMgImhdCemuvXbsAe;
				}
				set
				{
					bpMxLtUCuhHEMgImhdCemuvXbsAe = value;
				}
			}

			public ConflictResponse defaultActionWhenConflictFound
			{
				get
				{
					return RHWxWhHWbFeVetszGeyAVtZEjhE;
				}
				set
				{
					RHWxWhHWbFeVetszGeyAVtZEjhE = value;
				}
			}

			public bool ignoreMouseXAxis
			{
				get
				{
					return EgevgqifefGzIyBWGfmWhFedRrEy;
				}
				set
				{
					EgevgqifefGzIyBWGfmWhFedRrEy = value;
				}
			}

			public bool ignoreMouseYAxis
			{
				get
				{
					return wycDUIVNdupKNfUlWtlOZEkWEYt;
				}
				set
				{
					wycDUIVNdupKNfUlWtlOZEkWEYt = value;
				}
			}

			public bool allowKeyboardKeysWithModifiers
			{
				get
				{
					return kEWPSdwBgSiURIjKUxhrtlzrAgE;
				}
				set
				{
					kEWPSdwBgSiURIjKUxhrtlzrAgE = value;
				}
			}

			public bool allowKeyboardModifierKeyAsPrimary
			{
				get
				{
					return vaycqqXdDyzKGVgZxNcAjJUwbAo;
				}
				set
				{
					vaycqqXdDyzKGVgZxNcAjJUwbAo = value;
				}
			}

			public float holdDurationToMapKeyboardModifierKeyAsPrimary
			{
				get
				{
					return OCPRbJwuXRKWKIfCOzkBdnWjDfW;
				}
				set
				{
					OCPRbJwuXRKWKIfCOzkBdnWjDfW = MathTools.Max(0f, value);
				}
			}

			public Predicate<ControllerPollingInfo> isElementAllowedCallback
			{
				get
				{
					return (SafePredicate<ControllerPollingInfo>)VjNYMupbvVZvEMsuvMAZkYUmnlB["isElementAllowed"];
				}
				set
				{
					SafePredicate<ControllerPollingInfo> safePredicate = value;
					if (safePredicate != null)
					{
						safePredicate.ExceptionHandler = delegate(Exception P_0)
						{
							ReInput.HandleCallbackException("InputMapper.Options.isElementAllowedCallback", P_0);
						};
					}
					VjNYMupbvVZvEMsuvMAZkYUmnlB["isElementAllowed"] = safePredicate;
				}
			}

			internal T ZwNeZFaryfiDvMSNibGSOXmhZUs<T>(string P_0) where T : SafeDelegate
			{
				if (!VjNYMupbvVZvEMsuvMAZkYUmnlB.TryGetValue(P_0, out var value))
				{
					return null;
				}
				return value as T;
			}

			public Options()
			{
				LlCkzvOeJVaCziTDPktzBWuYotAZ();
			}

			private Options(Options source)
			{
				if (source == null)
				{
					throw new ArgumentNullException("source");
				}
				Copy(source, this);
			}

			public Options Clone()
			{
				return new Options(this);
			}

			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("Options:\n");
				stringBuilder.Append("allowAxes = " + PYTjBbOtnGtJYbQJRHlgwqswxLD + "\n");
				stringBuilder.Append("allowButtons = " + BDGQlkPHZELrFMYoxxpzQAHkeYc + "\n");
				stringBuilder.Append("allowButtonsOnFullAxisAssignment = " + DINCOBGPUXGHpeZhyhGCISHxIOX + "\n");
				stringBuilder.Append("timeout = " + eTPIOCoQUbwJlpZteOPxictSoIv + "\n");
				stringBuilder.Append("checkForConflicts = " + NwtmnAhSffmvECliexMhlUaUZHn + "\n");
				stringBuilder.Append("checkForConflictsWithAllPlayers = " + rOQToqVupgboRFrDZQvxPSRcbEg + "\n");
				stringBuilder.Append("checkForConflictsWithSelf = " + zSEnZNPdojxmOqaeTeigDCkofmrS + "\n");
				stringBuilder.Append("checkForConflictsWithSystemPlayer = " + rwMtBhXHoNTspooQCezOgsOEfPE + "\n");
				if (bpMxLtUCuhHEMgImhdCemuvXbsAe == null)
				{
					stringBuilder.Append("_checkForConflictsWithPlayerIds = null\n");
				}
				else
				{
					stringBuilder.Append("_checkForConflictsWithPlayerIds = " + StringTools.ToString(bpMxLtUCuhHEMgImhdCemuvXbsAe) + "\n");
				}
				stringBuilder.Append(string.Concat("defaultActionWhenConflictFound = ", RHWxWhHWbFeVetszGeyAVtZEjhE, "\n"));
				stringBuilder.Append("ignoreMouseXAxis = " + EgevgqifefGzIyBWGfmWhFedRrEy);
				stringBuilder.Append("ignoreMouseYAxis = " + wycDUIVNdupKNfUlWtlOZEkWEYt);
				stringBuilder.Append("allowKeyboardKeysWithModifiers = " + kEWPSdwBgSiURIjKUxhrtlzrAgE + "\n");
				stringBuilder.Append("allowKeyboardModifierAsPrimary = " + vaycqqXdDyzKGVgZxNcAjJUwbAo + "\n");
				stringBuilder.Append("holdDurationToMapKeyboardModifierKeyAsPrimary = " + OCPRbJwuXRKWKIfCOzkBdnWjDfW + "\n");
				return stringBuilder.ToString();
			}

			internal void LlCkzvOeJVaCziTDPktzBWuYotAZ()
			{
				PYTjBbOtnGtJYbQJRHlgwqswxLD = true;
				BDGQlkPHZELrFMYoxxpzQAHkeYc = true;
				DINCOBGPUXGHpeZhyhGCISHxIOX = true;
				eTPIOCoQUbwJlpZteOPxictSoIv = 0f;
				NwtmnAhSffmvECliexMhlUaUZHn = true;
				rOQToqVupgboRFrDZQvxPSRcbEg = true;
				zSEnZNPdojxmOqaeTeigDCkofmrS = true;
				rwMtBhXHoNTspooQCezOgsOEfPE = true;
				bpMxLtUCuhHEMgImhdCemuvXbsAe = null;
				RHWxWhHWbFeVetszGeyAVtZEjhE = ConflictResponse.Replace;
				EgevgqifefGzIyBWGfmWhFedRrEy = false;
				wycDUIVNdupKNfUlWtlOZEkWEYt = false;
				kEWPSdwBgSiURIjKUxhrtlzrAgE = true;
				vaycqqXdDyzKGVgZxNcAjJUwbAo = true;
				OCPRbJwuXRKWKIfCOzkBdnWjDfW = 1f;
				List<string> list = new List<string>(VjNYMupbvVZvEMsuvMAZkYUmnlB.Keys);
				foreach (string item in list)
				{
					VjNYMupbvVZvEMsuvMAZkYUmnlB[item] = null;
				}
			}

			public static void Copy(Options source, Options destination)
			{
				if (source == null)
				{
					throw new ArgumentNullException("source");
				}
				if (destination == null)
				{
					throw new ArgumentNullException("destination");
				}
				destination.PYTjBbOtnGtJYbQJRHlgwqswxLD = source.PYTjBbOtnGtJYbQJRHlgwqswxLD;
				destination.BDGQlkPHZELrFMYoxxpzQAHkeYc = source.BDGQlkPHZELrFMYoxxpzQAHkeYc;
				destination.DINCOBGPUXGHpeZhyhGCISHxIOX = source.DINCOBGPUXGHpeZhyhGCISHxIOX;
				destination.eTPIOCoQUbwJlpZteOPxictSoIv = source.eTPIOCoQUbwJlpZteOPxictSoIv;
				destination.NwtmnAhSffmvECliexMhlUaUZHn = source.NwtmnAhSffmvECliexMhlUaUZHn;
				destination.rOQToqVupgboRFrDZQvxPSRcbEg = source.rOQToqVupgboRFrDZQvxPSRcbEg;
				destination.zSEnZNPdojxmOqaeTeigDCkofmrS = source.zSEnZNPdojxmOqaeTeigDCkofmrS;
				destination.rwMtBhXHoNTspooQCezOgsOEfPE = source.rwMtBhXHoNTspooQCezOgsOEfPE;
				destination.bpMxLtUCuhHEMgImhdCemuvXbsAe = ArrayTools.ShallowCopy(source.bpMxLtUCuhHEMgImhdCemuvXbsAe);
				destination.RHWxWhHWbFeVetszGeyAVtZEjhE = source.RHWxWhHWbFeVetszGeyAVtZEjhE;
				destination.EgevgqifefGzIyBWGfmWhFedRrEy = source.EgevgqifefGzIyBWGfmWhFedRrEy;
				destination.wycDUIVNdupKNfUlWtlOZEkWEYt = source.wycDUIVNdupKNfUlWtlOZEkWEYt;
				destination.kEWPSdwBgSiURIjKUxhrtlzrAgE = source.kEWPSdwBgSiURIjKUxhrtlzrAgE;
				destination.vaycqqXdDyzKGVgZxNcAjJUwbAo = source.vaycqqXdDyzKGVgZxNcAjJUwbAo;
				destination.OCPRbJwuXRKWKIfCOzkBdnWjDfW = source.OCPRbJwuXRKWKIfCOzkBdnWjDfW;
				foreach (KeyValuePair<string, SafeDelegate> item in source.VjNYMupbvVZvEMsuvMAZkYUmnlB)
				{
					destination.VjNYMupbvVZvEMsuvMAZkYUmnlB[item.Key] = MiscTools.Clone(item.Value);
				}
			}

			[CompilerGenerated]
			private static void rsdgpZAVRrOYgIyhzfPzUMzHmuH(Exception P_0)
			{
				ReInput.HandleCallbackException("InputMapper.Options.isElementAllowedCallback", P_0);
			}
		}

		private static InputMapper jSlMHYpliVFUzTfJqvhklMtlwTN;

		private static int MXnVsTDVjUGBtCRZAFArwtWmoTA = 0;

		private readonly int nkJIaFMWFAAzjMLxfwxjKIlqjcP;

		private readonly bool hqeLEcOtQgWGFbqiqIdEHCCSTiH;

		private readonly PCokDknkRwDEdhJUOmafgYFqzLy jVYSVHtMFingagbfEDzEelPfMnVl;

		private Options oLwgOlxACYgaeDWHUfDxZufHRffI;

		private readonly Dictionary<ulaqcjhcskYwsStRFvlFrhabjpDb, SafeDelegate> ZAsQmVlcIzbjFBWgMJhiuyaKMjMO = new Dictionary<ulaqcjhcskYwsStRFvlFrhabjpDb, SafeDelegate>
		{
			{
				ulaqcjhcskYwsStRFvlFrhabjpDb.gZjmiDufLkNJNMJoeAxlAqbQgXG,
				new SafeAction<InputMappedEventData>(delegate(Exception P_0)
				{
					ReInput.HandleCallbackException("InputMapper.AssignedEvent", P_0);
				})
			},
			{
				ulaqcjhcskYwsStRFvlFrhabjpDb.thaJMcxCEfniPKfeXdMNDPzzNjYh,
				new SafeAction<ErrorEventData>(delegate(Exception P_0)
				{
					ReInput.HandleCallbackException("InputMapper.ErrorEvent", P_0);
				})
			},
			{
				ulaqcjhcskYwsStRFvlFrhabjpDb.CRfAsWlXRnTwobpjwaGhfHioZAc,
				new SafeAction<CanceledEventData>(delegate(Exception P_0)
				{
					ReInput.HandleCallbackException("InputMapper.CanceledEvent", P_0);
				})
			},
			{
				ulaqcjhcskYwsStRFvlFrhabjpDb.vfqfiJDUPEnxUOgPvHjPenQDivhL,
				new SafeAction<TimedOutEventData>(delegate(Exception P_0)
				{
					ReInput.HandleCallbackException("InputMapper.TimedOutEvent", P_0);
				})
			},
			{
				ulaqcjhcskYwsStRFvlFrhabjpDb.gVGLonSGYmjRsWheRUXHJADZgbt,
				new SafeAction<StartedEventData>(delegate(Exception P_0)
				{
					ReInput.HandleCallbackException("InputMapper.StartedEvent", P_0);
				})
			},
			{
				ulaqcjhcskYwsStRFvlFrhabjpDb.ilDqTmxeYoSwjPvYNRcKTJerlvH,
				new SafeAction<StoppedEventData>(delegate(Exception P_0)
				{
					ReInput.HandleCallbackException("InputMapper.StoppedEvent", P_0);
				})
			},
			{
				ulaqcjhcskYwsStRFvlFrhabjpDb.lIIqWAKoUkJHmWlxeFUdmeyXqQ,
				new SafeAction<ConflictFoundEventData>(delegate(Exception P_0)
				{
					ReInput.HandleCallbackException("InputMapper.ConflictFoundEvent", P_0);
				})
			}
		};

		[CompilerGenerated]
		private static Action<Exception> SgwnZQNOTRUbkQJKmJEKXyGGaN;

		[CompilerGenerated]
		private static Action<Exception> qNraOOiURizrKsGQRcoqxyiwekF;

		[CompilerGenerated]
		private static Action<Exception> HyCmcTHyAhdXLHXzIFmQOMIzjFh;

		[CompilerGenerated]
		private static Action<Exception> gTYRrCnrkVCmudsUsPBUUohWrzM;

		[CompilerGenerated]
		private static Action<Exception> MggiWmlpzhFVcvVyBoVFxcbimgr;

		[CompilerGenerated]
		private static Action<Exception> zBhuNuuEsfwsipThsXHBQeslDqD;

		[CompilerGenerated]
		private static Action<Exception> gvArhGOBWpDcohRlpqsSfXndgoC;

		public static InputMapper Default => jSlMHYpliVFUzTfJqvhklMtlwTN ?? (jSlMHYpliVFUzTfJqvhklMtlwTN = new InputMapper(isDefault: true));

		public Options options
		{
			get
			{
				Options obj = oLwgOlxACYgaeDWHUfDxZufHRffI;
				if (obj == null)
				{
					if (!hqeLEcOtQgWGFbqiqIdEHCCSTiH)
					{
						return oLwgOlxACYgaeDWHUfDxZufHRffI = Default.options.Clone();
					}
					obj = (oLwgOlxACYgaeDWHUfDxZufHRffI = new Options());
				}
				return obj;
			}
			set
			{
				oLwgOlxACYgaeDWHUfDxZufHRffI = value;
			}
		}

		public Context mappingContext => jVYSVHtMFingagbfEDzEelPfMnVl.tMrPuKcwDNOJSFbnlMHMeHHlAdH;

		public Status status => jVYSVHtMFingagbfEDzEelPfMnVl.fhsLQNRdTxTZFGbrMWUBoBnbhdX;

		public float timeRemaining => jVYSVHtMFingagbfEDzEelPfMnVl.yEYHzGsrNcnIQxPFJMKjDzBHDsH;

		internal int id => nkJIaFMWFAAzjMLxfwxjKIlqjcP;

		public event Action<InputMappedEventData> InputMappedEvent
		{
			add
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.gZjmiDufLkNJNMJoeAxlAqbQgXG;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<InputMappedEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] + value;
				}
			}
			remove
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.gZjmiDufLkNJNMJoeAxlAqbQgXG;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<InputMappedEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] - value;
				}
			}
		}

		public event Action<ErrorEventData> ErrorEvent
		{
			add
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.thaJMcxCEfniPKfeXdMNDPzzNjYh;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<ErrorEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] + value;
				}
			}
			remove
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.thaJMcxCEfniPKfeXdMNDPzzNjYh;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<ErrorEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] - value;
				}
			}
		}

		public event Action<CanceledEventData> CanceledEvent
		{
			add
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.CRfAsWlXRnTwobpjwaGhfHioZAc;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<CanceledEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] + value;
				}
			}
			remove
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.CRfAsWlXRnTwobpjwaGhfHioZAc;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<CanceledEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] - value;
				}
			}
		}

		public event Action<TimedOutEventData> TimedOutEvent
		{
			add
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.vfqfiJDUPEnxUOgPvHjPenQDivhL;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<TimedOutEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] + value;
				}
			}
			remove
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.vfqfiJDUPEnxUOgPvHjPenQDivhL;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<TimedOutEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] - value;
				}
			}
		}

		public event Action<StartedEventData> StartedEvent
		{
			add
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.gVGLonSGYmjRsWheRUXHJADZgbt;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<StartedEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] + value;
				}
			}
			remove
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.gVGLonSGYmjRsWheRUXHJADZgbt;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<StartedEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] - value;
				}
			}
		}

		public event Action<StoppedEventData> StoppedEvent
		{
			add
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.ilDqTmxeYoSwjPvYNRcKTJerlvH;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<StoppedEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] + value;
				}
			}
			remove
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.ilDqTmxeYoSwjPvYNRcKTJerlvH;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<StoppedEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] - value;
				}
			}
		}

		public event Action<ConflictFoundEventData> ConflictFoundEvent
		{
			add
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.lIIqWAKoUkJHmWlxeFUdmeyXqQ;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<ConflictFoundEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] + value;
				}
			}
			remove
			{
				if (value != null)
				{
					ulaqcjhcskYwsStRFvlFrhabjpDb key = ulaqcjhcskYwsStRFvlFrhabjpDb.lIIqWAKoUkJHmWlxeFUdmeyXqQ;
					ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] = (SafeAction<ConflictFoundEventData>)ZAsQmVlcIzbjFBWgMJhiuyaKMjMO[key] - value;
				}
			}
		}

		private static int ETLpYTOLeIqlRCvzreIFnmpdQhh()
		{
			int mXnVsTDVjUGBtCRZAFArwtWmoTA = MXnVsTDVjUGBtCRZAFArwtWmoTA;
			if (MXnVsTDVjUGBtCRZAFArwtWmoTA == int.MaxValue)
			{
				MXnVsTDVjUGBtCRZAFArwtWmoTA = 0;
			}
			else
			{
				MXnVsTDVjUGBtCRZAFArwtWmoTA++;
			}
			return mXnVsTDVjUGBtCRZAFArwtWmoTA;
		}

		public InputMapper()
			: this(isDefault: false)
		{
			nkJIaFMWFAAzjMLxfwxjKIlqjcP = ETLpYTOLeIqlRCvzreIFnmpdQhh();
		}

		private InputMapper(bool isDefault)
		{
			hqeLEcOtQgWGFbqiqIdEHCCSTiH = isDefault;
			if (hqeLEcOtQgWGFbqiqIdEHCCSTiH)
			{
				oLwgOlxACYgaeDWHUfDxZufHRffI = new Options();
			}
			jVYSVHtMFingagbfEDzEelPfMnVl = new PCokDknkRwDEdhJUOmafgYFqzLy(this, ZAsQmVlcIzbjFBWgMJhiuyaKMjMO);
		}

		public void RemoveEventListeners(object listenerOrParent)
		{
			if (listenerOrParent == null)
			{
				return;
			}
			foreach (KeyValuePair<ulaqcjhcskYwsStRFvlFrhabjpDb, SafeDelegate> item in ZAsQmVlcIzbjFBWgMJhiuyaKMjMO)
			{
				item.Value.RemoveDelegateOrAllDelegatesFromAnObject(listenerOrParent);
			}
		}

		public void RemoveAllEventListeners()
		{
			foreach (KeyValuePair<ulaqcjhcskYwsStRFvlFrhabjpDb, SafeDelegate> item in ZAsQmVlcIzbjFBWgMJhiuyaKMjMO)
			{
				item.Value.Clear();
			}
		}

		internal void LOilicluTZoiGHjOlehKJIzVFLjo(object P_0)
		{
		}

		internal void zZFJtDRNdlvdjcBYUGaAmQdDIZyd()
		{
		}

		public bool Start(Context mappingContext)
		{
			return tvCBgIPnqjaOIPTXBTydmcrRbzF(mappingContext, (oLwgOlxACYgaeDWHUfDxZufHRffI != null) ? oLwgOlxACYgaeDWHUfDxZufHRffI : Default.options);
		}

		public void Stop()
		{
			jVYSVHtMFingagbfEDzEelPfMnVl.tzaKPylTwphkLfYXQXavMgZqPVf("User canceled.");
		}

		public void Clear()
		{
			Stop();
			RemoveAllEventListeners();
			zZFJtDRNdlvdjcBYUGaAmQdDIZyd();
			oLwgOlxACYgaeDWHUfDxZufHRffI = null;
		}

		private bool tvCBgIPnqjaOIPTXBTydmcrRbzF(Context P_0, Options P_1)
		{
			if (!ReInput.isReady)
			{
				return false;
			}
			if (P_0 == null)
			{
				Logger.LogError("The Context cannot be null.");
				return false;
			}
			if (P_0.controllerMap == null)
			{
				Logger.LogError("The Controller Map cannot be null.");
				return false;
			}
			if (P_0.actionElementMapToReplace != null && !P_0.controllerMap.ContainsElementMap(P_0.actionElementMapToReplace))
			{
				Logger.LogError("The Action Element Map must belong to the same Controller Map you are passing in.");
				return false;
			}
			try
			{
				jVYSVHtMFingagbfEDzEelPfMnVl.tvCBgIPnqjaOIPTXBTydmcrRbzF(P_0, P_1);
				return true;
			}
			catch
			{
				jVYSVHtMFingagbfEDzEelPfMnVl.tzaKPylTwphkLfYXQXavMgZqPVf("Failed to start due to an exception.");
				return false;
			}
		}

		[CompilerGenerated]
		private static void XcuoTWNFxxdouUPmpRRTrlPQmTK(Exception P_0)
		{
			ReInput.HandleCallbackException("InputMapper.AssignedEvent", P_0);
		}

		[CompilerGenerated]
		private static void gvGKktYMgRGljFlTtOsYCScsNxR(Exception P_0)
		{
			ReInput.HandleCallbackException("InputMapper.ErrorEvent", P_0);
		}

		[CompilerGenerated]
		private static void BQmHPCUZJQuotjltbUyugYzGZbL(Exception P_0)
		{
			ReInput.HandleCallbackException("InputMapper.CanceledEvent", P_0);
		}

		[CompilerGenerated]
		private static void iyjznoUUReUEdOgPozQHhmVAKCB(Exception P_0)
		{
			ReInput.HandleCallbackException("InputMapper.TimedOutEvent", P_0);
		}

		[CompilerGenerated]
		private static void IDTgQzevMJdNODDpwazoXmwHAxv(Exception P_0)
		{
			ReInput.HandleCallbackException("InputMapper.StartedEvent", P_0);
		}

		[CompilerGenerated]
		private static void MKrARDhnFyDNQZkfIRxqsZbQbCV(Exception P_0)
		{
			ReInput.HandleCallbackException("InputMapper.StoppedEvent", P_0);
		}

		[CompilerGenerated]
		private static void EfcZKaNRQPkipPAipTRtAaPkaxki(Exception P_0)
		{
			ReInput.HandleCallbackException("InputMapper.ConflictFoundEvent", P_0);
		}
	}
}
