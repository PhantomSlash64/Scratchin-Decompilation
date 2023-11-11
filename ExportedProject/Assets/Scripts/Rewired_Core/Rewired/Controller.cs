using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Utils;
using UnityEngine;

namespace Rewired
{
	public abstract class Controller
	{
		public abstract class Element
		{
			internal abstract class KBYdAfHcKWiFmvdIcfykIcVEkgs
			{
				public abstract class eAixhNvRHPeuTjlTixcbWImRSnv
				{
					public abstract void skeOSBSqSPGPnIZySfEhxuCHbTXM();
				}

				protected readonly int yiagAdjmjzavWfNAtzbnrNRjzWw;

				protected readonly int[] aGIULMrkHyzNxxickXxtMZbJIyW;

				protected eAixhNvRHPeuTjlTixcbWImRSnv[] EWoddpLmOVAVehNObYQCwzxxzbG;

				public eAixhNvRHPeuTjlTixcbWImRSnv HBFpvdVSEToPvyDvjayPiQyuurNQ;

				private int dNOdUInaodFiUtCCqNVAVCVTTGl;

				public int pGdFhtIDBujVREblgTVumQrDDssM = -1;

				protected ReadOnlyCollection<eAixhNvRHPeuTjlTixcbWImRSnv> wftcMZxobriksrqTEdwPEWOrIqHu;

				public IList<eAixhNvRHPeuTjlTixcbWImRSnv> MDVkhUEPGquMkUMaxUdVywzYhJG => wftcMZxobriksrqTEdwPEWOrIqHu;

				public UpdateLoopType EtMuBRTmVzCBLcuxYRMlwUqRdAzD
				{
					set
					{
						if (pGdFhtIDBujVREblgTVumQrDDssM != (int)value)
						{
							pGdFhtIDBujVREblgTVumQrDDssM = (int)value;
							dNOdUInaodFiUtCCqNVAVCVTTGl = aGIULMrkHyzNxxickXxtMZbJIyW[(int)value];
							HBFpvdVSEToPvyDvjayPiQyuurNQ = EWoddpLmOVAVehNObYQCwzxxzbG[dNOdUInaodFiUtCCqNVAVCVTTGl];
						}
					}
				}

				public KBYdAfHcKWiFmvdIcfykIcVEkgs(UpdateLoopSetting updateLoopSetting)
				{
					aGIULMrkHyzNxxickXxtMZbJIyW = new int[3];
					yiagAdjmjzavWfNAtzbnrNRjzWw = 0;
					using (TempListPool.TList<UpdateLoopType> tList = TempListPool.GetTList<UpdateLoopType>(3))
					{
						List<UpdateLoopType> list = tList.list;
						EnumConverter.ToUpdateLoopTypes(updateLoopSetting, list);
						for (int i = 0; i < list.Count; i++)
						{
							aGIULMrkHyzNxxickXxtMZbJIyW[(int)list[i]] = yiagAdjmjzavWfNAtzbnrNRjzWw;
							yiagAdjmjzavWfNAtzbnrNRjzWw++;
						}
					}
					EWoddpLmOVAVehNObYQCwzxxzbG = new eAixhNvRHPeuTjlTixcbWImRSnv[yiagAdjmjzavWfNAtzbnrNRjzWw];
					wftcMZxobriksrqTEdwPEWOrIqHu = new ReadOnlyCollection<eAixhNvRHPeuTjlTixcbWImRSnv>(EWoddpLmOVAVehNObYQCwzxxzbG);
				}

				public void skeOSBSqSPGPnIZySfEhxuCHbTXM()
				{
					for (int i = 0; i < yiagAdjmjzavWfNAtzbnrNRjzWw; i++)
					{
						EWoddpLmOVAVehNObYQCwzxxzbG[i].skeOSBSqSPGPnIZySfEhxuCHbTXM();
					}
				}
			}

			public readonly int id;

			public readonly string name;

			public readonly ControllerElementType type;

			internal KBYdAfHcKWiFmvdIcfykIcVEkgs zbsfnsAJkRolPwAdMvMYhQprRpq;

			internal int APfANorPnsyvRKUKthifuVbhOzp;

			internal Controller bGNJaBTbykivsIWbGpkIOAQalRn;

			internal readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

			public ControllerElementIdentifier elementIdentifier
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					ControllerElementIdentifier elementIdentifierById = bGNJaBTbykivsIWbGpkIOAQalRn.GetElementIdentifierById(id);
					if (elementIdentifierById == null)
					{
						return ControllerElementIdentifier.BlankReadOnly;
					}
					return elementIdentifierById;
				}
			}

			public bool isMemberElement
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return APfANorPnsyvRKUKthifuVbhOzp > 0;
				}
			}

			internal Element(Controller controller, int elementIdentifierId, string name, ControllerElementType type)
			{
				bGNJaBTbykivsIWbGpkIOAQalRn = controller;
				id = elementIdentifierId;
				this.name = name;
				this.type = type;
				PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
			}

			public void Reset()
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else if (zbsfnsAJkRolPwAdMvMYhQprRpq != null)
				{
					zbsfnsAJkRolPwAdMvMYhQprRpq.skeOSBSqSPGPnIZySfEhxuCHbTXM();
				}
			}

			internal void hhGKGEblUMtTggBzIpPjixaHjCt()
			{
				if (APfANorPnsyvRKUKthifuVbhOzp > 0)
				{
					Logger.LogWarning("This element is already a member of a compound element! This is not supported. Resulting values may be unpredictable.");
				}
				APfANorPnsyvRKUKthifuVbhOzp++;
			}

			internal void IqktjVrJMgvQKxPIJcyWVwklARwF()
			{
				if (APfANorPnsyvRKUKthifuVbhOzp == 0)
				{
					Logger.LogWarning("This element is not a member of a compound element!");
					APfANorPnsyvRKUKthifuVbhOzp = 0;
				}
				else
				{
					APfANorPnsyvRKUKthifuVbhOzp--;
				}
			}
		}

		public sealed class Axis : Element
		{
			internal class NhCcqPVdaKGDenxxETCDFpQaQEV : KBYdAfHcKWiFmvdIcfykIcVEkgs
			{
				public class ImDGNSODOrNbPVIkIOrkkCStDNZ : eAixhNvRHPeuTjlTixcbWImRSnv
				{
					private const float yakWktdfxAESZCGmUhGEmpNpCIZO = 0.001f;

					public float foSRcEqSuRsWnadDiKcGnhBewOU;

					public float lpYFNtKbgvQlXkTOFBiOFvFHrsdB;

					public float vEshYOeqNajZIsFWlexCTVPXsUz;

					public float WjroTGqoYHbCUZNXYQptdXZaQwo;

					public float MhHqmEeUKJmvuyfWPGSFggYYvOyS;

					public float hvsWusYaMEeOvJBqJPCHDWcZIwz;

					public double EyMNuthnmxCkqVNIBJbiqdPVzkW;

					public double gOyXMpZVfiSIbMsGJxAYLwiqsmo;

					public double rIMnRkrUVrdoYwjXBgcfjBjqyrN;

					public double hlTEPeMZBVLvbkoimBzeFLqyuYF;

					public double WULwMDZqmntIIPfhkMBZGZcnPWP;

					public double QuZSyLsjRymbeuXgODaNdCkNTPz;

					public double QcEcYPrATEfSXYbemLVhNtZNdsf
					{
						get
						{
							if ((double)foSRcEqSuRsWnadDiKcGnhBewOU == 0.0)
							{
								return 0.0;
							}
							return ReInput.unscaledTime - rIMnRkrUVrdoYwjXBgcfjBjqyrN;
						}
					}

					public double TKIowBeUudGDFJAOwyTNaMVJKag
					{
						get
						{
							if ((double)vEshYOeqNajZIsFWlexCTVPXsUz == 0.0)
							{
								return 0.0;
							}
							return ReInput.unscaledTime - hlTEPeMZBVLvbkoimBzeFLqyuYF;
						}
					}

					public double QXyeQBMYWpnQPfwWdGxMgEdMUFQ
					{
						get
						{
							if (foSRcEqSuRsWnadDiKcGnhBewOU != 0f)
							{
								return 0.0;
							}
							return ReInput.unscaledTime - EyMNuthnmxCkqVNIBJbiqdPVzkW;
						}
					}

					public double krBwyjeRGdVFkXjQirETXuIPFil
					{
						get
						{
							if ((double)vEshYOeqNajZIsFWlexCTVPXsUz != 0.0)
							{
								return 0.0;
							}
							return ReInput.unscaledTime - gOyXMpZVfiSIbMsGJxAYLwiqsmo;
						}
					}

					public void mtiNfGzpXHszOwiOIAVYQuMZclV(bool P_0)
					{
						double unscaledTime = ReInput.unscaledTime;
						if (P_0)
						{
							if (!MathTools.Approximately(MhHqmEeUKJmvuyfWPGSFggYYvOyS, 0f))
							{
								EyMNuthnmxCkqVNIBJbiqdPVzkW = unscaledTime;
							}
							else
							{
								rIMnRkrUVrdoYwjXBgcfjBjqyrN = unscaledTime;
							}
							if (!MathTools.IsNear(MhHqmEeUKJmvuyfWPGSFggYYvOyS, hvsWusYaMEeOvJBqJPCHDWcZIwz, 0.001f))
							{
								WULwMDZqmntIIPfhkMBZGZcnPWP = unscaledTime;
							}
						}
						else
						{
							if (!MathTools.Approximately(foSRcEqSuRsWnadDiKcGnhBewOU, 0f))
							{
								EyMNuthnmxCkqVNIBJbiqdPVzkW = unscaledTime;
							}
							else
							{
								rIMnRkrUVrdoYwjXBgcfjBjqyrN = unscaledTime;
							}
							if (!MathTools.IsNear(foSRcEqSuRsWnadDiKcGnhBewOU, lpYFNtKbgvQlXkTOFBiOFvFHrsdB, 0.001f))
							{
								WULwMDZqmntIIPfhkMBZGZcnPWP = unscaledTime;
							}
						}
						if (!MathTools.Approximately(vEshYOeqNajZIsFWlexCTVPXsUz, 0f))
						{
							gOyXMpZVfiSIbMsGJxAYLwiqsmo = unscaledTime;
						}
						else
						{
							hlTEPeMZBVLvbkoimBzeFLqyuYF = unscaledTime;
						}
						if (!MathTools.IsNear(vEshYOeqNajZIsFWlexCTVPXsUz, WjroTGqoYHbCUZNXYQptdXZaQwo, 0.001f))
						{
							QuZSyLsjRymbeuXgODaNdCkNTPz = unscaledTime;
						}
					}

					public void AfAdDXdeMOtWZHQMCpebmOSkstl(float P_0)
					{
						if (WjroTGqoYHbCUZNXYQptdXZaQwo != vEshYOeqNajZIsFWlexCTVPXsUz)
						{
							WjroTGqoYHbCUZNXYQptdXZaQwo = vEshYOeqNajZIsFWlexCTVPXsUz;
						}
						if (vEshYOeqNajZIsFWlexCTVPXsUz != P_0)
						{
							vEshYOeqNajZIsFWlexCTVPXsUz = P_0;
						}
					}

					public override void skeOSBSqSPGPnIZySfEhxuCHbTXM()
					{
						foSRcEqSuRsWnadDiKcGnhBewOU = 0f;
						lpYFNtKbgvQlXkTOFBiOFvFHrsdB = 0f;
						vEshYOeqNajZIsFWlexCTVPXsUz = 0f;
						WjroTGqoYHbCUZNXYQptdXZaQwo = 0f;
						EyMNuthnmxCkqVNIBJbiqdPVzkW = 0.0;
						gOyXMpZVfiSIbMsGJxAYLwiqsmo = 0.0;
						rIMnRkrUVrdoYwjXBgcfjBjqyrN = 0.0;
						hlTEPeMZBVLvbkoimBzeFLqyuYF = 0.0;
						WULwMDZqmntIIPfhkMBZGZcnPWP = 0.0;
						QuZSyLsjRymbeuXgODaNdCkNTPz = 0.0;
					}
				}

				public NhCcqPVdaKGDenxxETCDFpQaQEV(UpdateLoopSetting updateCycle)
					: base(updateCycle)
				{
					for (int i = 0; i < yiagAdjmjzavWfNAtzbnrNRjzWw; i++)
					{
						EWoddpLmOVAVehNObYQCwzxxzbG[i] = new ImDGNSODOrNbPVIkIOrkkCStDNZ();
					}
					HBFpvdVSEToPvyDvjayPiQyuurNQ = EWoddpLmOVAVehNObYQCwzxxzbG[0];
				}
			}

			internal readonly AxisRange wFPCDDgKIQjzisCkdxAihnjtLSVb;

			internal readonly HardwareAxisInfo LFHpDfBYTFpZGnHfuiJaFQDzksL;

			public float value
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					if (base.isMemberElement)
					{
						return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).MhHqmEeUKJmvuyfWPGSFggYYvOyS;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).foSRcEqSuRsWnadDiKcGnhBewOU;
				}
			}

			public float valuePrev
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					if (base.isMemberElement)
					{
						return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).hvsWusYaMEeOvJBqJPCHDWcZIwz;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).lpYFNtKbgvQlXkTOFBiOFvFHrsdB;
				}
			}

			public float valueRaw
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).vEshYOeqNajZIsFWlexCTVPXsUz;
				}
				internal set
				{
					((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).AfAdDXdeMOtWZHQMCpebmOSkstl(value);
				}
			}

			public float valueRawPrev
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).WjroTGqoYHbCUZNXYQptdXZaQwo;
				}
			}

			public float valueDelta
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					return value - valuePrev;
				}
			}

			public float valueDeltaRaw
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).vEshYOeqNajZIsFWlexCTVPXsUz - ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).WjroTGqoYHbCUZNXYQptdXZaQwo;
				}
			}

			public double lastTimeActive
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).EyMNuthnmxCkqVNIBJbiqdPVzkW;
				}
			}

			public double lastTimeActiveRaw
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).gOyXMpZVfiSIbMsGJxAYLwiqsmo;
				}
			}

			public double lastTimeInactive
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).rIMnRkrUVrdoYwjXBgcfjBjqyrN;
				}
			}

			public double lastTimeInactiveRaw
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).hlTEPeMZBVLvbkoimBzeFLqyuYF;
				}
			}

			public double lastTimeValueChanged
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).WULwMDZqmntIIPfhkMBZGZcnPWP;
				}
			}

			public double lastTimeValueChangedRaw
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).QuZSyLsjRymbeuXgODaNdCkNTPz;
				}
			}

			public double timeActive
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).QcEcYPrATEfSXYbemLVhNtZNdsf;
				}
			}

			public double timeActiveRaw
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).QcEcYPrATEfSXYbemLVhNtZNdsf;
				}
			}

			public double timeInactive
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).QXyeQBMYWpnQPfwWdGxMgEdMUFQ;
				}
			}

			public double timeInactiveRaw
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).krBwyjeRGdVFkXjQirETXuIPFil;
				}
			}

			public float pollingDeadZone
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					if (LFHpDfBYTFpZGnHfuiJaFQDzksL == null)
					{
						return -1f;
					}
					return LFHpDfBYTFpZGnHfuiJaFQDzksL._pollingDeadZone;
				}
				set
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					if (value < 0f)
					{
						value = -1f;
					}
					if (LFHpDfBYTFpZGnHfuiJaFQDzksL != null)
					{
						LFHpDfBYTFpZGnHfuiJaFQDzksL._pollingDeadZone = value;
					}
				}
			}

			internal float selfValue => ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).foSRcEqSuRsWnadDiKcGnhBewOU;

			internal float selfValuePrev => ((NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).lpYFNtKbgvQlXkTOFBiOFvFHrsdB;

			internal float effectivePollingDeadZone
			{
				get
				{
					if (LFHpDfBYTFpZGnHfuiJaFQDzksL == null)
					{
						return ReInput.configuration.defaultAbsoluteAxisPollingDeadZone;
					}
					if (LFHpDfBYTFpZGnHfuiJaFQDzksL._pollingDeadZone >= 0f)
					{
						return LFHpDfBYTFpZGnHfuiJaFQDzksL._pollingDeadZone;
					}
					return LFHpDfBYTFpZGnHfuiJaFQDzksL._dataFormat switch
					{
						AxisCoordinateMode.Absolute => ReInput.configuration.defaultAbsoluteAxisPollingDeadZone, 
						AxisCoordinateMode.Relative => ReInput.configuration.defaultRelativeAxisPollingDeadZone, 
						_ => throw new NotImplementedException(), 
					};
				}
			}

			internal void cgscnucQbaoRzaJPFWXGEFQhOgGG(float P_0)
			{
				NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ imDGNSODOrNbPVIkIOrkkCStDNZ = (NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ;
				imDGNSODOrNbPVIkIOrkkCStDNZ.hvsWusYaMEeOvJBqJPCHDWcZIwz = imDGNSODOrNbPVIkIOrkkCStDNZ.MhHqmEeUKJmvuyfWPGSFggYYvOyS;
				imDGNSODOrNbPVIkIOrkkCStDNZ.MhHqmEeUKJmvuyfWPGSFggYYvOyS = P_0;
			}

			internal Axis(Controller controller, int elementIdentifierId, string name, AxisRange axisRange, HardwareAxisInfo axisInfo)
				: base(controller, elementIdentifierId, name, ControllerElementType.Axis)
			{
				zbsfnsAJkRolPwAdMvMYhQprRpq = new NhCcqPVdaKGDenxxETCDFpQaQEV(ReInput.configVars.updateLoop);
				wFPCDDgKIQjzisCkdxAihnjtLSVb = axisRange;
				LFHpDfBYTFpZGnHfuiJaFQDzksL = axisInfo;
			}

			internal void ZHbqAzgcRVJdHLAKApmQADNbCox(UpdateLoopType P_0)
			{
				if (zbsfnsAJkRolPwAdMvMYhQprRpq != null && zbsfnsAJkRolPwAdMvMYhQprRpq.pGdFhtIDBujVREblgTVumQrDDssM != (int)P_0)
				{
					zbsfnsAJkRolPwAdMvMYhQprRpq.EtMuBRTmVzCBLcuxYRMlwUqRdAzD = P_0;
				}
			}

			internal void syUHSTuGqmwYxveNsFaiKUFqoJk(AxisCalibration P_0)
			{
				NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ imDGNSODOrNbPVIkIOrkkCStDNZ = (NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ;
				imDGNSODOrNbPVIkIOrkkCStDNZ.lpYFNtKbgvQlXkTOFBiOFvFHrsdB = imDGNSODOrNbPVIkIOrkkCStDNZ.foSRcEqSuRsWnadDiKcGnhBewOU;
				float foSRcEqSuRsWnadDiKcGnhBewOU = P_0.GetCalibratedValue(imDGNSODOrNbPVIkIOrkkCStDNZ.vEshYOeqNajZIsFWlexCTVPXsUz, wFPCDDgKIQjzisCkdxAihnjtLSVb);
				if (P_0.applyRangeCalibration)
				{
					foSRcEqSuRsWnadDiKcGnhBewOU = MathTools.Clamp(foSRcEqSuRsWnadDiKcGnhBewOU, -1f, 1f);
				}
				imDGNSODOrNbPVIkIOrkkCStDNZ.foSRcEqSuRsWnadDiKcGnhBewOU = foSRcEqSuRsWnadDiKcGnhBewOU;
			}

			internal void syUHSTuGqmwYxveNsFaiKUFqoJk()
			{
				NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ imDGNSODOrNbPVIkIOrkkCStDNZ = (NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ;
				imDGNSODOrNbPVIkIOrkkCStDNZ.lpYFNtKbgvQlXkTOFBiOFvFHrsdB = imDGNSODOrNbPVIkIOrkkCStDNZ.foSRcEqSuRsWnadDiKcGnhBewOU;
				imDGNSODOrNbPVIkIOrkkCStDNZ.foSRcEqSuRsWnadDiKcGnhBewOU = imDGNSODOrNbPVIkIOrkkCStDNZ.vEshYOeqNajZIsFWlexCTVPXsUz;
			}

			internal void FkFxYeeGvaQvvbEIxTHwNOfMnlD()
			{
				NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ imDGNSODOrNbPVIkIOrkkCStDNZ = (NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ;
				imDGNSODOrNbPVIkIOrkkCStDNZ.lpYFNtKbgvQlXkTOFBiOFvFHrsdB = imDGNSODOrNbPVIkIOrkkCStDNZ.foSRcEqSuRsWnadDiKcGnhBewOU;
				imDGNSODOrNbPVIkIOrkkCStDNZ.foSRcEqSuRsWnadDiKcGnhBewOU = 0f;
			}

			internal void NOfqZRIYiAWgxnqOagfvAfGjjPW()
			{
				NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ imDGNSODOrNbPVIkIOrkkCStDNZ = (NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ;
				imDGNSODOrNbPVIkIOrkkCStDNZ.mtiNfGzpXHszOwiOIAVYQuMZclV(base.isMemberElement);
			}

			internal void ztVSpWDZIZxAEYGNFDunZGMouOU(float P_0)
			{
				for (int i = 0; i < zbsfnsAJkRolPwAdMvMYhQprRpq.MDVkhUEPGquMkUMaxUdVywzYhJG.Count; i++)
				{
					if (zbsfnsAJkRolPwAdMvMYhQprRpq.MDVkhUEPGquMkUMaxUdVywzYhJG[i] is NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ imDGNSODOrNbPVIkIOrkkCStDNZ)
					{
						imDGNSODOrNbPVIkIOrkkCStDNZ.AfAdDXdeMOtWZHQMCpebmOSkstl(P_0);
						imDGNSODOrNbPVIkIOrkkCStDNZ.lpYFNtKbgvQlXkTOFBiOFvFHrsdB = imDGNSODOrNbPVIkIOrkkCStDNZ.foSRcEqSuRsWnadDiKcGnhBewOU;
						imDGNSODOrNbPVIkIOrkkCStDNZ.foSRcEqSuRsWnadDiKcGnhBewOU = 0f;
						imDGNSODOrNbPVIkIOrkkCStDNZ.mtiNfGzpXHszOwiOIAVYQuMZclV(base.isMemberElement);
					}
				}
			}

			internal float gqrzqTpEzsVCaoHFHAXztYwZhmg(UpdateLoopType P_0, AxisCalibration P_1)
			{
				NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ imDGNSODOrNbPVIkIOrkkCStDNZ = (NhCcqPVdaKGDenxxETCDFpQaQEV.ImDGNSODOrNbPVIkIOrkkCStDNZ)zbsfnsAJkRolPwAdMvMYhQprRpq.MDVkhUEPGquMkUMaxUdVywzYhJG[(int)P_0];
				float result = P_1.GetCalibratedValue(imDGNSODOrNbPVIkIOrkkCStDNZ.vEshYOeqNajZIsFWlexCTVPXsUz, wFPCDDgKIQjzisCkdxAihnjtLSVb, P_1.deadZone, applySensitivity: false, applyInversion: true);
				if (P_1.applyRangeCalibration)
				{
					result = MathTools.Clamp(result, -1f, 1f);
				}
				return result;
			}
		}

		public sealed class Button : Element
		{
			internal class YkHolmvylQOvJPxxsDndJugzgiP : KBYdAfHcKWiFmvdIcfykIcVEkgs
			{
				public class pSOrqGXeVSwcLrIhPyMDGQLZNdu : eAixhNvRHPeuTjlTixcbWImRSnv
				{
					public bool foSRcEqSuRsWnadDiKcGnhBewOU;

					public bool lpYFNtKbgvQlXkTOFBiOFvFHrsdB;

					public ButtonStateRecorder zUCDvuoEzhgDmeWZRUEiGITIqmMw;

					public JjpfCjZhflHaugehqRhAiskkfYjc yLQKpqqYhcHlHpqQzCZpAaoKNvQE;

					public pSOrqGXeVSwcLrIhPyMDGQLZNdu()
					{
						zUCDvuoEzhgDmeWZRUEiGITIqmMw = new ButtonStateRecorder();
						yLQKpqqYhcHlHpqQzCZpAaoKNvQE = new JjpfCjZhflHaugehqRhAiskkfYjc(0.3f);
					}

					public void wAlHJoEseXwZfahDSIeyAibjNOI(bool P_0)
					{
						if (lpYFNtKbgvQlXkTOFBiOFvFHrsdB != foSRcEqSuRsWnadDiKcGnhBewOU)
						{
							lpYFNtKbgvQlXkTOFBiOFvFHrsdB = foSRcEqSuRsWnadDiKcGnhBewOU;
						}
						if (foSRcEqSuRsWnadDiKcGnhBewOU != P_0)
						{
							foSRcEqSuRsWnadDiKcGnhBewOU = P_0;
						}
						zUCDvuoEzhgDmeWZRUEiGITIqmMw.mtiNfGzpXHszOwiOIAVYQuMZclV(P_0 && !lpYFNtKbgvQlXkTOFBiOFvFHrsdB, P_0, ReInput.unscaledTime);
						yLQKpqqYhcHlHpqQzCZpAaoKNvQE.mtiNfGzpXHszOwiOIAVYQuMZclV(0.3f, P_0 && !lpYFNtKbgvQlXkTOFBiOFvFHrsdB, P_0);
					}

					public override void skeOSBSqSPGPnIZySfEhxuCHbTXM()
					{
						foSRcEqSuRsWnadDiKcGnhBewOU = false;
						lpYFNtKbgvQlXkTOFBiOFvFHrsdB = false;
						zUCDvuoEzhgDmeWZRUEiGITIqmMw.skeOSBSqSPGPnIZySfEhxuCHbTXM();
						yLQKpqqYhcHlHpqQzCZpAaoKNvQE.skeOSBSqSPGPnIZySfEhxuCHbTXM();
					}
				}

				public class RTxiEfjpFtbDpCatHTRiDxNDOxGQ : pSOrqGXeVSwcLrIhPyMDGQLZNdu
				{
					public float KwkbohAxrjrjlksqWWLFLNpTozzI;

					public float bYfboMEelHmbBDYOVconCzrKhMX;

					public void wAlHJoEseXwZfahDSIeyAibjNOI(float P_0)
					{
						if (bYfboMEelHmbBDYOVconCzrKhMX != KwkbohAxrjrjlksqWWLFLNpTozzI)
						{
							bYfboMEelHmbBDYOVconCzrKhMX = KwkbohAxrjrjlksqWWLFLNpTozzI;
						}
						if (KwkbohAxrjrjlksqWWLFLNpTozzI != P_0)
						{
							KwkbohAxrjrjlksqWWLFLNpTozzI = ((P_0 > 0.001f) ? P_0 : 0f);
						}
						wAlHJoEseXwZfahDSIeyAibjNOI(KwkbohAxrjrjlksqWWLFLNpTozzI > 0f);
					}

					public override void skeOSBSqSPGPnIZySfEhxuCHbTXM()
					{
						base.skeOSBSqSPGPnIZySfEhxuCHbTXM();
						KwkbohAxrjrjlksqWWLFLNpTozzI = 0f;
						bYfboMEelHmbBDYOVconCzrKhMX = 0f;
					}
				}

				public YkHolmvylQOvJPxxsDndJugzgiP(UpdateLoopSetting updateCycle, bool isPressureSensitive)
					: base(updateCycle)
				{
					for (int i = 0; i < yiagAdjmjzavWfNAtzbnrNRjzWw; i++)
					{
						if (isPressureSensitive)
						{
							EWoddpLmOVAVehNObYQCwzxxzbG[i] = new RTxiEfjpFtbDpCatHTRiDxNDOxGQ();
						}
						else
						{
							EWoddpLmOVAVehNObYQCwzxxzbG[i] = new pSOrqGXeVSwcLrIhPyMDGQLZNdu();
						}
					}
					HBFpvdVSEToPvyDvjayPiQyuurNQ = EWoddpLmOVAVehNObYQCwzxxzbG[0];
				}

				public void MlwBgmULDKixSnMopbfJhEPapGM(float P_0)
				{
					for (int i = 0; i < EWoddpLmOVAVehNObYQCwzxxzbG.Length; i++)
					{
						((pSOrqGXeVSwcLrIhPyMDGQLZNdu)EWoddpLmOVAVehNObYQCwzxxzbG[i]).yLQKpqqYhcHlHpqQzCZpAaoKNvQE.DyyIlWcBFjWVWrYnHySrmZcOccp(P_0);
					}
				}

				public void owtGQABgvxMpUEiiaqHDKkeZmETW()
				{
					for (int i = 0; i < EWoddpLmOVAVehNObYQCwzxxzbG.Length; i++)
					{
						((pSOrqGXeVSwcLrIhPyMDGQLZNdu)EWoddpLmOVAVehNObYQCwzxxzbG[i]).yLQKpqqYhcHlHpqQzCZpAaoKNvQE.DyyIlWcBFjWVWrYnHySrmZcOccp(0.3f);
					}
				}
			}

			internal readonly bool oHmFyMLXhcgyxcsDcMAFAkFKvCur;

			internal readonly HardwareButtonInfo jpkJjXWhMrgUwNmqszFLtsuhiPR;

			public bool valuePrev
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).lpYFNtKbgvQlXkTOFBiOFvFHrsdB;
				}
			}

			public bool value
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).foSRcEqSuRsWnadDiKcGnhBewOU;
				}
			}

			public float pressure
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					if (!oHmFyMLXhcgyxcsDcMAFAkFKvCur)
					{
						if (!((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).foSRcEqSuRsWnadDiKcGnhBewOU)
						{
							return 0f;
						}
						return 1f;
					}
					return ((YkHolmvylQOvJPxxsDndJugzgiP.RTxiEfjpFtbDpCatHTRiDxNDOxGQ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).KwkbohAxrjrjlksqWWLFLNpTozzI;
				}
			}

			public float pressurePrev
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					if (!oHmFyMLXhcgyxcsDcMAFAkFKvCur)
					{
						if (!((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).lpYFNtKbgvQlXkTOFBiOFvFHrsdB)
						{
							return 0f;
						}
						return 1f;
					}
					return ((YkHolmvylQOvJPxxsDndJugzgiP.RTxiEfjpFtbDpCatHTRiDxNDOxGQ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).bYfboMEelHmbBDYOVconCzrKhMX;
				}
			}

			public bool isPressureSensitive
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return oHmFyMLXhcgyxcsDcMAFAkFKvCur;
				}
			}

			public bool justPressed
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (!((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).lpYFNtKbgvQlXkTOFBiOFvFHrsdB && ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).foSRcEqSuRsWnadDiKcGnhBewOU)
					{
						return true;
					}
					return false;
				}
			}

			public bool justReleased
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).lpYFNtKbgvQlXkTOFBiOFvFHrsdB && !((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).foSRcEqSuRsWnadDiKcGnhBewOU)
					{
						return true;
					}
					return false;
				}
			}

			public bool justChangedState
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).lpYFNtKbgvQlXkTOFBiOFvFHrsdB != ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).foSRcEqSuRsWnadDiKcGnhBewOU)
					{
						return true;
					}
					return false;
				}
			}

			public bool doublePressedAndHeld
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).yLQKpqqYhcHlHpqQzCZpAaoKNvQE.iBGQhhKyEtmNYjqNNGqwPkYNvlD;
				}
			}

			public bool justDoublePressed
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (!justPressed)
					{
						return false;
					}
					return ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).yLQKpqqYhcHlHpqQzCZpAaoKNvQE.iBGQhhKyEtmNYjqNNGqwPkYNvlD;
				}
			}

			public double timePressed
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).zUCDvuoEzhgDmeWZRUEiGITIqmMw.bCtgQgKIZQMqKaoCZEovBFxajVIW;
				}
			}

			public double timeUnpressed
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).zUCDvuoEzhgDmeWZRUEiGITIqmMw.cdVnkQiIOdWWtDIVNKPTKlXwzRr;
				}
			}

			public double lastTimePressed
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).zUCDvuoEzhgDmeWZRUEiGITIqmMw.OmnDLpXjutzYooluXcseMSQzJpv;
				}
			}

			public double lastTimeUnpressed
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).zUCDvuoEzhgDmeWZRUEiGITIqmMw.XGDIqvxDbuLNASOqByMJKETgGjX;
				}
			}

			public double lastTimeStateChanged
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0.0;
					}
					return ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).zUCDvuoEzhgDmeWZRUEiGITIqmMw.qSDbFEFoGmJeoPBvHjByoKhZKeXN;
				}
			}

			internal ButtonStateFlags state
			{
				get
				{
					YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu pSOrqGXeVSwcLrIhPyMDGQLZNdu = (YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ;
					ButtonStateFlags buttonStateFlags = ButtonStateFlags.DyTkQiNnAPnZlOxrECHYhBSslIv;
					if (pSOrqGXeVSwcLrIhPyMDGQLZNdu.foSRcEqSuRsWnadDiKcGnhBewOU)
					{
						buttonStateFlags |= ButtonStateFlags.AgsjzxPUGELGeHFAPrimMZoZTDX;
						if (!pSOrqGXeVSwcLrIhPyMDGQLZNdu.lpYFNtKbgvQlXkTOFBiOFvFHrsdB)
						{
							buttonStateFlags |= ButtonStateFlags.hETjdkpgSiFPkwdEDdKSivclaArr;
						}
					}
					else if (pSOrqGXeVSwcLrIhPyMDGQLZNdu.lpYFNtKbgvQlXkTOFBiOFvFHrsdB)
					{
						buttonStateFlags |= ButtonStateFlags.KCDWeODdPSdTyfVHhGgQWADLelYa;
					}
					return buttonStateFlags;
				}
			}

			internal Button(Controller controller, int elementIdentifierId, string name, HardwareButtonInfo buttonInfo)
				: base(controller, elementIdentifierId, name, ControllerElementType.Button)
			{
				jpkJjXWhMrgUwNmqszFLtsuhiPR = buttonInfo;
				zbsfnsAJkRolPwAdMvMYhQprRpq = new YkHolmvylQOvJPxxsDndJugzgiP(ReInput.configVars.updateLoop, isPressureSensitive: false);
			}

			internal Button(Controller controller, int elementIdentifierId, string name, bool isPressureSensitive, HardwareButtonInfo buttonInfo)
				: base(controller, elementIdentifierId, name, ControllerElementType.Button)
			{
				jpkJjXWhMrgUwNmqszFLtsuhiPR = buttonInfo;
				oHmFyMLXhcgyxcsDcMAFAkFKvCur = isPressureSensitive;
				zbsfnsAJkRolPwAdMvMYhQprRpq = new YkHolmvylQOvJPxxsDndJugzgiP(ReInput.configVars.updateLoop, isPressureSensitive);
			}

			public bool DoublePressedAndHeld(float speed)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return false;
				}
				if (speed <= 0f)
				{
					return ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).yLQKpqqYhcHlHpqQzCZpAaoKNvQE.iBGQhhKyEtmNYjqNNGqwPkYNvlD;
				}
				return ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).zUCDvuoEzhgDmeWZRUEiGITIqmMw.yChIKcUhAwgJsFSlfSAxNTKaPUB(speed);
			}

			public bool JustDoublePressed(float speed)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return false;
				}
				if (!justPressed)
				{
					return false;
				}
				if (speed <= 0f)
				{
					return ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).yLQKpqqYhcHlHpqQzCZpAaoKNvQE.iBGQhhKyEtmNYjqNNGqwPkYNvlD;
				}
				return ((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).zUCDvuoEzhgDmeWZRUEiGITIqmMw.yChIKcUhAwgJsFSlfSAxNTKaPUB(speed);
			}

			internal void wAlHJoEseXwZfahDSIeyAibjNOI(UpdateLoopType P_0, int P_1, ControllerDataUpdater P_2)
			{
				if (zbsfnsAJkRolPwAdMvMYhQprRpq != null && zbsfnsAJkRolPwAdMvMYhQprRpq.pGdFhtIDBujVREblgTVumQrDDssM != (int)P_0)
				{
					zbsfnsAJkRolPwAdMvMYhQprRpq.EtMuBRTmVzCBLcuxYRMlwUqRdAzD = P_0;
				}
				if (oHmFyMLXhcgyxcsDcMAFAkFKvCur)
				{
					((YkHolmvylQOvJPxxsDndJugzgiP.RTxiEfjpFtbDpCatHTRiDxNDOxGQ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).wAlHJoEseXwZfahDSIeyAibjNOI(P_2.buttonPressureValues[P_1]);
				}
				else
				{
					((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).wAlHJoEseXwZfahDSIeyAibjNOI(P_2.buttonValues[P_1]);
				}
			}

			internal void tXBDUGspriIOhAnxpjFFvoODmDY(UpdateLoopType P_0)
			{
				if (zbsfnsAJkRolPwAdMvMYhQprRpq != null && zbsfnsAJkRolPwAdMvMYhQprRpq.pGdFhtIDBujVREblgTVumQrDDssM != (int)P_0)
				{
					zbsfnsAJkRolPwAdMvMYhQprRpq.EtMuBRTmVzCBLcuxYRMlwUqRdAzD = P_0;
				}
				if (oHmFyMLXhcgyxcsDcMAFAkFKvCur)
				{
					((YkHolmvylQOvJPxxsDndJugzgiP.RTxiEfjpFtbDpCatHTRiDxNDOxGQ)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).wAlHJoEseXwZfahDSIeyAibjNOI(0f);
				}
				else
				{
					((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)zbsfnsAJkRolPwAdMvMYhQprRpq.HBFpvdVSEToPvyDvjayPiQyuurNQ).wAlHJoEseXwZfahDSIeyAibjNOI(false);
				}
			}

			internal void ztVSpWDZIZxAEYGNFDunZGMouOU()
			{
				for (int i = 0; i < zbsfnsAJkRolPwAdMvMYhQprRpq.MDVkhUEPGquMkUMaxUdVywzYhJG.Count; i++)
				{
					KBYdAfHcKWiFmvdIcfykIcVEkgs.eAixhNvRHPeuTjlTixcbWImRSnv eAixhNvRHPeuTjlTixcbWImRSnv = zbsfnsAJkRolPwAdMvMYhQprRpq.MDVkhUEPGquMkUMaxUdVywzYhJG[i];
					if (eAixhNvRHPeuTjlTixcbWImRSnv != null)
					{
						if (oHmFyMLXhcgyxcsDcMAFAkFKvCur)
						{
							((YkHolmvylQOvJPxxsDndJugzgiP.RTxiEfjpFtbDpCatHTRiDxNDOxGQ)eAixhNvRHPeuTjlTixcbWImRSnv).wAlHJoEseXwZfahDSIeyAibjNOI(0f);
						}
						else
						{
							((YkHolmvylQOvJPxxsDndJugzgiP.pSOrqGXeVSwcLrIhPyMDGQLZNdu)eAixhNvRHPeuTjlTixcbWImRSnv).wAlHJoEseXwZfahDSIeyAibjNOI(false);
						}
					}
				}
			}
		}

		public abstract class CompoundElement
		{
			private class HnkRWcmSwzbtYcCWMsJqYyzQMbR
			{
				public readonly Element ZFRkhXzoHYMYgVeQssKqOHKOPMF;

				public readonly int wkTGWLXdweLqZjigTyvMxxKxDvp;

				public HnkRWcmSwzbtYcCWMsJqYyzQMbR(Element element, int elementIndex)
				{
					ZFRkhXzoHYMYgVeQssKqOHKOPMF = element;
					wkTGWLXdweLqZjigTyvMxxKxDvp = elementIndex;
				}
			}

			private int AlqqKkRsWUkTOzkmxGfVDUZYXTSf;

			private string cdTetXhABLRmOQUvcmFAFXpBMHcj;

			private CompoundControllerElementType YApegNposatXaqxKKfTqnMxXGsJ;

			private int eSxFvCIaFVWYtzmhOMscPCVRyik;

			private HnkRWcmSwzbtYcCWMsJqYyzQMbR[] bcDhYTWaaaoMHhMjJexfmEnUBLh;

			private Controller bGNJaBTbykivsIWbGpkIOAQalRn;

			internal readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

			public int id
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return -1;
					}
					return AlqqKkRsWUkTOzkmxGfVDUZYXTSf;
				}
			}

			public string name
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return string.Empty;
					}
					return cdTetXhABLRmOQUvcmFAFXpBMHcj;
				}
			}

			public CompoundControllerElementType type
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return CompoundControllerElementType.Axis2D;
					}
					return YApegNposatXaqxKKfTqnMxXGsJ;
				}
			}

			public bool hasElements
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return eSxFvCIaFVWYtzmhOMscPCVRyik > 0;
				}
			}

			public int elementCount
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					return eSxFvCIaFVWYtzmhOMscPCVRyik;
				}
			}

			public abstract int elementCapacity { get; }

			public ControllerElementIdentifier elementIdentifier
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					ControllerElementIdentifier elementIdentifierById = bGNJaBTbykivsIWbGpkIOAQalRn.GetElementIdentifierById(AlqqKkRsWUkTOzkmxGfVDUZYXTSf);
					if (elementIdentifierById == null)
					{
						return ControllerElementIdentifier.BlankReadOnly;
					}
					return elementIdentifierById;
				}
			}

			internal CompoundElement(Controller controller, int elementIdentifierId, string name, CompoundControllerElementType type)
			{
				bGNJaBTbykivsIWbGpkIOAQalRn = controller;
				AlqqKkRsWUkTOzkmxGfVDUZYXTSf = elementIdentifierId;
				cdTetXhABLRmOQUvcmFAFXpBMHcj = name;
				YApegNposatXaqxKKfTqnMxXGsJ = type;
				bcDhYTWaaaoMHhMjJexfmEnUBLh = new HnkRWcmSwzbtYcCWMsJqYyzQMbR[elementCapacity];
				PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
			}

			internal Element eCWODyubZajVwOmkGSFXlCGBdhT(int P_0)
			{
				if (P_0 < 0 || P_0 >= bcDhYTWaaaoMHhMjJexfmEnUBLh.Length)
				{
					return null;
				}
				if (bcDhYTWaaaoMHhMjJexfmEnUBLh[P_0] == null)
				{
					return null;
				}
				return bcDhYTWaaaoMHhMjJexfmEnUBLh[P_0].ZFRkhXzoHYMYgVeQssKqOHKOPMF;
			}

			internal T eCWODyubZajVwOmkGSFXlCGBdhT<T>(int P_0) where T : Element
			{
				if (P_0 < 0 || P_0 >= bcDhYTWaaaoMHhMjJexfmEnUBLh.Length)
				{
					return null;
				}
				if (bcDhYTWaaaoMHhMjJexfmEnUBLh[P_0] == null)
				{
					return null;
				}
				return bcDhYTWaaaoMHhMjJexfmEnUBLh[P_0].ZFRkhXzoHYMYgVeQssKqOHKOPMF as T;
			}

			internal T owYalHvGTwImDVniHRAcGoAIbaq<T>(int P_0, out int P_1) where T : Element
			{
				P_1 = -1;
				if (P_0 < 0 || P_0 >= bcDhYTWaaaoMHhMjJexfmEnUBLh.Length)
				{
					return null;
				}
				if (bcDhYTWaaaoMHhMjJexfmEnUBLh[P_0] == null)
				{
					return null;
				}
				P_1 = bcDhYTWaaaoMHhMjJexfmEnUBLh[P_0].wkTGWLXdweLqZjigTyvMxxKxDvp;
				return bcDhYTWaaaoMHhMjJexfmEnUBLh[P_0].ZFRkhXzoHYMYgVeQssKqOHKOPMF as T;
			}

			internal bool WqsdoDpSvzDOWFFxuzffBuWiPsvG(Element P_0, int P_1)
			{
				if (P_0 == null)
				{
					return false;
				}
				if (eSxFvCIaFVWYtzmhOMscPCVRyik >= elementCapacity)
				{
					Logger.LogWarning("Cannot add element! This Compound Element already contains the maximum number of elements.");
					return false;
				}
				if (P_0.isMemberElement)
				{
					Logger.LogWarning("Cannot add element! The element you are trying to add is already a member of another compound element.");
					return false;
				}
				if (xiuIeYHJXYdmseVGSxINjvDbpKI(P_0) >= 0)
				{
					Logger.LogWarning("Cannot add element! This Compound Element already contains the element you are trying to add.");
					return false;
				}
				int num = BqaloIvcUtrKdZQwaEWNnLTuCzfD();
				if (num < 0)
				{
					Logger.LogWarning("Cannot add element! This Compound Element already contains the maximum number of elements.");
					return false;
				}
				return vsPJGVeQZfyQSKcaCsMhdabsgAce(P_0, P_1, num);
			}

			internal bool sqsAdtUQpaaJTRHHTyLaHoOmgAO(Element P_0)
			{
				if (P_0 == null)
				{
					return false;
				}
				if (eSxFvCIaFVWYtzmhOMscPCVRyik == 0)
				{
					Logger.LogWarning("Cannot remove element! This Compound Element has no elements.");
					return false;
				}
				int num = xiuIeYHJXYdmseVGSxINjvDbpKI(P_0);
				if (num < 0)
				{
					Logger.LogWarning("Cannot remove element! This Compound Element does not contain the element you are trying to remove.");
					return false;
				}
				return WYdJeQDpOHCfdtyKinDJbLYRBJQ(num);
			}

			internal void qrjhfqVSkUSVcnssLaMOIvSBmDk()
			{
				for (int i = 0; i < bcDhYTWaaaoMHhMjJexfmEnUBLh.Length; i++)
				{
					WYdJeQDpOHCfdtyKinDJbLYRBJQ(i);
				}
				eSxFvCIaFVWYtzmhOMscPCVRyik = 0;
			}

			private int xiuIeYHJXYdmseVGSxINjvDbpKI(Element P_0)
			{
				if (P_0 == null)
				{
					return -1;
				}
				for (int i = 0; i < bcDhYTWaaaoMHhMjJexfmEnUBLh.Length; i++)
				{
					if (bcDhYTWaaaoMHhMjJexfmEnUBLh[i] != null && bcDhYTWaaaoMHhMjJexfmEnUBLh[i].ZFRkhXzoHYMYgVeQssKqOHKOPMF == P_0)
					{
						return i;
					}
				}
				return -1;
			}

			private bool vsPJGVeQZfyQSKcaCsMhdabsgAce(Element P_0, int P_1, int P_2)
			{
				if (P_2 < 0 || P_2 >= bcDhYTWaaaoMHhMjJexfmEnUBLh.Length)
				{
					return false;
				}
				if (bcDhYTWaaaoMHhMjJexfmEnUBLh[P_2] != null)
				{
					return false;
				}
				bcDhYTWaaaoMHhMjJexfmEnUBLh[P_2] = new HnkRWcmSwzbtYcCWMsJqYyzQMbR(P_0, P_1);
				P_0.hhGKGEblUMtTggBzIpPjixaHjCt();
				eSxFvCIaFVWYtzmhOMscPCVRyik++;
				return true;
			}

			private bool WYdJeQDpOHCfdtyKinDJbLYRBJQ(int P_0)
			{
				if (P_0 < 0 || P_0 >= bcDhYTWaaaoMHhMjJexfmEnUBLh.Length)
				{
					return false;
				}
				if (bcDhYTWaaaoMHhMjJexfmEnUBLh[P_0] == null)
				{
					return false;
				}
				if (bcDhYTWaaaoMHhMjJexfmEnUBLh[P_0].ZFRkhXzoHYMYgVeQssKqOHKOPMF != null)
				{
					bcDhYTWaaaoMHhMjJexfmEnUBLh[P_0].ZFRkhXzoHYMYgVeQssKqOHKOPMF.IqktjVrJMgvQKxPIJcyWVwklARwF();
				}
				bcDhYTWaaaoMHhMjJexfmEnUBLh[P_0] = null;
				eSxFvCIaFVWYtzmhOMscPCVRyik--;
				return true;
			}

			private int BqaloIvcUtrKdZQwaEWNnLTuCzfD()
			{
				for (int i = 0; i < bcDhYTWaaaoMHhMjJexfmEnUBLh.Length; i++)
				{
					if (bcDhYTWaaaoMHhMjJexfmEnUBLh[i] == null)
					{
						return i;
					}
				}
				return -1;
			}
		}

		public sealed class Axis2D : CompoundElement
		{
			private const int aNCVTZIsgcQXcGQldHSNmbtlcsP = 2;

			private CalibrationMap VEknRZqjHudUWXtswOXkXdOGQpu;

			public override int elementCapacity => 2;

			public Axis xAxis
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return eCWODyubZajVwOmkGSFXlCGBdhT<Axis>(0);
				}
			}

			public Axis yAxis
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return eCWODyubZajVwOmkGSFXlCGBdhT<Axis>(1);
				}
			}

			public Vector2 value
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return Vector2.zero;
					}
					return EwBUPvPpuvgnTgWKsEOdQFugqnuF();
				}
			}

			public Vector2 valuePrev
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return Vector2.zero;
					}
					return GtuNzGRxkXVzhqoYxzeNmeFsbAH();
				}
			}

			public Vector2 valueRaw
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return Vector2.zero;
					}
					return new Vector2((xAxis != null) ? xAxis.valueRaw : 0f, (yAxis != null) ? yAxis.valueRaw : 0f);
				}
			}

			public Vector2 valueRawPrev
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return Vector2.zero;
					}
					return new Vector2((xAxis != null) ? xAxis.valueRawPrev : 0f, (yAxis != null) ? yAxis.valueRawPrev : 0f);
				}
			}

			internal Axis2D(Controller controller, int elementIdentifierId, string name, Axis xAxis, Axis yAxis, int xAxisIndex, int yAxisIndex, CalibrationMap calibratonMap)
				: base(controller, elementIdentifierId, name, CompoundControllerElementType.Axis2D)
			{
				WqsdoDpSvzDOWFFxuzffBuWiPsvG(xAxis, xAxisIndex);
				WqsdoDpSvzDOWFFxuzffBuWiPsvG(yAxis, yAxisIndex);
				VEknRZqjHudUWXtswOXkXdOGQpu = calibratonMap;
			}

			internal void DAJzqdfwzCTZStXkEMKmKOxyqdV()
			{
				Vector2 vector = value;
				if (xAxis != null)
				{
					xAxis.cgscnucQbaoRzaJPFWXGEFQhOgGG(vector.x);
				}
				if (yAxis != null)
				{
					yAxis.cgscnucQbaoRzaJPFWXGEFQhOgGG(vector.y);
				}
			}

			private Vector2 EwBUPvPpuvgnTgWKsEOdQFugqnuF()
			{
				if (VEknRZqjHudUWXtswOXkXdOGQpu == null)
				{
					return default(Vector2);
				}
				int xAxisIndex;
				Axis axis = owYalHvGTwImDVniHRAcGoAIbaq<Axis>(0, out xAxisIndex);
				int yAxisIndex;
				Axis axis2 = owYalHvGTwImDVniHRAcGoAIbaq<Axis>(1, out yAxisIndex);
				DeadZone2DType defaultJoystickAxis2DDeadZoneType = ReInput.configVars.defaultJoystickAxis2DDeadZoneType;
				AxisSensitivity2DType defaultJoystickAxis2DSensitivityType = ReInput.configVars.defaultJoystickAxis2DSensitivityType;
				float valueRawX = axis?.valueRaw ?? 0f;
				float valueRawY = axis2?.valueRaw ?? 0f;
				return VEknRZqjHudUWXtswOXkXdOGQpu.GetCalibrated2DValue(xAxisIndex, yAxisIndex, valueRawX, valueRawY, defaultJoystickAxis2DDeadZoneType, defaultJoystickAxis2DSensitivityType);
			}

			private Vector2 GtuNzGRxkXVzhqoYxzeNmeFsbAH()
			{
				if (VEknRZqjHudUWXtswOXkXdOGQpu == null)
				{
					return default(Vector2);
				}
				int xAxisIndex;
				Axis axis = owYalHvGTwImDVniHRAcGoAIbaq<Axis>(0, out xAxisIndex);
				int yAxisIndex;
				Axis axis2 = owYalHvGTwImDVniHRAcGoAIbaq<Axis>(1, out yAxisIndex);
				DeadZone2DType defaultJoystickAxis2DDeadZoneType = ReInput.configVars.defaultJoystickAxis2DDeadZoneType;
				AxisSensitivity2DType defaultJoystickAxis2DSensitivityType = ReInput.configVars.defaultJoystickAxis2DSensitivityType;
				float valueRawX = axis?.valueRawPrev ?? 0f;
				float valueRawY = axis2?.valueRawPrev ?? 0f;
				return VEknRZqjHudUWXtswOXkXdOGQpu.GetCalibrated2DValue(xAxisIndex, yAxisIndex, valueRawX, valueRawY, defaultJoystickAxis2DDeadZoneType, defaultJoystickAxis2DSensitivityType);
			}
		}

		public sealed class Hat : CompoundElement
		{
			private const int aNCVTZIsgcQXcGQldHSNmbtlcsP = 8;

			private const int TPCTZkgaZdHJFsTsymJSWrkqdbc = 0;

			private const int kXECqBEBuVTdYIqzYqmNfnkYoSTj = 1;

			private const int HETMbqlLVONuTWmXgDRIGOmXHlT = 2;

			private const int gFDjeRnNIezDNHfuoMokcsgjvMd = 3;

			private const int JGlqIZTnSZnyejUawAmkosEyqvT = 4;

			private const int ZFhFYoghwmljKmTSTvOxoMOjNcXc = 5;

			private const int BTDcdDboyiFvuclJYThpeJSDRZr = 6;

			private const int mYdpjxwBEQpacVgRnLtQUIHWBqLG = 7;

			private readonly int HUrvKXNmSdRrTKWEwIovQAsSEipJ;

			private readonly Button[] XMmeKfLALLiqakhkZdFxAjspFgaC;

			private readonly ReadOnlyCollection<Button> oXqzizEdxEdsfrnwesnubHkgDFW;

			private readonly int[] zEVLWXFuxJbIxlWzToEwbyuGwce;

			private bool PaQnCULxqDucMvoDZZnfRdtXmLX;

			public override int elementCapacity => 8;

			public bool force4Way
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return PaQnCULxqDucMvoDZZnfRdtXmLX;
				}
				set
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						PaQnCULxqDucMvoDZZnfRdtXmLX = value;
					}
				}
			}

			public int directionCount
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					return HUrvKXNmSdRrTKWEwIovQAsSEipJ;
				}
			}

			public IList<Button> Buttons
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<Button>.EmptyReadOnlyIListT;
					}
					return oXqzizEdxEdsfrnwesnubHkgDFW;
				}
			}

			public Button buttonUp
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return eCWODyubZajVwOmkGSFXlCGBdhT<Button>(0);
				}
			}

			public Button buttonRight
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return eCWODyubZajVwOmkGSFXlCGBdhT<Button>(2);
				}
			}

			public Button buttonDown
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return eCWODyubZajVwOmkGSFXlCGBdhT<Button>(4);
				}
			}

			public Button buttonLeft
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return eCWODyubZajVwOmkGSFXlCGBdhT<Button>(6);
				}
			}

			public Button buttonUpRight
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return eCWODyubZajVwOmkGSFXlCGBdhT<Button>(1);
				}
			}

			public Button buttonDownRight
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return eCWODyubZajVwOmkGSFXlCGBdhT<Button>(3);
				}
			}

			public Button buttonDownLeft
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return eCWODyubZajVwOmkGSFXlCGBdhT<Button>(5);
				}
			}

			public Button buttonUpLeft
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return eCWODyubZajVwOmkGSFXlCGBdhT<Button>(7);
				}
			}

			internal Hat(Controller controller, int elementIdentifierId, string name, Button[] buttons, int[] buttonIndices)
				: base(controller, elementIdentifierId, name, CompoundControllerElementType.Hat)
			{
				int num = ((buttons != null) ? buttons.Length : 0);
				if (num != ((buttonIndices != null) ? buttonIndices.Length : 0))
				{
					throw new ArgumentException("button.Length must equal buttonIndices.Length!");
				}
				if (num != 0 && num != 4 && num != 8)
				{
					throw new ArgumentException("button.Length must be 0, 4, or 8! Length: " + num);
				}
				for (int i = 0; i < num; i++)
				{
					WqsdoDpSvzDOWFFxuzffBuWiPsvG(buttons[i], buttonIndices[i]);
				}
				XMmeKfLALLiqakhkZdFxAjspFgaC = buttons;
				zEVLWXFuxJbIxlWzToEwbyuGwce = buttonIndices;
				HUrvKXNmSdRrTKWEwIovQAsSEipJ = num;
				oXqzizEdxEdsfrnwesnubHkgDFW = new ReadOnlyCollection<Button>(buttons);
			}

			internal void DAJzqdfwzCTZStXkEMKmKOxyqdV(UpdateLoopType P_0, ControllerDataUpdater P_1)
			{
				if (HUrvKXNmSdRrTKWEwIovQAsSEipJ == 0)
				{
					return;
				}
				if (HUrvKXNmSdRrTKWEwIovQAsSEipJ == 8 && (PaQnCULxqDucMvoDZZnfRdtXmLX || ReInput.configVars.force4WayHats))
				{
					eJCUnUfELREBRFIsQXxSuSXneMj(XMmeKfLALLiqakhkZdFxAjspFgaC[0], zEVLWXFuxJbIxlWzToEwbyuGwce[0], zEVLWXFuxJbIxlWzToEwbyuGwce[7], zEVLWXFuxJbIxlWzToEwbyuGwce[1], P_0, P_1);
					eJCUnUfELREBRFIsQXxSuSXneMj(XMmeKfLALLiqakhkZdFxAjspFgaC[2], zEVLWXFuxJbIxlWzToEwbyuGwce[2], zEVLWXFuxJbIxlWzToEwbyuGwce[1], zEVLWXFuxJbIxlWzToEwbyuGwce[3], P_0, P_1);
					eJCUnUfELREBRFIsQXxSuSXneMj(XMmeKfLALLiqakhkZdFxAjspFgaC[4], zEVLWXFuxJbIxlWzToEwbyuGwce[4], zEVLWXFuxJbIxlWzToEwbyuGwce[5], zEVLWXFuxJbIxlWzToEwbyuGwce[3], P_0, P_1);
					eJCUnUfELREBRFIsQXxSuSXneMj(XMmeKfLALLiqakhkZdFxAjspFgaC[6], zEVLWXFuxJbIxlWzToEwbyuGwce[6], zEVLWXFuxJbIxlWzToEwbyuGwce[5], zEVLWXFuxJbIxlWzToEwbyuGwce[7], P_0, P_1);
					zXSZrIvXAePHEfyyoBXgyGQXIAA(XMmeKfLALLiqakhkZdFxAjspFgaC[1], zEVLWXFuxJbIxlWzToEwbyuGwce[1], P_0, P_1);
					zXSZrIvXAePHEfyyoBXgyGQXIAA(XMmeKfLALLiqakhkZdFxAjspFgaC[3], zEVLWXFuxJbIxlWzToEwbyuGwce[3], P_0, P_1);
					zXSZrIvXAePHEfyyoBXgyGQXIAA(XMmeKfLALLiqakhkZdFxAjspFgaC[5], zEVLWXFuxJbIxlWzToEwbyuGwce[5], P_0, P_1);
					zXSZrIvXAePHEfyyoBXgyGQXIAA(XMmeKfLALLiqakhkZdFxAjspFgaC[7], zEVLWXFuxJbIxlWzToEwbyuGwce[7], P_0, P_1);
					return;
				}
				for (int i = 0; i < XMmeKfLALLiqakhkZdFxAjspFgaC.Length; i++)
				{
					if (XMmeKfLALLiqakhkZdFxAjspFgaC[i] != null)
					{
						XMmeKfLALLiqakhkZdFxAjspFgaC[i].wAlHJoEseXwZfahDSIeyAibjNOI(P_0, zEVLWXFuxJbIxlWzToEwbyuGwce[i], P_1);
					}
				}
			}

			private void eJCUnUfELREBRFIsQXxSuSXneMj(Button P_0, int P_1, int P_2, int P_3, UpdateLoopType P_4, ControllerDataUpdater P_5)
			{
				if (P_0 == null || P_1 < 0 || P_1 >= P_5.buttonCount)
				{
					return;
				}
				if (!P_0.isPressureSensitive)
				{
					if (P_2 >= 0 && P_2 < P_5.buttonCount)
					{
						ref bool reference = ref P_5.buttonValues[P_1];
						reference |= P_5.buttonValues[P_2];
					}
					if (P_3 >= 0 && P_3 < P_5.buttonCount)
					{
						ref bool reference2 = ref P_5.buttonValues[P_1];
						reference2 |= P_5.buttonValues[P_3];
					}
				}
				else
				{
					P_5.buttonPressureValues[P_1] = MathTools.MaxMagnitude(P_5.buttonPressureValues[P_1], MathTools.MaxMagnitude((P_2 >= 0 && P_2 < P_5.buttonCount) ? P_5.buttonPressureValues[P_2] : 0f, (P_3 >= 0 && P_3 < P_5.buttonCount) ? P_5.buttonPressureValues[P_3] : 0f));
				}
				P_0.wAlHJoEseXwZfahDSIeyAibjNOI(P_4, P_1, P_5);
			}

			private void zXSZrIvXAePHEfyyoBXgyGQXIAA(Button P_0, int P_1, UpdateLoopType P_2, ControllerDataUpdater P_3)
			{
				if (P_0 != null && P_1 >= 0 && P_1 < P_3.buttonCount)
				{
					if (!P_0.isPressureSensitive)
					{
						P_3.buttonValues[P_1] = false;
					}
					else
					{
						P_3.buttonPressureValues[P_1] = 0f;
					}
					P_0.wAlHJoEseXwZfahDSIeyAibjNOI(P_2, P_1, P_3);
				}
			}
		}

		[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
		public abstract class Extension
		{
			private Controller bGNJaBTbykivsIWbGpkIOAQalRn;

			private IControllerExtensionSource ptgshdhzmBqmpwQkacMBSGAyXPI;

			internal readonly int _reInputId;

			internal bool isJoystickConnected
			{
				get
				{
					if (bGNJaBTbykivsIWbGpkIOAQalRn == null)
					{
						return false;
					}
					return bGNJaBTbykivsIWbGpkIOAQalRn._isConnected;
				}
			}

			internal bool enabled
			{
				get
				{
					if (bGNJaBTbykivsIWbGpkIOAQalRn == null)
					{
						return false;
					}
					return bGNJaBTbykivsIWbGpkIOAQalRn.enabled;
				}
			}

			internal Controller controller => bGNJaBTbykivsIWbGpkIOAQalRn;

			internal Extension(IControllerExtensionSource source)
			{
				_reInputId = ReInput.id;
				PYICEfcrFuXJGSyJZkffmqrFbmx(source);
			}

			internal Extension(Extension source)
				: this(source.ptgshdhzmBqmpwQkacMBSGAyXPI)
			{
				bGNJaBTbykivsIWbGpkIOAQalRn = source.bGNJaBTbykivsIWbGpkIOAQalRn;
			}

			internal T GetController<T>() where T : Controller
			{
				if (bGNJaBTbykivsIWbGpkIOAQalRn == null)
				{
					return null;
				}
				return bGNJaBTbykivsIWbGpkIOAQalRn as T;
			}

			internal void SetController(Controller controller)
			{
				bGNJaBTbykivsIWbGpkIOAQalRn = controller;
			}

			[CustomObfuscation(rename = false)]
			internal IControllerExtensionSource GetSource()
			{
				return ptgshdhzmBqmpwQkacMBSGAyXPI;
			}

			internal void SetSource(Extension extension)
			{
				if (extension == null)
				{
					PYICEfcrFuXJGSyJZkffmqrFbmx(null);
				}
				else
				{
					PYICEfcrFuXJGSyJZkffmqrFbmx(extension.ptgshdhzmBqmpwQkacMBSGAyXPI);
				}
			}

			private void PYICEfcrFuXJGSyJZkffmqrFbmx(IControllerExtensionSource P_0)
			{
				ptgshdhzmBqmpwQkacMBSGAyXPI = P_0;
				SourceUpdated(ptgshdhzmBqmpwQkacMBSGAyXPI);
			}

			internal virtual void Clear()
			{
			}

			internal abstract void SourceUpdated(IControllerExtensionSource source);

			internal abstract void UpdateData(UpdateLoopType updateLoop);

			internal abstract Extension Clone();
		}

		public readonly int id;

		protected string _tag;

		protected string _name;

		protected string _hardwareName;

		protected readonly ControllerType _type;

		internal readonly Guid cBbvDblDdxYvWIffImKZKlfGJPE;

		protected string _hardwareIdentifier;

		protected bool _isConnected;

		private Extension hmZLUQBpfeonCDoNcFmKCFWkaEcl;

		private bool nZTtfeZBpthDaoAvSONdTABGEaM;

		private ControllerIdentifier MsGRamKVRmsUleoYZBsCMAZYFCyH;

		internal int PivQvdYMhUssuLwaglJVqkqXMSH;

		protected readonly int _buttonCount;

		protected readonly Button[] buttons;

		protected readonly ReadOnlyCollection<Button> buttons_readOnly;

		private readonly IList<Element> uGpQQIwzyDgccAzdMieIrottQjF;

		private readonly ReadOnlyCollection<Element> EZanZBVAuiJIOisjNsKtlblpPjs;

		internal readonly InputSource qhnYJqFPpPHTJjpxtkZKYxgPeLP;

		internal readonly ControllerDataUpdater OcGEaRzMecIeBFudxFTOaknZTFKe;

		internal readonly HardwareControllerMap_Game pAhzhvigFoLFbwPDdcXHatZWRIl;

		internal uint hdlXHnMdOyFNotPPXhituOoybdv;

		private uint nczBdUdIexqtVbaEsPLiAZaEElvH;

		private uint mdtFXWdkANKNkHoDHpGMZoJNbZtD;

		private Action<bool> hymBvkFHtIvcnukoWkIwFfGCkitK;

		private IControllerTemplate[] AmPOkKVbACVczDcMNTllKyDLTPy;

		private ReadOnlyCollection<IControllerTemplate> EmLCLNZSPmrenxnbKQDtMquhiAL;

		private static Func<Controller, Guid, bool> dimdxHNHDtVuhPHuacDxdDfWaQec;

		private static Func<Controller, Type, bool> qnWhIeWsMQzPZxLyQuahmHVOLgH;

		[CompilerGenerated]
		private static Func<Controller, Guid, bool> gTYRrCnrkVCmudsUsPBUUohWrzM;

		[CompilerGenerated]
		private static Func<Controller, Type, bool> zBhuNuuEsfwsipThsXHBQeslDqD;

		internal bool wasPollingPrev => nczBdUdIexqtVbaEsPLiAZaEElvH == ReInput.previousFrame;

		public bool enabled
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return false;
				}
				return nZTtfeZBpthDaoAvSONdTABGEaM;
			}
			set
			{
				GVPaGnImiZihtbyndAIXuQVGSLHA(value);
			}
		}

		public string name
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return string.Empty;
				}
				return _name;
			}
			internal set
			{
				_name = value;
			}
		}

		public string tag
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return string.Empty;
				}
				return _tag;
			}
			set
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					_tag = value;
				}
			}
		}

		public string hardwareName
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return string.Empty;
				}
				return _hardwareName;
			}
		}

		public ControllerType type
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return ControllerType.Keyboard;
				}
				return _type;
			}
		}

		public Guid hardwareTypeGuid
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return Guid.Empty;
				}
				return cBbvDblDdxYvWIffImKZKlfGJPE;
			}
		}

		public abstract Guid deviceInstanceGuid { get; }

		public ControllerIdentifier identifier => MsGRamKVRmsUleoYZBsCMAZYFCyH;

		public bool isConnected
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return false;
				}
				return _isConnected;
			}
			internal set
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else if (!value)
				{
					Disconnected();
				}
				else
				{
					Connected();
				}
			}
		}

		public string hardwareIdentifier
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return string.Empty;
				}
				return _hardwareIdentifier;
			}
		}

		public string mapTypeString => _type.ToString() + "Map";

		public int elementCount
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0;
				}
				return uGpQQIwzyDgccAzdMieIrottQjF.Count;
			}
		}

		public int buttonCount
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0;
				}
				return _buttonCount;
			}
		}

		public IList<Element> Elements
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return EmptyObjects<Element>.EmptyReadOnlyIListT;
				}
				return EZanZBVAuiJIOisjNsKtlblpPjs;
			}
		}

		public IList<Button> Buttons
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return EmptyObjects<Button>.EmptyReadOnlyIListT;
				}
				return buttons_readOnly;
			}
		}

		public Extension extension
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return hmZLUQBpfeonCDoNcFmKCFWkaEcl;
			}
		}

		public IList<ControllerElementIdentifier> ElementIdentifiers
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return EmptyObjects<ControllerElementIdentifier>.EmptyReadOnlyIListT;
				}
				return pAhzhvigFoLFbwPDdcXHatZWRIl.elementIdentifiers_readOnly;
			}
		}

		public IList<ControllerElementIdentifier> ButtonElementIdentifiers
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return EmptyObjects<ControllerElementIdentifier>.EmptyReadOnlyIListT;
				}
				return pAhzhvigFoLFbwPDdcXHatZWRIl.buttonElementIdentifiers_readOnly;
			}
		}

		public IList<IControllerTemplate> Templates
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return EmptyObjects<IControllerTemplate>.EmptyReadOnlyIListT;
				}
				return EmLCLNZSPmrenxnbKQDtMquhiAL;
			}
		}

		public int templateCount
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0;
				}
				return AmPOkKVbACVczDcMNTllKyDLTPy.Length;
			}
		}

		internal static Func<Controller, Guid, bool> implementsTemplateDelegate_Guid => (Controller P_0, Guid P_1) => P_0.ImplementsTemplate(P_1);

		internal static Func<Controller, Type, bool> implementsTemplateDelegate_Type => (Controller P_0, Type P_1) => P_0.ImplementsTemplate(P_1);

		internal event Action<bool> EnabledStateChangedEvent
		{
			add
			{
				hymBvkFHtIvcnukoWkIwFfGCkitK = (Action<bool>)Delegate.Combine(hymBvkFHtIvcnukoWkIwFfGCkitK, value);
			}
			remove
			{
				hymBvkFHtIvcnukoWkIwFfGCkitK = (Action<bool>)Delegate.Remove(hymBvkFHtIvcnukoWkIwFfGCkitK, value);
			}
		}

		internal Controller(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, ControllerType type, Guid hardwareTypeGuid, int buttonCount, bool[] isButtonPressureSensitive, HardwareButtonInfo[] hwButtonInfo, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater)
		{
			id = controllerId;
			qhnYJqFPpPHTJjpxtkZKYxgPeLP = inputSource;
			_type = type;
			cBbvDblDdxYvWIffImKZKlfGJPE = hardwareTypeGuid;
			_buttonCount = buttonCount;
			_name = name;
			_hardwareName = hardwareName;
			_hardwareIdentifier = hardwareIdentifier;
			OcGEaRzMecIeBFudxFTOaknZTFKe = dataUpdater;
			pAhzhvigFoLFbwPDdcXHatZWRIl = hardwareMap;
			nZTtfeZBpthDaoAvSONdTABGEaM = true;
			PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
			EyudLnaJxSCTjRsYXBQCHZHZVXjs(extension);
			uGpQQIwzyDgccAzdMieIrottQjF = new List<Element>(buttonCount);
			EZanZBVAuiJIOisjNsKtlblpPjs = new ReadOnlyCollection<Element>(uGpQQIwzyDgccAzdMieIrottQjF);
			buttons = new Button[buttonCount];
			if (isButtonPressureSensitive == null || isButtonPressureSensitive.Length < buttonCount)
			{
				for (int i = 0; i < buttonCount; i++)
				{
					buttons[i] = new Button(this, hardwareMap.buttonElementIdentifierIds[i], "Button " + i, isPressureSensitive: false, (hwButtonInfo != null) ? hwButtonInfo[i] : new HardwareButtonInfo());
					WqsdoDpSvzDOWFFxuzffBuWiPsvG(buttons[i]);
				}
			}
			else
			{
				for (int j = 0; j < buttonCount; j++)
				{
					buttons[j] = new Button(this, hardwareMap.buttonElementIdentifierIds[j], "Button " + j, isButtonPressureSensitive[j], (hwButtonInfo != null) ? hwButtonInfo[j] : new HardwareButtonInfo());
					WqsdoDpSvzDOWFFxuzffBuWiPsvG(buttons[j]);
				}
			}
			buttons_readOnly = new ReadOnlyCollection<Button>(buttons);
			AmPOkKVbACVczDcMNTllKyDLTPy = EmptyObjects<IControllerTemplate>.array;
			EmLCLNZSPmrenxnbKQDtMquhiAL = new ReadOnlyCollection<IControllerTemplate>(AmPOkKVbACVczDcMNTllKyDLTPy);
			Connected();
		}

		internal virtual void GHVjMXbHizvmmwecacPaiHtKzHl()
		{
			MsGRamKVRmsUleoYZBsCMAZYFCyH = new ControllerIdentifier(this);
		}

		public virtual Element GetElementById(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			if (pAhzhvigFoLFbwPDdcXHatZWRIl == null)
			{
				return null;
			}
			int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
			if (buttonIndex < 0)
			{
				return null;
			}
			return buttons[buttonIndex];
		}

		public int GetButtonIndexById(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return -1;
			}
			return pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
		}

		public ControllerElementIdentifier GetElementIdentifierById(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			return pAhzhvigFoLFbwPDdcXHatZWRIl.GetElementIdentifierById(elementIdentifierId);
		}

		public virtual bool GetButton(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (index < 0 || index >= _buttonCount)
			{
				return false;
			}
			return buttons[index].value;
		}

		public virtual bool GetButtonDown(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (index < 0 || index >= _buttonCount)
			{
				return false;
			}
			return buttons[index].justPressed;
		}

		public virtual bool GetButtonUp(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (index < 0 || index >= _buttonCount)
			{
				return false;
			}
			return buttons[index].justReleased;
		}

		public virtual bool GetButtonChanged(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (index < 0 || index >= _buttonCount)
			{
				return false;
			}
			return buttons[index].value != buttons[index].valuePrev;
		}

		public virtual bool GetButtonPrev(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (index < 0 || index >= _buttonCount)
			{
				return false;
			}
			return buttons[index].valuePrev;
		}

		public virtual bool GetButtonDoublePressHold(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return GetButtonDoublePressHold(index, 0f);
		}

		public virtual bool GetButtonDoublePressHold(int index, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (index < 0 || index >= _buttonCount)
			{
				return false;
			}
			return buttons[index].DoublePressedAndHeld(speed);
		}

		public virtual bool GetButtonDoublePressDown(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return GetButtonDoublePressDown(index, 0f);
		}

		public virtual bool GetButtonDoublePressDown(int index, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (index < 0 || index >= _buttonCount)
			{
				return false;
			}
			return buttons[index].JustDoublePressed(speed);
		}

		public virtual double GetButtonTimePressed(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			if (index < 0 || index >= _buttonCount)
			{
				return 0.0;
			}
			return buttons[index].timePressed;
		}

		public virtual double GetButtonTimeUnpressed(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			if (index < 0 || index >= _buttonCount)
			{
				return 0.0;
			}
			return buttons[index].timeUnpressed;
		}

		public virtual double GetButtonLastTimePressed(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			if (index < 0 || index >= _buttonCount)
			{
				return 0.0;
			}
			return buttons[index].lastTimePressed;
		}

		public virtual double GetButtonLastTimeUnpressed(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			if (index < 0 || index >= _buttonCount)
			{
				return 0.0;
			}
			return buttons[index].lastTimeUnpressed;
		}

		public virtual bool GetAnyButton()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			for (int i = 0; i < _buttonCount; i++)
			{
				if (buttons[i].value)
				{
					return true;
				}
			}
			return false;
		}

		public virtual bool GetAnyButtonDown()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			for (int i = 0; i < _buttonCount; i++)
			{
				if (buttons[i].justPressed)
				{
					return true;
				}
			}
			return false;
		}

		public virtual bool GetAnyButtonUp()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			for (int i = 0; i < _buttonCount; i++)
			{
				if (buttons[i].justReleased)
				{
					return true;
				}
			}
			return false;
		}

		public virtual bool GetAnyButtonPrev()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			for (int i = 0; i < _buttonCount; i++)
			{
				if (buttons[i].valuePrev)
				{
					return true;
				}
			}
			return false;
		}

		public virtual bool GetAnyButtonChanged()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			for (int i = 0; i < _buttonCount; i++)
			{
				if (buttons[i].justChangedState)
				{
					return true;
				}
			}
			return false;
		}

		public virtual bool GetButtonById(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
			if (buttonIndex < 0 || buttonIndex >= _buttonCount)
			{
				return false;
			}
			return buttons[buttonIndex].value;
		}

		public virtual bool GetButtonDownById(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
			if (buttonIndex < 0 || buttonIndex >= _buttonCount)
			{
				return false;
			}
			return buttons[buttonIndex].justPressed;
		}

		public virtual bool GetButtonUpById(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
			if (buttonIndex < 0 || buttonIndex >= _buttonCount)
			{
				return false;
			}
			return buttons[buttonIndex].justReleased;
		}

		public virtual bool GetButtonDoublePressHoldById(int elementIdentifierId, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
			if (buttonIndex < 0 || buttonIndex >= _buttonCount)
			{
				return false;
			}
			return buttons[buttonIndex].DoublePressedAndHeld(speed);
		}

		public virtual bool GetButtonDoublePressDownById(int elementIdentifierId, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
			if (buttonIndex < 0 || buttonIndex >= _buttonCount)
			{
				return false;
			}
			return buttons[buttonIndex].JustDoublePressed(speed);
		}

		public virtual bool GetButtonDoublePressHoldById(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
			return GetButtonDoublePressHold(buttonIndex, 0f);
		}

		public virtual bool GetButtonDoublePressDownById(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
			return GetButtonDoublePressDown(buttonIndex, 0f);
		}

		public virtual bool GetButtonPrevById(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
			if (buttonIndex < 0 || buttonIndex >= _buttonCount)
			{
				return false;
			}
			return buttons[buttonIndex].valuePrev;
		}

		public virtual double GetButtonTimePressedById(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
			if (buttonIndex < 0 || buttonIndex >= _buttonCount)
			{
				return 0.0;
			}
			return buttons[buttonIndex].timePressed;
		}

		public virtual double GetButtonTimeUnpressedById(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
			if (buttonIndex < 0 || buttonIndex >= _buttonCount)
			{
				return 0.0;
			}
			return buttons[buttonIndex].timeUnpressed;
		}

		public virtual double GetButtonLastTimePressedById(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
			if (buttonIndex < 0 || buttonIndex >= _buttonCount)
			{
				return 0.0;
			}
			return buttons[buttonIndex].lastTimePressed;
		}

		public virtual double GetButtonLastTimeUnpressedById(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementIdentifierId);
			if (buttonIndex < 0 || buttonIndex >= _buttonCount)
			{
				return 0.0;
			}
			return buttons[buttonIndex].lastTimeUnpressed;
		}

		public virtual ControllerPollingInfo PollForFirstElement()
		{
			return PollForFirstButton();
		}

		public virtual ControllerPollingInfo PollForFirstElementDown()
		{
			return PollForFirstButtonDown();
		}

		public virtual ControllerPollingInfo PollForFirstButton()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
			}
			UpdatePollingFrameTracking();
			for (int i = 0; i < _buttonCount; i++)
			{
				if (dlfmEtpcAxJjZHipemsrzWJrwqV(i, out var elementIdentifierId))
				{
					return new ControllerPollingInfo(success: true, -1, id, _name, _type, ControllerElementType.Button, i, Pole.Positive, pAhzhvigFoLFbwPDdcXHatZWRIl.GetElementIdentifierName(elementIdentifierId), elementIdentifierId, KeyCode.None);
				}
			}
			return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
		}

		public virtual ControllerPollingInfo PollForFirstButtonDown()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
			}
			UpdatePollingFrameTracking();
			for (int i = 0; i < _buttonCount; i++)
			{
				if (fKomXZydfiajMJkmCCoyjsiyUGny(i, out var elementIdentifierId))
				{
					return new ControllerPollingInfo(success: true, -1, id, _name, _type, ControllerElementType.Button, i, Pole.Positive, pAhzhvigFoLFbwPDdcXHatZWRIl.GetElementIdentifierName(elementIdentifierId), elementIdentifierId, KeyCode.None);
				}
			}
			return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
		}

		public virtual IEnumerable<ControllerPollingInfo> PollForAllElements()
		{
			return PollForAllButtons();
		}

		public virtual IEnumerable<ControllerPollingInfo> PollForAllElementsDown()
		{
			return PollForAllButtonsDown();
		}

		public virtual IEnumerable<ControllerPollingInfo> PollForAllButtons()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				yield break;
			}
			UpdatePollingFrameTracking();
			for (int i = 0; i < _buttonCount; i++)
			{
				if (dlfmEtpcAxJjZHipemsrzWJrwqV(i, out var elementIdentifierId))
				{
					yield return new ControllerPollingInfo(success: true, -1, id, _name, _type, ControllerElementType.Button, i, Pole.Positive, pAhzhvigFoLFbwPDdcXHatZWRIl.GetElementIdentifierName(elementIdentifierId), elementIdentifierId, KeyCode.None);
				}
			}
		}

		public virtual IEnumerable<ControllerPollingInfo> PollForAllButtonsDown()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				yield break;
			}
			UpdatePollingFrameTracking();
			for (int i = 0; i < _buttonCount; i++)
			{
				if (fKomXZydfiajMJkmCCoyjsiyUGny(i, out var elementIdentifierId))
				{
					yield return new ControllerPollingInfo(success: true, -1, id, _name, _type, ControllerElementType.Button, i, Pole.Positive, pAhzhvigFoLFbwPDdcXHatZWRIl.GetElementIdentifierName(elementIdentifierId), elementIdentifierId, KeyCode.None);
				}
			}
		}

		private bool dlfmEtpcAxJjZHipemsrzWJrwqV(int P_0, out int P_1)
		{
			P_1 = -1;
			if (!buttons[P_0].value || buttons[P_0].jpkJjXWhMrgUwNmqszFLtsuhiPR._excludeFromPolling)
			{
				return false;
			}
			P_1 = pAhzhvigFoLFbwPDdcXHatZWRIl.buttonElementIdentifierIds[P_0];
			if (P_1 < 0)
			{
				return false;
			}
			return true;
		}

		private bool fKomXZydfiajMJkmCCoyjsiyUGny(int P_0, out int P_1)
		{
			P_1 = -1;
			if (!buttons[P_0].justPressed || buttons[P_0].jpkJjXWhMrgUwNmqszFLtsuhiPR._excludeFromPolling)
			{
				return false;
			}
			P_1 = pAhzhvigFoLFbwPDdcXHatZWRIl.buttonElementIdentifierIds[P_0];
			if (P_1 < 0)
			{
				return false;
			}
			return true;
		}

		protected void UpdatePollingFrameTracking()
		{
			if (mdtFXWdkANKNkHoDHpGMZoJNbZtD == ReInput.currentFrame)
			{
				return;
			}
			nczBdUdIexqtVbaEsPLiAZaEElvH = mdtFXWdkANKNkHoDHpGMZoJNbZtD;
			mdtFXWdkANKNkHoDHpGMZoJNbZtD = ReInput.currentFrame;
			if (!wasPollingPrev)
			{
				if (hdlXHnMdOyFNotPPXhituOoybdv == uint.MaxValue)
				{
					hdlXHnMdOyFNotPPXhituOoybdv = 0u;
				}
				else
				{
					hdlXHnMdOyFNotPPXhituOoybdv++;
				}
			}
		}

		public virtual double GetLastTimeActive()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return GetLastTimeActive(useRawValues: false);
		}

		public virtual double GetLastTimeActive(bool useRawValues)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return GetLastTimeAnyButtonPressed();
		}

		public virtual double GetLastTimeAnyElementChanged()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return GetLastTimeAnyElementChanged(useRawValues: false);
		}

		public virtual double GetLastTimeAnyElementChanged(bool useRawValues)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return GetLastTimeAnyButtonChanged();
		}

		public double GetLastTimeAnyButtonPressed()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			if (buttons == null)
			{
				return 0.0;
			}
			double num = 0.0;
			for (int i = 0; i < buttons.Length; i++)
			{
				double lastTimePressed = buttons[i].lastTimePressed;
				if (lastTimePressed > num)
				{
					num = lastTimePressed;
				}
			}
			return num;
		}

		public double GetLastTimeAnyButtonChanged()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			if (buttons == null)
			{
				return 0.0;
			}
			double num = 0.0;
			for (int i = 0; i < buttons.Length; i++)
			{
				double lastTimeStateChanged = buttons[i].lastTimeStateChanged;
				if (lastTimeStateChanged > num)
				{
					num = lastTimeStateChanged;
				}
			}
			return num;
		}

		public T GetExtension<T>() where T : class
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			return hmZLUQBpfeonCDoNcFmKCFWkaEcl as T;
		}

		public IControllerTemplate GetTemplate(Guid typeGuid)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			for (int i = 0; i < AmPOkKVbACVczDcMNTllKyDLTPy.Length; i++)
			{
				if (AmPOkKVbACVczDcMNTllKyDLTPy[i].typeGuid == typeGuid)
				{
					return AmPOkKVbACVczDcMNTllKyDLTPy[i];
				}
			}
			return null;
		}

		public IControllerTemplate GetTemplate(Type type)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			for (int i = 0; i < AmPOkKVbACVczDcMNTllKyDLTPy.Length; i++)
			{
				if (ReflectionTools.DoesTypeImplement(AmPOkKVbACVczDcMNTllKyDLTPy[i].GetType(), type))
				{
					return AmPOkKVbACVczDcMNTllKyDLTPy[i];
				}
			}
			return null;
		}

		public T GetTemplate<T>() where T : class
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			for (int i = 0; i < AmPOkKVbACVczDcMNTllKyDLTPy.Length; i++)
			{
				if (AmPOkKVbACVczDcMNTllKyDLTPy[i] as T != null)
				{
					return AmPOkKVbACVczDcMNTllKyDLTPy[i] as T;
				}
			}
			return null;
		}

		public bool ImplementsTemplate(Guid typeGuid)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			for (int i = 0; i < AmPOkKVbACVczDcMNTllKyDLTPy.Length; i++)
			{
				if (AmPOkKVbACVczDcMNTllKyDLTPy[i].typeGuid == typeGuid)
				{
					return true;
				}
			}
			return false;
		}

		public bool ImplementsTemplate(Type type)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if ((object)type == null)
			{
				throw new ArgumentNullException("type");
			}
			for (int i = 0; i < AmPOkKVbACVczDcMNTllKyDLTPy.Length; i++)
			{
				if (ReflectionTools.DoesTypeImplement(AmPOkKVbACVczDcMNTllKyDLTPy[i].GetType(), type))
				{
					return true;
				}
			}
			return false;
		}

		public bool ImplementsTemplate<T>() where T : class
		{
			return ImplementsTemplate(typeof(T));
		}

		internal void TTvIpamiUEWLyYGxFHloUKOHlJO(IControllerTemplate[] P_0)
		{
			if (P_0 != null)
			{
				AmPOkKVbACVczDcMNTllKyDLTPy = P_0;
				EmLCLNZSPmrenxnbKQDtMquhiAL = new ReadOnlyCollection<IControllerTemplate>(AmPOkKVbACVczDcMNTllKyDLTPy);
			}
		}

		internal virtual void MlEQHREVxHLTuUCANSxPMEKvYTk(UpdateLoopType P_0)
		{
			bool flag = ReInput.IsInputAllowed(_type);
			int num = _buttonCount;
			if (flag)
			{
				for (int i = 0; i < num; i++)
				{
					if (buttons[i].APfANorPnsyvRKUKthifuVbhOzp <= 0)
					{
						buttons[i].wAlHJoEseXwZfahDSIeyAibjNOI(P_0, i, OcGEaRzMecIeBFudxFTOaknZTFKe);
					}
				}
			}
			else
			{
				for (int j = 0; j < num; j++)
				{
					if (buttons[j].APfANorPnsyvRKUKthifuVbhOzp <= 0)
					{
						buttons[j].tXBDUGspriIOhAnxpjFFvoODmDY(P_0);
					}
				}
			}
			if (hmZLUQBpfeonCDoNcFmKCFWkaEcl != null)
			{
				hmZLUQBpfeonCDoNcFmKCFWkaEcl.UpdateData(P_0);
			}
		}

		internal virtual ButtonStateFlags ClqyccpJBHwIUEvwLoXaOpaAqJW(int P_0)
		{
			if (P_0 < 0 || P_0 >= _buttonCount)
			{
				return ButtonStateFlags.DyTkQiNnAPnZlOxrECHYhBSslIv;
			}
			return buttons[P_0].state;
		}

		internal void EyudLnaJxSCTjRsYXBQCHZHZVXjs(Extension P_0)
		{
			if (P_0 == null)
			{
				hmZLUQBpfeonCDoNcFmKCFWkaEcl = null;
				return;
			}
			if (hmZLUQBpfeonCDoNcFmKCFWkaEcl != null)
			{
				MUdrzCGqazHwzKMunKArfQcPCFd(P_0);
				return;
			}
			P_0.SetController(this);
			hmZLUQBpfeonCDoNcFmKCFWkaEcl = P_0.Clone();
		}

		internal void MUdrzCGqazHwzKMunKArfQcPCFd(Extension P_0)
		{
			if (hmZLUQBpfeonCDoNcFmKCFWkaEcl != null)
			{
				hmZLUQBpfeonCDoNcFmKCFWkaEcl.SetSource(P_0);
				hmZLUQBpfeonCDoNcFmKCFWkaEcl.SetController(this);
				P_0?.SetController(this);
			}
			else
			{
				EyudLnaJxSCTjRsYXBQCHZHZVXjs(P_0);
			}
		}

		internal virtual void LlCkzvOeJVaCziTDPktzBWuYotAZ()
		{
			for (int i = 0; i < _buttonCount; i++)
			{
				if (buttons[i] != null)
				{
					buttons[i].Reset();
				}
			}
			if (OcGEaRzMecIeBFudxFTOaknZTFKe != null)
			{
				OcGEaRzMecIeBFudxFTOaknZTFKe.ClearData();
			}
			if (hmZLUQBpfeonCDoNcFmKCFWkaEcl != null)
			{
				hmZLUQBpfeonCDoNcFmKCFWkaEcl.Clear();
			}
		}

		internal virtual bool GVPaGnImiZihtbyndAIXuQVGSLHA(bool P_0)
		{
			if (nZTtfeZBpthDaoAvSONdTABGEaM == P_0)
			{
				return false;
			}
			if (!P_0)
			{
				LlCkzvOeJVaCziTDPktzBWuYotAZ();
			}
			nZTtfeZBpthDaoAvSONdTABGEaM = P_0;
			if (hymBvkFHtIvcnukoWkIwFfGCkitK != null)
			{
				hymBvkFHtIvcnukoWkIwFfGCkitK(P_0);
			}
			return true;
		}

		internal virtual void qQYfIAJgvloChayYXVFBMdlJuGrp(ControllerMap P_0)
		{
			if (P_0 == null)
			{
				return;
			}
			P_0.controllerId = id;
			P_0.controllerType = _type;
			IList<ActionElementMap> buttonMaps = P_0.ButtonMaps;
			for (int i = 0; i < buttonMaps.Count; i++)
			{
				UTvazqIZLDwOPLfFaGTxhGSydhT(P_0, buttonMaps[i]);
			}
			for (int num = buttonMaps.Count - 1; num >= 0; num--)
			{
				if (buttonMaps[num].elementIndex < 0)
				{
					P_0.DeleteElementMap(buttonMaps[num].BoMCLeauexjolkkRqzIpOQOAGri);
				}
			}
		}

		internal virtual void UTvazqIZLDwOPLfFaGTxhGSydhT(ControllerMap P_0, ActionElementMap P_1)
		{
			if (P_1 != null && P_1._elementType == ControllerElementType.Button)
			{
				P_1.sXMDOLeJaacTvhLZHNciRMUNwNbk(P_0);
			}
		}

		internal bool HvDZItSAoowpoblGiTywvlDVobM(ActionElementMap P_0, int P_1, out float P_2, out bool P_3)
		{
			P_3 = false;
			P_2 = 0f;
			if (P_1 != P_0._actionId)
			{
				return false;
			}
			int ugYKpPGXoJUWiIrkuIiAFetRZuI = P_0.UgYKpPGXoJUWiIrkuIiAFetRZuI;
			if (ugYKpPGXoJUWiIrkuIiAFetRZuI < 0 || ugYKpPGXoJUWiIrkuIiAFetRZuI >= _buttonCount)
			{
				return false;
			}
			P_3 = buttons[ugYKpPGXoJUWiIrkuIiAFetRZuI].oHmFyMLXhcgyxcsDcMAFAkFKvCur;
			float num = ((!P_3) ? (buttons[ugYKpPGXoJUWiIrkuIiAFetRZuI].value ? 1f : 0f) : buttons[ugYKpPGXoJUWiIrkuIiAFetRZuI].pressure);
			if (num > 0f)
			{
				if (P_0._elementType == ControllerElementType.Button)
				{
					if (P_0._axisContribution == Pole.Negative)
					{
						num *= -1f;
					}
				}
				else if (P_0._elementType == ControllerElementType.Axis)
				{
					if (P_0._axisRange == AxisRange.Full)
					{
						if (P_0._invert)
						{
							num *= -1f;
						}
					}
					else if (P_0._axisContribution == Pole.Negative)
					{
						num *= -1f;
					}
				}
			}
			P_2 = num;
			return true;
		}

		internal bool HvDZItSAoowpoblGiTywvlDVobM(ActionElementMap P_0, int P_1, bool P_2, out float P_3)
		{
			P_3 = 0f;
			if (P_1 != P_0._actionId)
			{
				return false;
			}
			float num = (P_2 ? 1f : 0f);
			if (num > 0f)
			{
				if (P_0._elementType == ControllerElementType.Button)
				{
					if (P_0._axisContribution == Pole.Negative)
					{
						num *= -1f;
					}
				}
				else if (P_0._elementType == ControllerElementType.Axis)
				{
					if (P_0._axisRange == AxisRange.Full)
					{
						if (P_0._invert)
						{
							num *= -1f;
						}
					}
					else if (P_0._axisContribution == Pole.Negative)
					{
						num *= -1f;
					}
				}
			}
			P_3 = num;
			return true;
		}

		internal void WqsdoDpSvzDOWFFxuzffBuWiPsvG(Element P_0)
		{
			if (P_0 != null)
			{
				ListTools.AddIfUnique(uGpQQIwzyDgccAzdMieIrottQjF, P_0);
			}
		}

		internal virtual Guid gSPYwTldEcDZOwhdHskBDFpZjaT()
		{
			return Guid.Empty;
		}

		protected virtual void Connected()
		{
			_isConnected = true;
		}

		protected virtual void Disconnected()
		{
			_isConnected = false;
			if (OcGEaRzMecIeBFudxFTOaknZTFKe != null)
			{
				OcGEaRzMecIeBFudxFTOaknZTFKe.ClearData();
			}
		}

		[CompilerGenerated]
		private static bool FzsedmwQLctooJslYNHVRnWgvAI(Controller P_0, Guid P_1)
		{
			return P_0.ImplementsTemplate(P_1);
		}

		[CompilerGenerated]
		private static bool bYIFbLGHhGVGEIdRDPUBaJCgPRa(Controller P_0, Type P_1)
		{
			return P_0.ImplementsTemplate(P_1);
		}
	}
}
