using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	public abstract class ControllerTemplate : IControllerTemplate
	{
		internal abstract class iEqfnPyVaykuHTyaJUdgCaIMILT : IControllerTemplateElement, IControllerTemplateElement_Internal
		{
			private readonly IControllerTemplate nJGvFkewuzWileOgdgvLxwmBPEU;

			private readonly int BoMCLeauexjolkkRqzIpOQOAGri;

			private readonly string cdTetXhABLRmOQUvcmFAFXpBMHcj;

			private readonly ControllerTemplateElementType YApegNposatXaqxKKfTqnMxXGsJ;

			protected readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

			public int id
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return -1;
					}
					return BoMCLeauexjolkkRqzIpOQOAGri;
				}
			}

			public string descriptiveName
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return cdTetXhABLRmOQUvcmFAFXpBMHcj;
				}
			}

			public ControllerTemplateElementType type
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return ControllerTemplateElementType.Axis;
					}
					return YApegNposatXaqxKKfTqnMxXGsJ;
				}
			}

			public IControllerTemplate parent => nJGvFkewuzWileOgdgvLxwmBPEU;

			public abstract int elementCount { get; }

			public abstract IControllerTemplateElementSource source { get; }

			public abstract bool exists { get; }

			protected iEqfnPyVaykuHTyaJUdgCaIMILT(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType)
			{
				if (parent == null)
				{
					throw new ArgumentNullException("parent");
				}
				nJGvFkewuzWileOgdgvLxwmBPEU = parent;
				BoMCLeauexjolkkRqzIpOQOAGri = id;
				cdTetXhABLRmOQUvcmFAFXpBMHcj = name;
				YApegNposatXaqxKKfTqnMxXGsJ = elementType;
				PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
			}

			public abstract IControllerTemplateElement GetElement(int index);

			public abstract int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list);
		}

		internal abstract class qoxuQWuuBLOOXgHwKcwkukltofQ : iEqfnPyVaykuHTyaJUdgCaIMILT
		{
			protected readonly int nAhHdobvqphvvTfDxHAaMGiXKPQ;

			protected readonly TxcDNzZFLyQuZzpHlbpSAqCYNDSa[] znyoRxCZlZqaXyIdjlOqfUfPYON;

			public override bool IpvMKVxxBIRveJmdiHzygtylQDT
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (znyoRxCZlZqaXyIdjlOqfUfPYON == null)
					{
						return false;
					}
					for (int i = 0; i < znyoRxCZlZqaXyIdjlOqfUfPYON.Length; i++)
					{
						if (znyoRxCZlZqaXyIdjlOqfUfPYON[i].ZFRkhXzoHYMYgVeQssKqOHKOPMF != null)
						{
							return true;
						}
					}
					return false;
				}
			}

			protected qoxuQWuuBLOOXgHwKcwkukltofQ(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, IList<TxcDNzZFLyQuZzpHlbpSAqCYNDSa> sourceElements)
				: base(parent, id, name, elementType)
			{
				znyoRxCZlZqaXyIdjlOqfUfPYON = ((sourceElements != null) ? ListTools.ToArray(sourceElements) : null);
				nAhHdobvqphvvTfDxHAaMGiXKPQ = ((znyoRxCZlZqaXyIdjlOqfUfPYON != null) ? znyoRxCZlZqaXyIdjlOqfUfPYON.Length : 0);
			}
		}

		internal abstract class kKtogElfnRPvHjOtrzGjojowfKuh : qoxuQWuuBLOOXgHwKcwkukltofQ, IControllerTemplateElement, IControllerTemplateAxis, IControllerTemplateButton
		{
			private UsMQnVXJOgAELSCkvEBzkFdKjFNq HOzVbenRtSDkKAqmPyECWoYOfWfD;

			private string vITgPsBRCThkgEtEjHvMChYnqygN;

			private string bxXsTSgIkQOrtDFrKKnvsiBkRJt;

			public float kmXPJuboaoIZNVbNRjqsJUEhvKw
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					if (nAhHdobvqphvvTfDxHAaMGiXKPQ == 1)
					{
						return znyoRxCZlZqaXyIdjlOqfUfPYON[0].kmXPJuboaoIZNVbNRjqsJUEhvKw;
					}
					if (nAhHdobvqphvvTfDxHAaMGiXKPQ == 2)
					{
						float floatValue = znyoRxCZlZqaXyIdjlOqfUfPYON[0].kmXPJuboaoIZNVbNRjqsJUEhvKw;
						float floatValue2 = znyoRxCZlZqaXyIdjlOqfUfPYON[1].kmXPJuboaoIZNVbNRjqsJUEhvKw;
						return MathTools.Clamp(floatValue + floatValue2, -1f, 1f);
					}
					return 0f;
				}
			}

			public float oPvBnhfzBnewBTjqFJnBJrgPNifn
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					if (nAhHdobvqphvvTfDxHAaMGiXKPQ == 1)
					{
						return znyoRxCZlZqaXyIdjlOqfUfPYON[0].oPvBnhfzBnewBTjqFJnBJrgPNifn;
					}
					if (nAhHdobvqphvvTfDxHAaMGiXKPQ == 2)
					{
						float floatValuePrev = znyoRxCZlZqaXyIdjlOqfUfPYON[0].oPvBnhfzBnewBTjqFJnBJrgPNifn;
						float floatValuePrev2 = znyoRxCZlZqaXyIdjlOqfUfPYON[1].oPvBnhfzBnewBTjqFJnBJrgPNifn;
						return MathTools.Clamp(floatValuePrev + floatValuePrev2, -1f, 1f);
					}
					return 0f;
				}
			}

			public bool sErYZUSKRrHKzQAmqAzlnqtyZFH
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (nAhHdobvqphvvTfDxHAaMGiXKPQ == 1)
					{
						return znyoRxCZlZqaXyIdjlOqfUfPYON[0].sErYZUSKRrHKzQAmqAzlnqtyZFH;
					}
					if (nAhHdobvqphvvTfDxHAaMGiXKPQ == 2)
					{
						if (!znyoRxCZlZqaXyIdjlOqfUfPYON[0].sErYZUSKRrHKzQAmqAzlnqtyZFH)
						{
							return znyoRxCZlZqaXyIdjlOqfUfPYON[1].sErYZUSKRrHKzQAmqAzlnqtyZFH;
						}
						return true;
					}
					return false;
				}
			}

			public bool wBXhDMBBnoIQwyKJFdKmtKxXqEFc
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (nAhHdobvqphvvTfDxHAaMGiXKPQ == 1)
					{
						return znyoRxCZlZqaXyIdjlOqfUfPYON[0].wBXhDMBBnoIQwyKJFdKmtKxXqEFc;
					}
					if (nAhHdobvqphvvTfDxHAaMGiXKPQ == 2)
					{
						if (!znyoRxCZlZqaXyIdjlOqfUfPYON[0].wBXhDMBBnoIQwyKJFdKmtKxXqEFc)
						{
							return znyoRxCZlZqaXyIdjlOqfUfPYON[1].wBXhDMBBnoIQwyKJFdKmtKxXqEFc;
						}
						return true;
					}
					return false;
				}
			}

			string IControllerTemplateAxis.sVNdjTDEOCsVALYZqzDCxOVJrQk
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return vITgPsBRCThkgEtEjHvMChYnqygN;
				}
			}

			string IControllerTemplateAxis.gqQDsfshoJygwJcbyulVNnxWGIbb
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return bxXsTSgIkQOrtDFrKKnvsiBkRJt;
				}
			}

			float IControllerTemplateAxis.LZXOaCNiVxIxbhkVeBGshybufTa
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					return kmXPJuboaoIZNVbNRjqsJUEhvKw;
				}
			}

			float IControllerTemplateAxis.PCJjGjHslcIeGnggadZVdzRcspGP
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					return oPvBnhfzBnewBTjqFJnBJrgPNifn;
				}
			}

			IControllerTemplateAxisSource IControllerTemplateAxis.aoNlxMqdLPqbUoJcFalPgtssjzbp
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return HOzVbenRtSDkKAqmPyECWoYOfWfD;
				}
			}

			bool IControllerTemplateButton.AfxemzJbGbeqzEuDZRUwtChVNMTd
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return sErYZUSKRrHKzQAmqAzlnqtyZFH;
				}
			}

			bool IControllerTemplateButton.YvagxpQTHoBwuBiaKHHxqOWVzeEU
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return wBXhDMBBnoIQwyKJFdKmtKxXqEFc;
				}
			}

			bool IControllerTemplateButton.NchakIjmppWITXbOxnLDifSWyun
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (nAhHdobvqphvvTfDxHAaMGiXKPQ == 1)
					{
						return znyoRxCZlZqaXyIdjlOqfUfPYON[0].ackAfqTveINRnSkXedYMDkCbEItF;
					}
					if (nAhHdobvqphvvTfDxHAaMGiXKPQ == 2)
					{
						if (!znyoRxCZlZqaXyIdjlOqfUfPYON[0].ackAfqTveINRnSkXedYMDkCbEItF || znyoRxCZlZqaXyIdjlOqfUfPYON[1].wBXhDMBBnoIQwyKJFdKmtKxXqEFc)
						{
							if (znyoRxCZlZqaXyIdjlOqfUfPYON[1].ackAfqTveINRnSkXedYMDkCbEItF)
							{
								return !znyoRxCZlZqaXyIdjlOqfUfPYON[0].wBXhDMBBnoIQwyKJFdKmtKxXqEFc;
							}
							return false;
						}
						return true;
					}
					return false;
				}
			}

			bool IControllerTemplateButton.jBVJwDTHEIjfinxutNkPOUJnTok
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (nAhHdobvqphvvTfDxHAaMGiXKPQ == 1)
					{
						return znyoRxCZlZqaXyIdjlOqfUfPYON[0].lwYGtHhLAvocvsdFvNxxGuUzHyh;
					}
					if (nAhHdobvqphvvTfDxHAaMGiXKPQ == 2)
					{
						if (!znyoRxCZlZqaXyIdjlOqfUfPYON[0].lwYGtHhLAvocvsdFvNxxGuUzHyh || znyoRxCZlZqaXyIdjlOqfUfPYON[1].sErYZUSKRrHKzQAmqAzlnqtyZFH)
						{
							if (znyoRxCZlZqaXyIdjlOqfUfPYON[1].lwYGtHhLAvocvsdFvNxxGuUzHyh)
							{
								return !znyoRxCZlZqaXyIdjlOqfUfPYON[0].sErYZUSKRrHKzQAmqAzlnqtyZFH;
							}
							return false;
						}
						return true;
					}
					return false;
				}
			}

			bool IControllerTemplateButton.rbEwNAsUyGbAZhKBwraoiuWfBEF
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return sErYZUSKRrHKzQAmqAzlnqtyZFH != wBXhDMBBnoIQwyKJFdKmtKxXqEFc;
				}
			}

			float IControllerTemplateButton.tAnYNCISxdFFLilRdxWmvdZoKnJ
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					return kmXPJuboaoIZNVbNRjqsJUEhvKw;
				}
			}

			float IControllerTemplateButton.tIOYDlsnBXNvgLhAyBgkjCxbPiD
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					return oPvBnhfzBnewBTjqFJnBJrgPNifn;
				}
			}

			IControllerTemplateButtonSource IControllerTemplateButton.juPbexqlIshXekJcACcLAeMtkGc
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return HOzVbenRtSDkKAqmPyECWoYOfWfD;
				}
			}

			public override IControllerTemplateElementSource source
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return HOzVbenRtSDkKAqmPyECWoYOfWfD;
				}
			}

			public override int elementCount => 0;

			public IControllerTemplateAxis AsAxis
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return this;
				}
			}

			public IControllerTemplateButton AsButton
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return this;
				}
			}

			protected kKtogElfnRPvHjOtrzGjojowfKuh(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, ControllerTemplateElementType elementType, UsMQnVXJOgAELSCkvEBzkFdKjFNq target, IList<TxcDNzZFLyQuZzpHlbpSAqCYNDSa> sourceElements)
				: base(parent, id, name, elementType, sourceElements)
			{
				if (sourceElements != null && sourceElements.Count > 2)
				{
					throw new ArgumentOutOfRangeException("sourceElements.Count must be <= 2.");
				}
				if (target == null)
				{
					throw new ArgumentNullException("target");
				}
				HOzVbenRtSDkKAqmPyECWoYOfWfD = target;
				vITgPsBRCThkgEtEjHvMChYnqygN = positiveName;
				bxXsTSgIkQOrtDFrKKnvsiBkRJt = negativeName;
			}

			private string UhgfinXLNudSVZYIRVvoPTSYAOT(AxisRange P_0)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return P_0 switch
				{
					AxisRange.Full => base.descriptiveName, 
					AxisRange.Positive => vITgPsBRCThkgEtEjHvMChYnqygN, 
					AxisRange.Negative => bxXsTSgIkQOrtDFrKKnvsiBkRJt, 
					_ => throw new NotImplementedException(), 
				};
			}

			string IControllerTemplateAxis.GetDescriptiveName(AxisRange P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in UhgfinXLNudSVZYIRVvoPTSYAOT
				return this.UhgfinXLNudSVZYIRVvoPTSYAOT(P_0);
			}

			public override IControllerTemplateElement GetElement(int index)
			{
				return null;
			}

			public override int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list)
			{
				if (find.elementIdentifierId < 0)
				{
					return 0;
				}
				int num = 0;
				switch (base.type)
				{
				case ControllerTemplateElementType.Axis:
				{
					IControllerTemplateAxisSource hOzVbenRtSDkKAqmPyECWoYOfWfD = HOzVbenRtSDkKAqmPyECWoYOfWfD;
					if (hOzVbenRtSDkKAqmPyECWoYOfWfD.splitAxis)
					{
						if (KFUmPzOVfTDApgiGUkSXPOFsjBv(find, hOzVbenRtSDkKAqmPyECWoYOfWfD.positiveTarget))
						{
							ListTools.AddAndCreateList(ref list, new ControllerTemplateElementTarget(this, AxisRange.Positive));
							num++;
						}
						if (KFUmPzOVfTDApgiGUkSXPOFsjBv(find, hOzVbenRtSDkKAqmPyECWoYOfWfD.negativeTarget))
						{
							ListTools.AddAndCreateList(ref list, new ControllerTemplateElementTarget(this, AxisRange.Negative));
							num++;
						}
					}
					else if (KFUmPzOVfTDApgiGUkSXPOFsjBv(find, hOzVbenRtSDkKAqmPyECWoYOfWfD.fullTarget))
					{
						ListTools.AddAndCreateList(ref list, new ControllerTemplateElementTarget(this, find.axisRange));
						num++;
					}
					break;
				}
				case ControllerTemplateElementType.Button:
					if (KFUmPzOVfTDApgiGUkSXPOFsjBv(find, ((IControllerTemplateButtonSource)HOzVbenRtSDkKAqmPyECWoYOfWfD).target))
					{
						ListTools.AddAndCreateList(ref list, new ControllerTemplateElementTarget(this, AxisRange.Full));
						num++;
					}
					break;
				default:
					throw new NotImplementedException();
				}
				return num;
			}

			private static bool KFUmPzOVfTDApgiGUkSXPOFsjBv(ControllerElementTarget P_0, IControllerElementTarget P_1)
			{
				if (P_1.elementIdentifierId != P_0.elementIdentifierId)
				{
					return false;
				}
				switch (P_1.elementType)
				{
				case ControllerElementType.Axis:
				{
					AxisRange axisRange = P_1.axisRange;
					if (axisRange == AxisRange.Full)
					{
						return true;
					}
					if (axisRange == P_0.axisRange)
					{
						return true;
					}
					return false;
				}
				case ControllerElementType.Button:
					return true;
				default:
					throw new NotImplementedException();
				}
			}
		}

		internal sealed class LwxsftUbYtbLZJdIYTUsTMZpsel : kKtogElfnRPvHjOtrzGjojowfKuh
		{
			public LwxsftUbYtbLZJdIYTUsTMZpsel(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, UsMQnVXJOgAELSCkvEBzkFdKjFNq target, IList<TxcDNzZFLyQuZzpHlbpSAqCYNDSa> sourceElements)
				: base(parent, id, name, positiveName, negativeName, ControllerTemplateElementType.Axis, target, sourceElements)
			{
				if (sourceElements != null && sourceElements.Count > 2)
				{
					throw new ArgumentOutOfRangeException("sourceElements.Count must be <= 2.");
				}
			}

			internal static LwxsftUbYtbLZJdIYTUsTMZpsel kbUEkrjNKrFkwKWFaqXQToCsrDji(IControllerTemplate P_0)
			{
				return new LwxsftUbYtbLZJdIYTUsTMZpsel(P_0, -1, string.Empty, string.Empty, string.Empty, UsMQnVXJOgAELSCkvEBzkFdKjFNq.kbUEkrjNKrFkwKWFaqXQToCsrDji(ControllerTemplateElementType.Axis), null);
			}
		}

		internal sealed class sBZjCcVfpldYYGibHbRAoFAsYTc : kKtogElfnRPvHjOtrzGjojowfKuh
		{
			public sBZjCcVfpldYYGibHbRAoFAsYTc(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, UsMQnVXJOgAELSCkvEBzkFdKjFNq target, IList<TxcDNzZFLyQuZzpHlbpSAqCYNDSa> sourceElements)
				: base(parent, id, name, positiveName, negativeName, ControllerTemplateElementType.Button, target, sourceElements)
			{
				if (sourceElements != null && sourceElements.Count > 1)
				{
					throw new ArgumentOutOfRangeException("sourceElements.Count must be <= 1.");
				}
			}

			internal static sBZjCcVfpldYYGibHbRAoFAsYTc kbUEkrjNKrFkwKWFaqXQToCsrDji(IControllerTemplate P_0)
			{
				return new sBZjCcVfpldYYGibHbRAoFAsYTc(P_0, -1, string.Empty, string.Empty, string.Empty, UsMQnVXJOgAELSCkvEBzkFdKjFNq.kbUEkrjNKrFkwKWFaqXQToCsrDji(ControllerTemplateElementType.Button), null);
			}
		}

		internal abstract class UyDsZrzaeWBhBIVfNiiXOSIsBRg : iEqfnPyVaykuHTyaJUdgCaIMILT
		{
			protected readonly int eSxFvCIaFVWYtzmhOMscPCVRyik;

			protected readonly iEqfnPyVaykuHTyaJUdgCaIMILT[] uGpQQIwzyDgccAzdMieIrottQjF;

			public override bool IpvMKVxxBIRveJmdiHzygtylQDT
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					for (int i = 0; i < eSxFvCIaFVWYtzmhOMscPCVRyik; i++)
					{
						if (uGpQQIwzyDgccAzdMieIrottQjF[i].exists)
						{
							return true;
						}
					}
					return false;
				}
			}

			public override IControllerTemplateElementSource eEGdvsHFSoebDZTJoammOSBqiFV
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return null;
				}
			}

			public override int KYKAwfsoCfEXKWReiIvTDELQWxh => eSxFvCIaFVWYtzmhOMscPCVRyik;

			protected UyDsZrzaeWBhBIVfNiiXOSIsBRg(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, iEqfnPyVaykuHTyaJUdgCaIMILT[] elements)
				: base(parent, id, name, elementType)
			{
				if (elements == null)
				{
					throw new ArgumentNullException("elements");
				}
				if (elements.Length == 0)
				{
					throw new ArgumentException("elements.Length is zero.");
				}
				for (int i = 0; i < elements.Length; i++)
				{
					if (elements[i] == null)
					{
						throw new ArgumentNullException("elements contains a null entry.");
					}
				}
				uGpQQIwzyDgccAzdMieIrottQjF = elements;
				eSxFvCIaFVWYtzmhOMscPCVRyik = elements.Length;
			}

			public virtual IControllerTemplateElement eCWODyubZajVwOmkGSFXlCGBdhT(int P_0)
			{
				return uGpQQIwzyDgccAzdMieIrottQjF[P_0];
			}

			public virtual int oDGaJxsQWyutwAVTwqIhCBLJHpk(ControllerElementTarget P_0, ref IList<ControllerTemplateElementTarget> P_1)
			{
				int num = 0;
				for (int i = 0; i < uGpQQIwzyDgccAzdMieIrottQjF.Length; i++)
				{
					num += uGpQQIwzyDgccAzdMieIrottQjF[i].GetElementTargets(P_0, ref P_1);
				}
				return num;
			}
		}

		internal abstract class ygclvLuOOzJkqmtRtpyXwsWVYPW : UyDsZrzaeWBhBIVfNiiXOSIsBRg, IControllerTemplateElement, IControllerTemplateAxis2D
		{
			protected const int OnSplBrIGpXTDADVTyXiajOuMKL = 0;

			protected const int dGNjjwwSYIJYAaUCKlrKAFpEzxr = 1;

			protected const int EOmCscSleqEXYBFvClIphRYFPTUS = 2;

			public Vector2 value
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return Vector2.zero;
					}
					return new Vector2((eSxFvCIaFVWYtzmhOMscPCVRyik > 0) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[0]).kmXPJuboaoIZNVbNRjqsJUEhvKw : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 1) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[1]).kmXPJuboaoIZNVbNRjqsJUEhvKw : 0f);
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
					return new Vector2((eSxFvCIaFVWYtzmhOMscPCVRyik > 0) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[0]).oPvBnhfzBnewBTjqFJnBJrgPNifn : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 1) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[1]).oPvBnhfzBnewBTjqFJnBJrgPNifn : 0f);
				}
			}

			public IControllerTemplateAxis horizontal
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[0];
				}
			}

			public IControllerTemplateAxis vertical
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[1];
				}
			}

			protected ygclvLuOOzJkqmtRtpyXwsWVYPW(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, iEqfnPyVaykuHTyaJUdgCaIMILT[] elements)
				: base(parent, id, name, elementType, elements)
			{
			}
		}

		internal abstract class cyuyIcCtJDrrFNKYfjhykeFWttF : UyDsZrzaeWBhBIVfNiiXOSIsBRg, IControllerTemplateElement, IControllerTemplateAxis3D
		{
			protected const int OnSplBrIGpXTDADVTyXiajOuMKL = 0;

			protected const int dGNjjwwSYIJYAaUCKlrKAFpEzxr = 1;

			protected const int vBwASYKpojgYvDbNPviNfAGBenzS = 2;

			protected const int EOmCscSleqEXYBFvClIphRYFPTUS = 3;

			public Vector3 value
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return Vector3.zero;
					}
					return new Vector3((eSxFvCIaFVWYtzmhOMscPCVRyik > 0) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[0]).kmXPJuboaoIZNVbNRjqsJUEhvKw : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 1) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[1]).kmXPJuboaoIZNVbNRjqsJUEhvKw : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 2) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[2]).kmXPJuboaoIZNVbNRjqsJUEhvKw : 0f);
				}
			}

			public Vector3 valuePrev
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return Vector3.zero;
					}
					return new Vector3((eSxFvCIaFVWYtzmhOMscPCVRyik > 0) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[0]).oPvBnhfzBnewBTjqFJnBJrgPNifn : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 1) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[1]).oPvBnhfzBnewBTjqFJnBJrgPNifn : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 2) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[2]).oPvBnhfzBnewBTjqFJnBJrgPNifn : 0f);
				}
			}

			public IControllerTemplateAxis horizontal
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[0];
				}
			}

			public IControllerTemplateAxis vertical
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[1];
				}
			}

			public IControllerTemplateAxis depth
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[2];
				}
			}

			protected cyuyIcCtJDrrFNKYfjhykeFWttF(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, iEqfnPyVaykuHTyaJUdgCaIMILT[] elements)
				: base(parent, id, name, elementType, elements)
			{
			}
		}

		internal abstract class CqYFfsfyoldVPGcMOkIBuXlyRib : UyDsZrzaeWBhBIVfNiiXOSIsBRg, IControllerTemplateElement, IControllerTemplateAxis6D
		{
			protected const int qiyuAwlDWSJhZykicDXqplxHSWd = 0;

			protected const int zbdgKmWfraoKaRSkCjlRkjQyAEhj = 1;

			protected const int CyLXAsGsqhdSweSjMmtrshjvvpH = 2;

			protected const int bOZFCViCqKgSCmGSFdSmwKOvDtj = 3;

			protected const int UruReLpuovkvvOmONjHSOppoHJoh = 4;

			protected const int IlZzKyUfoTncbvFfLPxlYSTdTUt = 5;

			protected const int EOmCscSleqEXYBFvClIphRYFPTUS = 6;

			public Vector3 position
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return Vector3.zero;
					}
					return new Vector3((eSxFvCIaFVWYtzmhOMscPCVRyik > 0) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[0]).kmXPJuboaoIZNVbNRjqsJUEhvKw : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 1) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[1]).kmXPJuboaoIZNVbNRjqsJUEhvKw : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 2) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[2]).kmXPJuboaoIZNVbNRjqsJUEhvKw : 0f);
				}
			}

			public Vector3 positionPrev
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return Vector3.zero;
					}
					return new Vector3((eSxFvCIaFVWYtzmhOMscPCVRyik > 0) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[0]).oPvBnhfzBnewBTjqFJnBJrgPNifn : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 1) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[1]).oPvBnhfzBnewBTjqFJnBJrgPNifn : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 2) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[2]).oPvBnhfzBnewBTjqFJnBJrgPNifn : 0f);
				}
			}

			public Vector3 rotation
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return Vector3.zero;
					}
					return new Vector3((eSxFvCIaFVWYtzmhOMscPCVRyik > 3) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[3]).kmXPJuboaoIZNVbNRjqsJUEhvKw : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 4) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[4]).kmXPJuboaoIZNVbNRjqsJUEhvKw : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 5) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[5]).kmXPJuboaoIZNVbNRjqsJUEhvKw : 0f);
				}
			}

			public Vector3 rotationPrev
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return Vector3.zero;
					}
					return new Vector3((eSxFvCIaFVWYtzmhOMscPCVRyik > 3) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[3]).oPvBnhfzBnewBTjqFJnBJrgPNifn : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 4) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[4]).oPvBnhfzBnewBTjqFJnBJrgPNifn : 0f, (eSxFvCIaFVWYtzmhOMscPCVRyik > 5) ? ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[5]).oPvBnhfzBnewBTjqFJnBJrgPNifn : 0f);
				}
			}

			public IControllerTemplateAxis positionX
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[0];
				}
			}

			public IControllerTemplateAxis positionY
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[1];
				}
			}

			public IControllerTemplateAxis positionZ
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[2];
				}
			}

			public IControllerTemplateAxis rotationX
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[3];
				}
			}

			public IControllerTemplateAxis rotationY
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[4];
				}
			}

			public IControllerTemplateAxis rotationZ
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[5];
				}
			}

			protected CqYFfsfyoldVPGcMOkIBuXlyRib(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, iEqfnPyVaykuHTyaJUdgCaIMILT[] elements)
				: base(parent, id, name, elementType, elements)
			{
			}
		}

		internal sealed class WPQSJwnRlTusPbzGefWRPGKpXAe : cyuyIcCtJDrrFNKYfjhykeFWttF, IControllerTemplateElement, IControllerTemplateStick
		{
			private new const int EOmCscSleqEXYBFvClIphRYFPTUS = 3;

			public IControllerTemplateAxis rotation
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[2];
				}
			}

			private WPQSJwnRlTusPbzGefWRPGKpXAe(IControllerTemplate parent, int id, string name, iEqfnPyVaykuHTyaJUdgCaIMILT[] elements)
				: base(parent, id, name, ControllerTemplateElementType.Stick, elements)
			{
				if (elements.Length != 3)
				{
					throw new ArgumentException("elements.Length must be " + 3);
				}
			}

			public WPQSJwnRlTusPbzGefWRPGKpXAe(IControllerTemplate parent, int id, string name, kKtogElfnRPvHjOtrzGjojowfKuh xAxis, kKtogElfnRPvHjOtrzGjojowfKuh yAxis, kKtogElfnRPvHjOtrzGjojowfKuh zAxis)
				: this(parent, id, name, new iEqfnPyVaykuHTyaJUdgCaIMILT[3] { xAxis, yAxis, zAxis })
			{
			}
		}

		internal sealed class JSxhpGLucsoIfKKMFiQQGOfgDERd : ygclvLuOOzJkqmtRtpyXwsWVYPW, IControllerTemplateElement, IControllerTemplateThumbStick
		{
			private const int WPpQTHmvUDHrpgijbhfIaCBoMYJm = 2;

			private new const int EOmCscSleqEXYBFvClIphRYFPTUS = 3;

			public IControllerTemplateButton press
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[2];
				}
			}

			private JSxhpGLucsoIfKKMFiQQGOfgDERd(IControllerTemplate parent, int id, string name, iEqfnPyVaykuHTyaJUdgCaIMILT[] elements)
				: base(parent, id, name, ControllerTemplateElementType.ThumbStick, elements)
			{
				if (elements.Length != 3)
				{
					throw new ArgumentException("elements.Length must be " + 3);
				}
			}

			internal JSxhpGLucsoIfKKMFiQQGOfgDERd(IControllerTemplate parent, int id, string name, kKtogElfnRPvHjOtrzGjojowfKuh xAxis, kKtogElfnRPvHjOtrzGjojowfKuh yAxis, kKtogElfnRPvHjOtrzGjojowfKuh button)
				: this(parent, id, name, new iEqfnPyVaykuHTyaJUdgCaIMILT[3] { xAxis, yAxis, button })
			{
			}
		}

		internal sealed class bvOrjHwPVdCJEYrttjjPJgjXlmB : UyDsZrzaeWBhBIVfNiiXOSIsBRg, IControllerTemplateElement, IControllerTemplateDPad
		{
			private const int CJndTUkNmLjnphdfGtioFrcAyytf = 0;

			private const int RxdcbSnfQoEObtqMThwmcwuGaxCK = 1;

			private const int rJvjIyLPPtoOibCfNXmmdPLzjln = 2;

			private const int BCJySJCBKpaHufbbVlYMBPWbXYFh = 3;

			private const int vsaSgMQDarQewplKKwxrgXYncUV = 4;

			private const int EOmCscSleqEXYBFvClIphRYFPTUS = 5;

			public Vector2 value
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return Vector2.zero;
					}
					return new Vector2(MathTools.Clamp(((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[0]).kmXPJuboaoIZNVbNRjqsJUEhvKw + ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[2]).kmXPJuboaoIZNVbNRjqsJUEhvKw * -1f, -1f, 1f), MathTools.Clamp(((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[3]).kmXPJuboaoIZNVbNRjqsJUEhvKw * -1f + ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[1]).kmXPJuboaoIZNVbNRjqsJUEhvKw, -1f, 1f));
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
					return new Vector2(MathTools.Clamp(((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[0]).oPvBnhfzBnewBTjqFJnBJrgPNifn + ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[2]).oPvBnhfzBnewBTjqFJnBJrgPNifn * -1f, -1f, 1f), MathTools.Clamp(((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[3]).oPvBnhfzBnewBTjqFJnBJrgPNifn * -1f + ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[1]).oPvBnhfzBnewBTjqFJnBJrgPNifn, -1f, 1f));
				}
			}

			public IControllerTemplateButton up
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[0];
				}
			}

			public IControllerTemplateButton right
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[1];
				}
			}

			public IControllerTemplateButton down
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[2];
				}
			}

			public IControllerTemplateButton left
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[3];
				}
			}

			public IControllerTemplateButton press
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[4];
				}
			}

			private bvOrjHwPVdCJEYrttjjPJgjXlmB(IControllerTemplate parent, int id, string name, iEqfnPyVaykuHTyaJUdgCaIMILT[] elements)
				: base(parent, id, name, ControllerTemplateElementType.DPad, elements)
			{
				if (elements.Length != 5)
				{
					throw new ArgumentException("elements.Length must be " + 5);
				}
			}

			internal bvOrjHwPVdCJEYrttjjPJgjXlmB(IControllerTemplate parent, int id, string name, kKtogElfnRPvHjOtrzGjojowfKuh up, kKtogElfnRPvHjOtrzGjojowfKuh right, kKtogElfnRPvHjOtrzGjojowfKuh down, kKtogElfnRPvHjOtrzGjojowfKuh left, kKtogElfnRPvHjOtrzGjojowfKuh press)
				: this(parent, id, name, new iEqfnPyVaykuHTyaJUdgCaIMILT[5] { up, right, down, left, press })
			{
			}
		}

		internal sealed class szcwMpblLfcMpiJYVDrSIwmXThf : UyDsZrzaeWBhBIVfNiiXOSIsBRg, IControllerTemplateElement, IControllerTemplateThrottle
		{
			private const int fyXuPJlwYjwVyWuNlfbQpTuAnFN = 0;

			private const int mosPFGdotdgZOipyBWsTfeOTREN = 1;

			private const int EOmCscSleqEXYBFvClIphRYFPTUS = 2;

			public float value
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0f;
					}
					return ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[0]).kmXPJuboaoIZNVbNRjqsJUEhvKw;
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
					return ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[0]).oPvBnhfzBnewBTjqFJnBJrgPNifn;
				}
			}

			public IControllerTemplateAxis throttle
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[0];
				}
			}

			public IControllerTemplateButton minDetent
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[1];
				}
			}

			private szcwMpblLfcMpiJYVDrSIwmXThf(IControllerTemplate parent, int id, string name, iEqfnPyVaykuHTyaJUdgCaIMILT[] elements)
				: base(parent, id, name, ControllerTemplateElementType.Throttle, elements)
			{
				if (elements.Length != 2)
				{
					throw new ArgumentException("elements.Length must be " + 2);
				}
			}

			internal szcwMpblLfcMpiJYVDrSIwmXThf(IControllerTemplate parent, int id, string name, kKtogElfnRPvHjOtrzGjojowfKuh axis, kKtogElfnRPvHjOtrzGjojowfKuh zeroDetentButton)
				: this(parent, id, name, new iEqfnPyVaykuHTyaJUdgCaIMILT[2] { axis, zeroDetentButton })
			{
			}
		}

		internal sealed class TUYsXdEShZxWmJSvEyvpwecUrmZ : UyDsZrzaeWBhBIVfNiiXOSIsBRg, IControllerTemplateElement, IControllerTemplateHat
		{
			private const int CJndTUkNmLjnphdfGtioFrcAyytf = 0;

			private const int chTfcrNftdLcIzhShBBgJUnwiea = 1;

			private const int RxdcbSnfQoEObtqMThwmcwuGaxCK = 2;

			private const int LRRxHEQkYdgBFfQnWDiNTpvOTIjt = 3;

			private const int rJvjIyLPPtoOibCfNXmmdPLzjln = 4;

			private const int LLXEGxOnTUWPVoaNUpHnVMRhcxE = 5;

			private const int BCJySJCBKpaHufbbVlYMBPWbXYFh = 6;

			private const int clegsySVPIgoIfJVPGkrSeZboBzB = 7;

			private const int EOmCscSleqEXYBFvClIphRYFPTUS = 8;

			public Vector2 value
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return Vector2.zero;
					}
					Vector2 result = default(Vector2);
					result.y += ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[0]).kmXPJuboaoIZNVbNRjqsJUEhvKw;
					result.x += ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[2]).kmXPJuboaoIZNVbNRjqsJUEhvKw;
					result.y -= ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[4]).kmXPJuboaoIZNVbNRjqsJUEhvKw;
					result.x -= ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[6]).kmXPJuboaoIZNVbNRjqsJUEhvKw;
					float floatValue = ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[1]).kmXPJuboaoIZNVbNRjqsJUEhvKw;
					float floatValue2 = ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[3]).kmXPJuboaoIZNVbNRjqsJUEhvKw;
					float floatValue3 = ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[5]).kmXPJuboaoIZNVbNRjqsJUEhvKw;
					float floatValue4 = ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[7]).kmXPJuboaoIZNVbNRjqsJUEhvKw;
					result.x += floatValue + floatValue2 - floatValue3 - floatValue4;
					result.y += floatValue + floatValue4 - floatValue2 - floatValue3;
					result.x = MathTools.Clamp(result.x, -1f, 1f);
					result.y = MathTools.Clamp(result.y, -1f, 1f);
					return result;
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
					Vector2 result = default(Vector2);
					result.y += ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[0]).oPvBnhfzBnewBTjqFJnBJrgPNifn;
					result.x += ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[2]).oPvBnhfzBnewBTjqFJnBJrgPNifn;
					result.y -= ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[4]).oPvBnhfzBnewBTjqFJnBJrgPNifn;
					result.x -= ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[6]).oPvBnhfzBnewBTjqFJnBJrgPNifn;
					float floatValuePrev = ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[1]).oPvBnhfzBnewBTjqFJnBJrgPNifn;
					float floatValuePrev2 = ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[3]).oPvBnhfzBnewBTjqFJnBJrgPNifn;
					float floatValuePrev3 = ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[5]).oPvBnhfzBnewBTjqFJnBJrgPNifn;
					float floatValuePrev4 = ((kKtogElfnRPvHjOtrzGjojowfKuh)uGpQQIwzyDgccAzdMieIrottQjF[7]).oPvBnhfzBnewBTjqFJnBJrgPNifn;
					result.x += floatValuePrev + floatValuePrev2 - floatValuePrev3 - floatValuePrev4;
					result.y += floatValuePrev + floatValuePrev4 - floatValuePrev2 - floatValuePrev3;
					result.x = MathTools.Clamp(result.x, -1f, 1f);
					result.y = MathTools.Clamp(result.y, -1f, 1f);
					return result;
				}
			}

			public IControllerTemplateButton up
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[0];
				}
			}

			public IControllerTemplateButton upRight
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[1];
				}
			}

			public IControllerTemplateButton right
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[2];
				}
			}

			public IControllerTemplateButton downRight
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[3];
				}
			}

			public IControllerTemplateButton down
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[4];
				}
			}

			public IControllerTemplateButton downLeft
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[5];
				}
			}

			public IControllerTemplateButton left
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[6];
				}
			}

			public IControllerTemplateButton upLeft
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateButton)uGpQQIwzyDgccAzdMieIrottQjF[7];
				}
			}

			private TUYsXdEShZxWmJSvEyvpwecUrmZ(IControllerTemplate parent, int id, string name, iEqfnPyVaykuHTyaJUdgCaIMILT[] elements)
				: base(parent, id, name, ControllerTemplateElementType.Hat, elements)
			{
				if (elements.Length != 8)
				{
					throw new ArgumentException("elements.Length must be " + 8);
				}
			}

			internal TUYsXdEShZxWmJSvEyvpwecUrmZ(IControllerTemplate parent, int id, string name, kKtogElfnRPvHjOtrzGjojowfKuh up, kKtogElfnRPvHjOtrzGjojowfKuh upRight, kKtogElfnRPvHjOtrzGjojowfKuh right, kKtogElfnRPvHjOtrzGjojowfKuh downRight, kKtogElfnRPvHjOtrzGjojowfKuh down, kKtogElfnRPvHjOtrzGjojowfKuh downLeft, kKtogElfnRPvHjOtrzGjojowfKuh left, kKtogElfnRPvHjOtrzGjojowfKuh upLeft)
				: this(parent, id, name, new iEqfnPyVaykuHTyaJUdgCaIMILT[8] { up, upRight, right, downRight, down, downLeft, left, upLeft })
			{
			}
		}

		internal sealed class FWRtnYAqWAhqvhOjdLVnOidGDlkf : ygclvLuOOzJkqmtRtpyXwsWVYPW, IControllerTemplateElement, IControllerTemplateYoke
		{
			private new const int EOmCscSleqEXYBFvClIphRYFPTUS = 2;

			public IControllerTemplateAxis rotation
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[0];
				}
			}

			public IControllerTemplateAxis pushPull
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (IControllerTemplateAxis)uGpQQIwzyDgccAzdMieIrottQjF[1];
				}
			}

			private FWRtnYAqWAhqvhOjdLVnOidGDlkf(IControllerTemplate parent, int id, string name, iEqfnPyVaykuHTyaJUdgCaIMILT[] elements)
				: base(parent, id, name, ControllerTemplateElementType.Yoke, elements)
			{
			}

			internal FWRtnYAqWAhqvhOjdLVnOidGDlkf(IControllerTemplate parent, int id, string name, kKtogElfnRPvHjOtrzGjojowfKuh rollAxis, kKtogElfnRPvHjOtrzGjojowfKuh pitchAxis)
				: base(parent, id, name, ControllerTemplateElementType.Yoke, new iEqfnPyVaykuHTyaJUdgCaIMILT[2] { rollAxis, pitchAxis })
			{
			}
		}

		internal sealed class xaKeDLujJddHfCwEpOSydYVefGpG : CqYFfsfyoldVPGcMOkIBuXlyRib, IControllerTemplateElement, IControllerTemplateStick6D
		{
			private new const int EOmCscSleqEXYBFvClIphRYFPTUS = 6;

			private xaKeDLujJddHfCwEpOSydYVefGpG(IControllerTemplate parent, int id, string name, iEqfnPyVaykuHTyaJUdgCaIMILT[] elements)
				: base(parent, id, name, ControllerTemplateElementType.Stick6D, elements)
			{
			}

			internal xaKeDLujJddHfCwEpOSydYVefGpG(IControllerTemplate parent, int id, string name, kKtogElfnRPvHjOtrzGjojowfKuh positionX, kKtogElfnRPvHjOtrzGjojowfKuh positionY, kKtogElfnRPvHjOtrzGjojowfKuh positionZ, kKtogElfnRPvHjOtrzGjojowfKuh rotationX, kKtogElfnRPvHjOtrzGjojowfKuh rotationY, kKtogElfnRPvHjOtrzGjojowfKuh rotationZ)
				: base(parent, id, name, ControllerTemplateElementType.Stick6D, new iEqfnPyVaykuHTyaJUdgCaIMILT[6] { positionX, positionY, positionZ, rotationX, rotationY, rotationZ })
			{
			}
		}

		internal class TxcDNzZFLyQuZzpHlbpSAqCYNDSa
		{
			public readonly Controller.Element ZFRkhXzoHYMYgVeQssKqOHKOPMF;

			public readonly IControllerElementTarget PXoaWZfLoapsgtctcTOzaohJoYM;

			public bool sErYZUSKRrHKzQAmqAzlnqtyZFH
			{
				get
				{
					if (ZFRkhXzoHYMYgVeQssKqOHKOPMF == null)
					{
						return false;
					}
					switch (ZFRkhXzoHYMYgVeQssKqOHKOPMF.type)
					{
					case ControllerElementType.Button:
						return (ZFRkhXzoHYMYgVeQssKqOHKOPMF as Controller.Button).value;
					case ControllerElementType.Axis:
					{
						float value = (ZFRkhXzoHYMYgVeQssKqOHKOPMF as Controller.Axis).value;
						switch (PXoaWZfLoapsgtctcTOzaohJoYM.axisRange)
						{
						case AxisRange.Full:
							if (value > 0.01f)
							{
								return true;
							}
							if (value < -0.01f)
							{
								return true;
							}
							break;
						case AxisRange.Positive:
							if (value > 0.01f)
							{
								return true;
							}
							break;
						case AxisRange.Negative:
							if (value < -0.01f)
							{
								return true;
							}
							break;
						}
						break;
					}
					}
					return false;
				}
			}

			public bool wBXhDMBBnoIQwyKJFdKmtKxXqEFc
			{
				get
				{
					if (ZFRkhXzoHYMYgVeQssKqOHKOPMF == null)
					{
						return false;
					}
					switch (ZFRkhXzoHYMYgVeQssKqOHKOPMF.type)
					{
					case ControllerElementType.Button:
						return (ZFRkhXzoHYMYgVeQssKqOHKOPMF as Controller.Button).valuePrev;
					case ControllerElementType.Axis:
					{
						float valuePrev = (ZFRkhXzoHYMYgVeQssKqOHKOPMF as Controller.Axis).valuePrev;
						switch (PXoaWZfLoapsgtctcTOzaohJoYM.axisRange)
						{
						case AxisRange.Full:
							if (valuePrev > 0.01f)
							{
								return true;
							}
							if (valuePrev < -0.01f)
							{
								return true;
							}
							break;
						case AxisRange.Positive:
							if (valuePrev > 0.01f)
							{
								return true;
							}
							break;
						case AxisRange.Negative:
							if (valuePrev < -0.01f)
							{
								return true;
							}
							break;
						}
						break;
					}
					}
					return false;
				}
			}

			public bool ackAfqTveINRnSkXedYMDkCbEItF
			{
				get
				{
					if (ZFRkhXzoHYMYgVeQssKqOHKOPMF == null)
					{
						return false;
					}
					switch (ZFRkhXzoHYMYgVeQssKqOHKOPMF.type)
					{
					case ControllerElementType.Button:
						return (ZFRkhXzoHYMYgVeQssKqOHKOPMF as Controller.Button).justPressed;
					case ControllerElementType.Axis:
						if (MathTools.Abs(kmXPJuboaoIZNVbNRjqsJUEhvKw) > 0.01f && MathTools.Abs(oPvBnhfzBnewBTjqFJnBJrgPNifn) <= 0.01f)
						{
							return true;
						}
						break;
					}
					return false;
				}
			}

			public bool lwYGtHhLAvocvsdFvNxxGuUzHyh
			{
				get
				{
					if (ZFRkhXzoHYMYgVeQssKqOHKOPMF == null)
					{
						return false;
					}
					switch (ZFRkhXzoHYMYgVeQssKqOHKOPMF.type)
					{
					case ControllerElementType.Button:
						return (ZFRkhXzoHYMYgVeQssKqOHKOPMF as Controller.Button).justReleased;
					case ControllerElementType.Axis:
						if (MathTools.Abs(kmXPJuboaoIZNVbNRjqsJUEhvKw) <= 0.01f && MathTools.Abs(oPvBnhfzBnewBTjqFJnBJrgPNifn) > 0.01f)
						{
							return true;
						}
						break;
					}
					return false;
				}
			}

			public float kmXPJuboaoIZNVbNRjqsJUEhvKw
			{
				get
				{
					if (ZFRkhXzoHYMYgVeQssKqOHKOPMF == null)
					{
						return 0f;
					}
					switch (ZFRkhXzoHYMYgVeQssKqOHKOPMF.type)
					{
					case ControllerElementType.Button:
						if (!(ZFRkhXzoHYMYgVeQssKqOHKOPMF as Controller.Button).value)
						{
							return 0f;
						}
						return 1f;
					case ControllerElementType.Axis:
					{
						float value = (ZFRkhXzoHYMYgVeQssKqOHKOPMF as Controller.Axis).value;
						switch (PXoaWZfLoapsgtctcTOzaohJoYM.axisRange)
						{
						case AxisRange.Full:
							return value;
						case AxisRange.Positive:
							if (value > 0f)
							{
								return value;
							}
							break;
						case AxisRange.Negative:
							if (value < 0f)
							{
								return value;
							}
							break;
						}
						break;
					}
					}
					return 0f;
				}
			}

			public float oPvBnhfzBnewBTjqFJnBJrgPNifn
			{
				get
				{
					if (ZFRkhXzoHYMYgVeQssKqOHKOPMF == null)
					{
						return 0f;
					}
					switch (ZFRkhXzoHYMYgVeQssKqOHKOPMF.type)
					{
					case ControllerElementType.Button:
						if (!(ZFRkhXzoHYMYgVeQssKqOHKOPMF as Controller.Button).valuePrev)
						{
							return 0f;
						}
						return 1f;
					case ControllerElementType.Axis:
					{
						float valuePrev = (ZFRkhXzoHYMYgVeQssKqOHKOPMF as Controller.Axis).valuePrev;
						switch (PXoaWZfLoapsgtctcTOzaohJoYM.axisRange)
						{
						case AxisRange.Full:
							return valuePrev;
						case AxisRange.Positive:
							if (valuePrev > 0f)
							{
								return valuePrev;
							}
							break;
						case AxisRange.Negative:
							if (valuePrev < 0f)
							{
								return valuePrev;
							}
							break;
						}
						break;
					}
					}
					return 0f;
				}
			}

			public TxcDNzZFLyQuZzpHlbpSAqCYNDSa(IControllerElementTarget target, Controller.Element element)
			{
				ZFRkhXzoHYMYgVeQssKqOHKOPMF = element;
				PXoaWZfLoapsgtctcTOzaohJoYM = target;
			}

			public static TxcDNzZFLyQuZzpHlbpSAqCYNDSa kbUEkrjNKrFkwKWFaqXQToCsrDji()
			{
				return new TxcDNzZFLyQuZzpHlbpSAqCYNDSa(bjWEjHBROAVpeyUanBwIblyUmUNK.kbUEkrjNKrFkwKWFaqXQToCsrDji(), null);
			}
		}

		internal class zuyOybsNXzJDbboyfSNQaXayOHC
		{
			public readonly Controller TWofsWdWcZrFDlgktqaiXknQuRD;

			public readonly IHardwareControllerTemplateMap_Internal ORYezKVnbuILuttizPBzlNYEKep;

			public zuyOybsNXzJDbboyfSNQaXayOHC(Controller controller, IHardwareControllerTemplateMap_Internal templateMap)
			{
				if (controller == null)
				{
					throw new ArgumentNullException("controller");
				}
				if (templateMap == null)
				{
					throw new ArgumentNullException("templateMap");
				}
				TWofsWdWcZrFDlgktqaiXknQuRD = controller;
				ORYezKVnbuILuttizPBzlNYEKep = templateMap;
			}
		}

		private readonly string cdTetXhABLRmOQUvcmFAFXpBMHcj;

		private readonly Guid BOWdlDjzpNpatmXRrjfUhzeDHxA;

		private readonly Controller bGNJaBTbykivsIWbGpkIOAQalRn;

		private readonly ADictionary<int, IControllerTemplateElement> MNRPnYEBYkxMIMNipiMDcVeeToEe;

		private readonly ADictionary<string, IControllerTemplateElement> aLuDObIvdTQfwwMYQqwVWYnrcmxG;

		private IControllerTemplateElement[] uGpQQIwzyDgccAzdMieIrottQjF;

		private ReadOnlyCollection<IControllerTemplateElement> EZanZBVAuiJIOisjNsKtlblpPjs;

		private readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

		Controller IControllerTemplate.controller
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return bGNJaBTbykivsIWbGpkIOAQalRn;
			}
		}

		string IControllerTemplate.name
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return cdTetXhABLRmOQUvcmFAFXpBMHcj;
			}
		}

		Guid IControllerTemplate.typeGuid
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return Guid.Empty;
				}
				return BOWdlDjzpNpatmXRrjfUhzeDHxA;
			}
		}

		IList<IControllerTemplateElement> IControllerTemplate.elements
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return EZanZBVAuiJIOisjNsKtlblpPjs;
			}
		}

		int IControllerTemplate.elementCount
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0;
				}
				return uGpQQIwzyDgccAzdMieIrottQjF.Length;
			}
		}

		protected ControllerTemplate(object payload)
			: this((zuyOybsNXzJDbboyfSNQaXayOHC)payload)
		{
		}

		private ControllerTemplate(zuyOybsNXzJDbboyfSNQaXayOHC initializer)
		{
			if (initializer == null)
			{
				throw new ArgumentNullException("initializer");
			}
			if (initializer.TWofsWdWcZrFDlgktqaiXknQuRD == null)
			{
				throw new ArgumentNullException("initializer.controller");
			}
			if (initializer.ORYezKVnbuILuttizPBzlNYEKep == null)
			{
				throw new ArgumentNullException("initializer.templateMap");
			}
			PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
			bGNJaBTbykivsIWbGpkIOAQalRn = initializer.TWofsWdWcZrFDlgktqaiXknQuRD;
			IHardwareControllerTemplateMap_Internal oRYezKVnbuILuttizPBzlNYEKep = initializer.ORYezKVnbuILuttizPBzlNYEKep;
			cdTetXhABLRmOQUvcmFAFXpBMHcj = oRYezKVnbuILuttizPBzlNYEKep.name;
			BOWdlDjzpNpatmXRrjfUhzeDHxA = oRYezKVnbuILuttizPBzlNYEKep.typeGuid;
			int elementIdentifierCount = oRYezKVnbuILuttizPBzlNYEKep.GetElementIdentifierCount();
			ADictionary<int, IControllerTemplateElement> aDictionary = new ADictionary<int, IControllerTemplateElement>();
			List<IControllerTemplateElement> list = new List<IControllerTemplateElement>();
			List<IControllerTemplateAxis> list2 = new List<IControllerTemplateAxis>();
			List<IControllerTemplateButton> list3 = new List<IControllerTemplateButton>();
			List<IControllerTemplateElement> list4 = new List<IControllerTemplateElement>();
			for (int i = 0; i < elementIdentifierCount; i++)
			{
				IControllerTemplateElementIdentifier templateElementIdentifier = oRYezKVnbuILuttizPBzlNYEKep.GetTemplateElementIdentifier(i);
				if (templateElementIdentifier != null && InputTools.IsMappableType(templateElementIdentifier.elementType))
				{
					switch (templateElementIdentifier.elementType)
					{
					case ControllerTemplateElementType.Axis:
					{
						UsMQnVXJOgAELSCkvEBzkFdKjFNq usMQnVXJOgAELSCkvEBzkFdKjFNq2 = oRYezKVnbuILuttizPBzlNYEKep.GetAxisTarget(bGNJaBTbykivsIWbGpkIOAQalRn, templateElementIdentifier.id) ?? UsMQnVXJOgAELSCkvEBzkFdKjFNq.kbUEkrjNKrFkwKWFaqXQToCsrDji(ControllerTemplateElementType.Axis);
						LwxsftUbYtbLZJdIYTUsTMZpsel item2 = new LwxsftUbYtbLZJdIYTUsTMZpsel(this, templateElementIdentifier.id, templateElementIdentifier.name, (!string.IsNullOrEmpty(templateElementIdentifier.positiveName)) ? templateElementIdentifier.positiveName : (templateElementIdentifier.name + " +"), (!string.IsNullOrEmpty(templateElementIdentifier.negativeName)) ? templateElementIdentifier.negativeName : (templateElementIdentifier.name + " -"), usMQnVXJOgAELSCkvEBzkFdKjFNq2, TyfCSDUtvrOCJCMSppBQJWeUoMO(bGNJaBTbykivsIWbGpkIOAQalRn, (IControllerTemplateAxisSource)usMQnVXJOgAELSCkvEBzkFdKjFNq2));
						list2.Add(item2);
						break;
					}
					case ControllerTemplateElementType.Button:
					{
						UsMQnVXJOgAELSCkvEBzkFdKjFNq usMQnVXJOgAELSCkvEBzkFdKjFNq = oRYezKVnbuILuttizPBzlNYEKep.GetButtonTarget(bGNJaBTbykivsIWbGpkIOAQalRn, templateElementIdentifier.id) ?? UsMQnVXJOgAELSCkvEBzkFdKjFNq.kbUEkrjNKrFkwKWFaqXQToCsrDji(ControllerTemplateElementType.Button);
						sBZjCcVfpldYYGibHbRAoFAsYTc item = new sBZjCcVfpldYYGibHbRAoFAsYTc(this, templateElementIdentifier.id, templateElementIdentifier.name, templateElementIdentifier.name, templateElementIdentifier.name + " -", usMQnVXJOgAELSCkvEBzkFdKjFNq, TyfCSDUtvrOCJCMSppBQJWeUoMO(bGNJaBTbykivsIWbGpkIOAQalRn, (IControllerTemplateButtonSource)usMQnVXJOgAELSCkvEBzkFdKjFNq));
						list3.Add(item);
						break;
					}
					default:
						throw new NotImplementedException();
					}
				}
			}
			for (int j = 0; j < list2.Count; j++)
			{
				list.Add(list2[j]);
			}
			for (int k = 0; k < list3.Count; k++)
			{
				list.Add(list3[k]);
			}
			for (int l = 0; l < list.Count; l++)
			{
				aDictionary.Add(list[l].id, list[l]);
			}
			for (int m = 0; m < elementIdentifierCount; m++)
			{
				IControllerTemplateElementIdentifier templateElementIdentifier2 = oRYezKVnbuILuttizPBzlNYEKep.GetTemplateElementIdentifier(m);
				if (templateElementIdentifier2 == null || InputTools.IsMappableType(templateElementIdentifier2.elementType))
				{
					continue;
				}
				IControllerTemplateMapSpecialElement_Internal specialTemplateElementByElementIdentifierId = oRYezKVnbuILuttizPBzlNYEKep.GetSpecialTemplateElementByElementIdentifierId(templateElementIdentifier2.id);
				iEqfnPyVaykuHTyaJUdgCaIMILT iEqfnPyVaykuHTyaJUdgCaIMILT;
				switch (templateElementIdentifier2.elementType)
				{
				case ControllerTemplateElementType.ThumbStick:
				{
					if (specialTemplateElementByElementIdentifierId == null)
					{
						Logger.LogError(string.Concat(templateElementIdentifier2.elementType, " element missing for Element Identifier Id ", templateElementIdentifier2.id));
					}
					ControllerTemplateThumbStickMapping mapping5 = specialTemplateElementByElementIdentifierId.GetMapping<ControllerTemplateThumbStickMapping>();
					iEqfnPyVaykuHTyaJUdgCaIMILT = new JSxhpGLucsoIfKKMFiQQGOfgDERd(this, templateElementIdentifier2.id, templateElementIdentifier2.name, (mapping5 != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping5.eid_axisX) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping5 != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping5.eid_axisY) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping5 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping5.eid_button) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this));
					break;
				}
				case ControllerTemplateElementType.DPad:
				{
					if (specialTemplateElementByElementIdentifierId == null)
					{
						Logger.LogError(string.Concat(templateElementIdentifier2.elementType, " element missing for Element Identifier Id ", templateElementIdentifier2.id));
					}
					ControllerTemplateDPadMapping mapping3 = specialTemplateElementByElementIdentifierId.GetMapping<ControllerTemplateDPadMapping>();
					iEqfnPyVaykuHTyaJUdgCaIMILT = new bvOrjHwPVdCJEYrttjjPJgjXlmB(this, templateElementIdentifier2.id, templateElementIdentifier2.name, (mapping3 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping3.eid_up) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping3 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping3.eid_right) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping3 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping3.eid_down) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping3 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping3.eid_left) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping3 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping3.eid_press) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this));
					break;
				}
				case ControllerTemplateElementType.Stick:
				{
					if (specialTemplateElementByElementIdentifierId == null)
					{
						Logger.LogError(string.Concat(templateElementIdentifier2.elementType, " element missing for Element Identifier Id ", templateElementIdentifier2.id));
					}
					ControllerTemplateStickMapping mapping2 = specialTemplateElementByElementIdentifierId.GetMapping<ControllerTemplateStickMapping>();
					iEqfnPyVaykuHTyaJUdgCaIMILT = new WPQSJwnRlTusPbzGefWRPGKpXAe(this, templateElementIdentifier2.id, templateElementIdentifier2.name, (mapping2 != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping2.eid_axisX) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping2 != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping2.eid_axisY) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping2 != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping2.eid_axisZ) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this));
					break;
				}
				case ControllerTemplateElementType.Throttle:
				{
					if (specialTemplateElementByElementIdentifierId == null)
					{
						Logger.LogError(string.Concat(templateElementIdentifier2.elementType, " element missing for Element Identifier Id ", templateElementIdentifier2.id));
					}
					ControllerTemplateThrottleMapping mapping6 = specialTemplateElementByElementIdentifierId.GetMapping<ControllerTemplateThrottleMapping>();
					iEqfnPyVaykuHTyaJUdgCaIMILT = new szcwMpblLfcMpiJYVDrSIwmXThf(this, templateElementIdentifier2.id, templateElementIdentifier2.name, (mapping6 != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping6.eid_axis) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping6 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping6.eid_minDetent) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this));
					break;
				}
				case ControllerTemplateElementType.Hat:
				{
					if (specialTemplateElementByElementIdentifierId == null)
					{
						Logger.LogError(string.Concat(templateElementIdentifier2.elementType, " element missing for Element Identifier Id ", templateElementIdentifier2.id));
					}
					ControllerTemplateHatMapping mapping7 = specialTemplateElementByElementIdentifierId.GetMapping<ControllerTemplateHatMapping>();
					iEqfnPyVaykuHTyaJUdgCaIMILT = new TUYsXdEShZxWmJSvEyvpwecUrmZ(this, templateElementIdentifier2.id, templateElementIdentifier2.name, (mapping7 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping7.eid_up) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping7 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping7.eid_upRight) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping7 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping7.eid_right) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping7 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping7.eid_downRight) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping7 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping7.eid_down) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping7 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping7.eid_downLeft) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping7 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping7.eid_left) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping7 != null) ? bxMoFoqvmPaQLIJckPsRmJGDrlE(this, aDictionary, mapping7.eid_upLeft) : sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(this));
					break;
				}
				case ControllerTemplateElementType.Yoke:
				{
					if (specialTemplateElementByElementIdentifierId == null)
					{
						Logger.LogError(string.Concat(templateElementIdentifier2.elementType, " element missing for Element Identifier Id ", templateElementIdentifier2.id));
					}
					ControllerTemplateYokeMapping mapping4 = specialTemplateElementByElementIdentifierId.GetMapping<ControllerTemplateYokeMapping>();
					iEqfnPyVaykuHTyaJUdgCaIMILT = new FWRtnYAqWAhqvhOjdLVnOidGDlkf(this, templateElementIdentifier2.id, templateElementIdentifier2.name, (mapping4 != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping4.eid_axisX) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping4 != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping4.eid_axisZ) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this));
					break;
				}
				case ControllerTemplateElementType.Stick6D:
				{
					if (specialTemplateElementByElementIdentifierId == null)
					{
						Logger.LogError(string.Concat(templateElementIdentifier2.elementType, " element missing for Element Identifier Id ", templateElementIdentifier2.id));
					}
					ControllerTemplateStick6DMapping mapping = specialTemplateElementByElementIdentifierId.GetMapping<ControllerTemplateStick6DMapping>();
					iEqfnPyVaykuHTyaJUdgCaIMILT = new xaKeDLujJddHfCwEpOSydYVefGpG(this, templateElementIdentifier2.id, templateElementIdentifier2.name, (mapping != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping.eid_positionX) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping.eid_positionY) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping.eid_positionZ) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping.eid_rotationX) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping.eid_rotationY) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this), (mapping != null) ? QiTgPtrvrUhAiVvSOaQLpPDKXUt(this, aDictionary, mapping.eid_rotationZ) : LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(this));
					break;
				}
				default:
					throw new NotImplementedException();
				}
				if (iEqfnPyVaykuHTyaJUdgCaIMILT != null)
				{
					list4.Add(iEqfnPyVaykuHTyaJUdgCaIMILT);
				}
			}
			for (int n = 0; n < list4.Count; n++)
			{
				list.Add(list4[n]);
				aDictionary.Add(list4[n].id, list4[n]);
			}
			uGpQQIwzyDgccAzdMieIrottQjF = list.ToArray();
			MNRPnYEBYkxMIMNipiMDcVeeToEe = aDictionary;
			aLuDObIvdTQfwwMYQqwVWYnrcmxG = new ADictionary<string, IControllerTemplateElement>();
			for (int num = 0; num < uGpQQIwzyDgccAzdMieIrottQjF.Length; num++)
			{
				if (!(oRYezKVnbuILuttizPBzlNYEKep.GetTemplateElementIdentifierById(uGpQQIwzyDgccAzdMieIrottQjF[num].id) is IControllerTemplateElementIdentifier_Editor controllerTemplateElementIdentifier_Editor))
				{
					continue;
				}
				for (int num2 = 0; num2 < 2; num2++)
				{
					string text = ((num2 != 0) ? controllerTemplateElementIdentifier_Editor.alternateScriptingName : controllerTemplateElementIdentifier_Editor.scriptingName);
					if (!string.IsNullOrEmpty(text))
					{
						try
						{
							aLuDObIvdTQfwwMYQqwVWYnrcmxG.Add(text, uGpQQIwzyDgccAzdMieIrottQjF[num]);
						}
						catch
						{
							Logger.LogError("A duplicate Controller Template element scripting name (" + text + ") was found in template " + cdTetXhABLRmOQUvcmFAFXpBMHcj + ". This element should be renamed to a unique name.");
						}
					}
				}
			}
			EZanZBVAuiJIOisjNsKtlblpPjs = new ReadOnlyCollection<IControllerTemplateElement>(uGpQQIwzyDgccAzdMieIrottQjF);
		}

		protected IControllerTemplateElement GetElement(int id)
		{
			if (!MNRPnYEBYkxMIMNipiMDcVeeToEe.TryGetValue(id, out var value))
			{
				Logger.LogWarning("There is no element with the id \"" + id + "\" in the " + GetType().ToString() + ".");
			}
			return value;
		}

		protected T GetElement<T>(int id) where T : class, IControllerTemplateElement
		{
			return GetElement(id) as T;
		}

		private IControllerTemplateElement hmaLqUvfuXDIpvReUhFadYCvcoRH(int P_0)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			return GetElement(P_0);
		}

		IControllerTemplateElement IControllerTemplate.GetElement(int P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in hmaLqUvfuXDIpvReUhFadYCvcoRH
			return this.hmaLqUvfuXDIpvReUhFadYCvcoRH(P_0);
		}

		private T hmaLqUvfuXDIpvReUhFadYCvcoRH<T>(int P_0) where T : class, IControllerTemplateElement
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			return GetElement<T>(P_0);
		}

		T IControllerTemplate.GetElement<T>(int P_0) where T : class, IControllerTemplateElement
		{
			//ILSpy generated this explicit interface implementation from .override directive in hmaLqUvfuXDIpvReUhFadYCvcoRH
			return this.hmaLqUvfuXDIpvReUhFadYCvcoRH<T>(P_0);
		}

		private int qWKrwQtmrhCcOBsahlolwLWRLpB(ControllerElementTarget P_0, IList<ControllerTemplateElementTarget> P_1)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			if (P_1 == null)
			{
				throw new ArgumentNullException("results");
			}
			return oDGaJxsQWyutwAVTwqIhCBLJHpk(P_0, ref P_1);
		}

		int IControllerTemplate.GetElementTargets(ControllerElementTarget P_0, IList<ControllerTemplateElementTarget> P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in qWKrwQtmrhCcOBsahlolwLWRLpB
			return this.qWKrwQtmrhCcOBsahlolwLWRLpB(P_0, P_1);
		}

		private int oDGaJxsQWyutwAVTwqIhCBLJHpk(ControllerElementTarget P_0, ref IList<ControllerTemplateElementTarget> P_1)
		{
			if (P_1 != null)
			{
				P_1.Clear();
			}
			int num = 0;
			for (int i = 0; i < uGpQQIwzyDgccAzdMieIrottQjF.Length; i++)
			{
				if (InputTools.IsMappableType(uGpQQIwzyDgccAzdMieIrottQjF[i].type))
				{
					num += (uGpQQIwzyDgccAzdMieIrottQjF[i] as IControllerTemplateElement_Internal).GetElementTargets(P_0, ref P_1);
				}
			}
			return num;
		}

		[CustomObfuscation(rename = false)]
		internal static Type GetInterfaceType(ControllerTemplateElementType elementType)
		{
			return elementType switch
			{
				ControllerTemplateElementType.Axis => typeof(IControllerTemplateAxis), 
				ControllerTemplateElementType.Button => typeof(IControllerTemplateButton), 
				ControllerTemplateElementType.ThumbStick => typeof(IControllerTemplateThumbStick), 
				ControllerTemplateElementType.DPad => typeof(IControllerTemplateDPad), 
				ControllerTemplateElementType.Stick => typeof(IControllerTemplateStick), 
				ControllerTemplateElementType.Throttle => typeof(IControllerTemplateThrottle), 
				ControllerTemplateElementType.Hat => typeof(IControllerTemplateHat), 
				ControllerTemplateElementType.Yoke => typeof(IControllerTemplateYoke), 
				ControllerTemplateElementType.Stick6D => typeof(IControllerTemplateStick6D), 
				_ => throw new NotImplementedException(), 
			};
		}

		private static IList<TxcDNzZFLyQuZzpHlbpSAqCYNDSa> TyfCSDUtvrOCJCMSppBQJWeUoMO(Controller P_0, IControllerTemplateAxisSource P_1)
		{
			if (P_1 == null)
			{
				return null;
			}
			if (P_1.splitAxis)
			{
				IList<TxcDNzZFLyQuZzpHlbpSAqCYNDSa> list = null;
				bool flag = false;
				if (P_1.positiveTarget != null)
				{
					Controller.Element elementById = P_0.GetElementById(P_1.positiveTarget.elementIdentifierId);
					if (elementById != null)
					{
						ListTools.AddAndCreateList(ref list, new TxcDNzZFLyQuZzpHlbpSAqCYNDSa(P_1.positiveTarget, elementById));
						flag = true;
					}
				}
				if (!flag)
				{
					ListTools.AddAndCreateList(ref list, TxcDNzZFLyQuZzpHlbpSAqCYNDSa.kbUEkrjNKrFkwKWFaqXQToCsrDji());
				}
				flag = false;
				if (P_1.negativeTarget != null)
				{
					Controller.Element elementById2 = P_0.GetElementById(P_1.negativeTarget.elementIdentifierId);
					if (elementById2 != null)
					{
						ListTools.AddAndCreateList(ref list, new TxcDNzZFLyQuZzpHlbpSAqCYNDSa(P_1.negativeTarget, elementById2));
						flag = true;
					}
				}
				if (!flag)
				{
					ListTools.AddAndCreateList(ref list, TxcDNzZFLyQuZzpHlbpSAqCYNDSa.kbUEkrjNKrFkwKWFaqXQToCsrDji());
				}
				return list;
			}
			return TyfCSDUtvrOCJCMSppBQJWeUoMO(P_0, P_1.fullTarget);
		}

		private static IList<TxcDNzZFLyQuZzpHlbpSAqCYNDSa> TyfCSDUtvrOCJCMSppBQJWeUoMO(Controller P_0, IControllerTemplateButtonSource P_1)
		{
			if (P_1 == null)
			{
				return null;
			}
			return TyfCSDUtvrOCJCMSppBQJWeUoMO(P_0, P_1.target);
		}

		private static IList<TxcDNzZFLyQuZzpHlbpSAqCYNDSa> TyfCSDUtvrOCJCMSppBQJWeUoMO(Controller P_0, IControllerElementTarget P_1)
		{
			if (P_1 == null)
			{
				return null;
			}
			Controller.Element elementById = P_0.GetElementById(P_1.elementIdentifierId);
			if (elementById == null)
			{
				return null;
			}
			List<TxcDNzZFLyQuZzpHlbpSAqCYNDSa> list = new List<TxcDNzZFLyQuZzpHlbpSAqCYNDSa>();
			list.Add(new TxcDNzZFLyQuZzpHlbpSAqCYNDSa(P_1, elementById));
			return list;
		}

		private static IControllerTemplateElement xiuIeYHJXYdmseVGSxINjvDbpKI(List<IControllerTemplateElement> P_0, int P_1)
		{
			int count = P_0.Count;
			for (int i = 0; i < count; i++)
			{
				if (P_0[i].id == P_1)
				{
					return P_0[i];
				}
			}
			return null;
		}

		private static kKtogElfnRPvHjOtrzGjojowfKuh QiTgPtrvrUhAiVvSOaQLpPDKXUt(IControllerTemplate P_0, ADictionary<int, IControllerTemplateElement> P_1, int P_2)
		{
			if (!(P_1.GetValueSafe(P_2) is kKtogElfnRPvHjOtrzGjojowfKuh result))
			{
				return LwxsftUbYtbLZJdIYTUsTMZpsel.kbUEkrjNKrFkwKWFaqXQToCsrDji(P_0);
			}
			return result;
		}

		private static kKtogElfnRPvHjOtrzGjojowfKuh bxMoFoqvmPaQLIJckPsRmJGDrlE(IControllerTemplate P_0, ADictionary<int, IControllerTemplateElement> P_1, int P_2)
		{
			if (!(P_1.GetValueSafe(P_2) is kKtogElfnRPvHjOtrzGjojowfKuh result))
			{
				return sBZjCcVfpldYYGibHbRAoFAsYTc.kbUEkrjNKrFkwKWFaqXQToCsrDji(P_0);
			}
			return result;
		}
	}
}
