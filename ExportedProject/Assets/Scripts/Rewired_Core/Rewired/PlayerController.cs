using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	public class PlayerController : IPlayerController
	{
		public class Definition
		{
			public bool enabled = true;

			public int playerId = -1;

			public ICollection<Element.Definition> elements;
		}

		public static class Factory
		{
			public static PlayerController Create(Definition definition)
			{
				return new PlayerController(definition);
			}
		}

		public abstract class Element
		{
			[CustomObfuscation(rename = false)]
			internal enum Type
			{
				[CustomObfuscation(rename = false)]
				Button = 0,
				[CustomObfuscation(rename = false)]
				Axis = 1,
				[CustomObfuscation(rename = false)]
				MouseAxis = 2,
				[CustomObfuscation(rename = false)]
				MouseWheelAxis = 3,
				[CustomObfuscation(rename = false)]
				Axis2D = 100,
				[CustomObfuscation(rename = false)]
				MouseAxis2D = 101,
				[CustomObfuscation(rename = false)]
				MouseWheel = 102
			}

			[CustomObfuscation(rename = false)]
			internal enum TypeWithSource
			{
				[CustomObfuscation(rename = false)]
				Button = 0,
				[CustomObfuscation(rename = false)]
				Axis = 1,
				[CustomObfuscation(rename = false)]
				MouseAxis = 2,
				[CustomObfuscation(rename = false)]
				MouseWheelAxis = 3
			}

			[CustomObfuscation(rename = false)]
			internal enum CompoundTypes
			{
				[CustomObfuscation(rename = false)]
				Axis2D = 100,
				[CustomObfuscation(rename = false)]
				MouseAxis2D = 101,
				[CustomObfuscation(rename = false)]
				MouseWheel = 102
			}

			public abstract class Definition
			{
				public bool enabled;

				public string name;

				public Definition()
				{
					enabled = true;
					name = null;
				}

				internal abstract Element WPECLgBucUixAUfvtkXWqQIjMNXU(PlayerController P_0);
			}

			internal struct ovniMRpSrNuJsnrcPCxGGoPpcTv
			{
				public ControllerElementType DffVgxLTxGtWFSQnSTfYIAPKKDj;

				public int MfVGCAceIAkEXxwxwAsLGoqQvdj;

				public float foSRcEqSuRsWnadDiKcGnhBewOU;

				public ovniMRpSrNuJsnrcPCxGGoPpcTv(ControllerElementType elementType, int index, float value)
				{
					DffVgxLTxGtWFSQnSTfYIAPKKDj = elementType;
					MfVGCAceIAkEXxwxwAsLGoqQvdj = index;
					foSRcEqSuRsWnadDiKcGnhBewOU = value;
				}
			}

			[CustomObfuscation(rename = false)]
			internal const bool defaultEnabled = true;

			private readonly PlayerController nJGvFkewuzWileOgdgvLxwmBPEU;

			private bool UMDVUZPvnJlOtLkXDrjEfgQiAko;

			private bool nZTtfeZBpthDaoAvSONdTABGEaM = true;

			private string cdTetXhABLRmOQUvcmFAFXpBMHcj;

			private static int[] fcjPHyvFLxtgitTzwjWKDSXOoPs;

			private static int[] dHrNcTOpjwmFFxizLUOAbWSeTKH;

			protected Player player
			{
				get
				{
					if (!ReInput.isReady)
					{
						return null;
					}
					return ReInput.players.GetPlayer(nJGvFkewuzWileOgdgvLxwmBPEU.IUWpTXMJPIJwDJdybAJNwpRpcYp);
				}
			}

			protected bool selfAndParentEnabled
			{
				get
				{
					if (nZTtfeZBpthDaoAvSONdTABGEaM)
					{
						return nJGvFkewuzWileOgdgvLxwmBPEU.nZTtfeZBpthDaoAvSONdTABGEaM;
					}
					return false;
				}
			}

			internal bool isMemberElement
			{
				get
				{
					return UMDVUZPvnJlOtLkXDrjEfgQiAko;
				}
				set
				{
					UMDVUZPvnJlOtLkXDrjEfgQiAko = true;
				}
			}

			public bool enabled
			{
				get
				{
					return nZTtfeZBpthDaoAvSONdTABGEaM;
				}
				set
				{
					if (nZTtfeZBpthDaoAvSONdTABGEaM != value)
					{
						nZTtfeZBpthDaoAvSONdTABGEaM = value;
						EnabledStateChanged(value);
					}
				}
			}

			public string name
			{
				get
				{
					return cdTetXhABLRmOQUvcmFAFXpBMHcj;
				}
				set
				{
					cdTetXhABLRmOQUvcmFAFXpBMHcj = value;
				}
			}

			internal Element(PlayerController parent, Definition definition)
			{
				if (parent == null)
				{
					throw new ArgumentNullException("parent");
				}
				if (definition == null)
				{
					throw new ArgumentNullException("definition");
				}
				nJGvFkewuzWileOgdgvLxwmBPEU = parent;
				nZTtfeZBpthDaoAvSONdTABGEaM = definition.enabled;
			}

			internal virtual void mtiNfGzpXHszOwiOIAVYQuMZclV()
			{
			}

			protected virtual void EnabledStateChanged(bool state)
			{
			}

			[CustomObfuscation(rename = false)]
			internal static bool IsTypeWithSource(Type type)
			{
				if (fcjPHyvFLxtgitTzwjWKDSXOoPs == null)
				{
					fcjPHyvFLxtgitTzwjWKDSXOoPs = (int[])Enum.GetValues(typeof(TypeWithSource));
				}
				return ArrayTools.Contains(fcjPHyvFLxtgitTzwjWKDSXOoPs, (int)type);
			}

			[CustomObfuscation(rename = false)]
			internal static bool IsCompoundType(Type type)
			{
				if (dHrNcTOpjwmFFxizLUOAbWSeTKH == null)
				{
					dHrNcTOpjwmFFxizLUOAbWSeTKH = (int[])Enum.GetValues(typeof(CompoundTypes));
				}
				return ArrayTools.Contains(dHrNcTOpjwmFFxizLUOAbWSeTKH, (int)type);
			}

			[CustomObfuscation(rename = false)]
			internal static int GetMaxElementCount(Type type)
			{
				if (IsTypeWithSource(type))
				{
					return 1;
				}
				if (IsCompoundType(type))
				{
					return type switch
					{
						Type.Axis2D => 2, 
						Type.MouseAxis2D => 2, 
						Type.MouseWheel => 2, 
						_ => throw new NotImplementedException(), 
					};
				}
				throw new NotImplementedException();
			}

			[CustomObfuscation(rename = false)]
			internal static string GetElementTitle(Type type, int index)
			{
				if (index < 0 || index > GetMaxElementCount(type))
				{
					return null;
				}
				if (IsTypeWithSource(type))
				{
					return null;
				}
				if (IsCompoundType(type))
				{
					switch (type)
					{
					case Type.Axis2D:
					case Type.MouseAxis2D:
					case Type.MouseWheel:
						if (index != 0)
						{
							return "Y Axis";
						}
						return "X Axis";
					default:
						throw new NotImplementedException();
					}
				}
				throw new NotImplementedException();
			}

			[CustomObfuscation(rename = false)]
			internal static Definition CreateDefinition(Type type)
			{
				return type switch
				{
					Type.Axis => new Axis.Definition(), 
					Type.Button => new Button.Definition(), 
					Type.MouseAxis => new MouseAxis.Definition(), 
					Type.MouseWheelAxis => new MouseWheelAxis.Definition(), 
					Type.Axis2D => new Axis2D.Definition(), 
					Type.MouseAxis2D => new MouseAxis2D.Definition(), 
					Type.MouseWheel => new MouseWheel.Definition(), 
					_ => throw new NotImplementedException(), 
				};
			}
		}

		public abstract class ElementWithSource : Element
		{
			public new abstract class Definition : Element.Definition
			{
				private int ARWjGDZdsNDKyFWsMDftBeVIijxg;

				public int actionId
				{
					get
					{
						return ARWjGDZdsNDKyFWsMDftBeVIijxg;
					}
					set
					{
						ARWjGDZdsNDKyFWsMDftBeVIijxg = value;
					}
				}

				public string actionName
				{
					get
					{
						if (!ReInput.isReady || ARWjGDZdsNDKyFWsMDftBeVIijxg < 0)
						{
							return null;
						}
						return ReInput.mapping.GetAction(ARWjGDZdsNDKyFWsMDftBeVIijxg)?.name;
					}
					set
					{
						if (!ReInput.isReady)
						{
							Logger.LogError("You cannot set an Action Name because Rewired has not been intialized.");
							return;
						}
						InputAction action = ReInput.mapping.GetAction(value);
						if (action == null)
						{
							ARWjGDZdsNDKyFWsMDftBeVIijxg = -1;
						}
						else
						{
							ARWjGDZdsNDKyFWsMDftBeVIijxg = action.id;
						}
					}
				}

				public Definition()
				{
					ARWjGDZdsNDKyFWsMDftBeVIijxg = -1;
				}
			}

			[CustomObfuscation(rename = false)]
			internal const int defaultActionId = -1;

			private int ARWjGDZdsNDKyFWsMDftBeVIijxg = -1;

			public int actionId
			{
				get
				{
					return ARWjGDZdsNDKyFWsMDftBeVIijxg;
				}
				set
				{
					ARWjGDZdsNDKyFWsMDftBeVIijxg = value;
				}
			}

			public string actionName
			{
				get
				{
					if (!ReInput.isReady || ARWjGDZdsNDKyFWsMDftBeVIijxg < 0)
					{
						return null;
					}
					return ReInput.mapping.GetAction(ARWjGDZdsNDKyFWsMDftBeVIijxg)?.name;
				}
				set
				{
					if (ReInput.isReady)
					{
						InputAction action = ReInput.mapping.GetAction(value);
						if (action == null)
						{
							ARWjGDZdsNDKyFWsMDftBeVIijxg = -1;
						}
						else
						{
							ARWjGDZdsNDKyFWsMDftBeVIijxg = action.id;
						}
					}
				}
			}

			internal ElementWithSource(PlayerController parent, Definition definition)
				: base(parent, definition)
			{
				ARWjGDZdsNDKyFWsMDftBeVIijxg = definition.actionId;
			}
		}

		public class Axis : ElementWithSource
		{
			public new class Definition : ElementWithSource.Definition
			{
				public AxisCoordinateMode coordinateMode;

				public float absoluteToRelativeSensitivity;

				public Definition()
				{
					coordinateMode = AxisCoordinateMode.Absolute;
					absoluteToRelativeSensitivity = 1f;
				}

				internal override Element WPECLgBucUixAUfvtkXWqQIjMNXU(PlayerController P_0)
				{
					return new Axis(P_0, this);
				}
			}

			internal const float iSzDckaYGUWUvjEABOdKmpasCiQ = 1f;

			[CustomObfuscation(rename = false)]
			internal const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Absolute;

			private float jjSsSiLyKDDCNKkwZMtKaipWiOZ = 1f;

			private AxisCoordinateMode ZVLTRgLPqNRIcPmAXddKzlALqjj;

			public float absoluteToRelativeSensitivity
			{
				get
				{
					return jjSsSiLyKDDCNKkwZMtKaipWiOZ;
				}
				set
				{
					if (value < 0f)
					{
						value = 0f;
					}
					jjSsSiLyKDDCNKkwZMtKaipWiOZ = value;
				}
			}

			public AxisCoordinateMode coordinateMode => ZVLTRgLPqNRIcPmAXddKzlALqjj;

			public virtual float value
			{
				get
				{
					if (!base.selfAndParentEnabled || base.player == null)
					{
						return 0f;
					}
					float num = base.player.GetAxis(base.actionId);
					switch (base.player.GetAxisCoordinateMode(base.actionId))
					{
					case AxisCoordinateMode.Relative:
						if (ZVLTRgLPqNRIcPmAXddKzlALqjj == AxisCoordinateMode.Absolute)
						{
							return 0f;
						}
						break;
					case AxisCoordinateMode.Absolute:
						if (ZVLTRgLPqNRIcPmAXddKzlALqjj == AxisCoordinateMode.Relative)
						{
							num *= (float)ReInput.unscaledDeltaTime * jjSsSiLyKDDCNKkwZMtKaipWiOZ;
						}
						break;
					}
					return num;
				}
			}

			public virtual float valueRaw
			{
				get
				{
					if (!base.selfAndParentEnabled || base.player == null)
					{
						return 0f;
					}
					return base.player.GetAxisRaw(base.actionId);
				}
			}

			internal Axis(PlayerController parent, Definition definition)
				: base(parent, definition)
			{
				jjSsSiLyKDDCNKkwZMtKaipWiOZ = definition.absoluteToRelativeSensitivity;
				ZVLTRgLPqNRIcPmAXddKzlALqjj = definition.coordinateMode;
			}
		}

		public class MouseAxis : Axis
		{
			public new class Definition : Axis.Definition
			{
				public Definition()
				{
					coordinateMode = AxisCoordinateMode.Relative;
					absoluteToRelativeSensitivity = 600f;
				}

				internal override Element WPECLgBucUixAUfvtkXWqQIjMNXU(PlayerController P_0)
				{
					return new MouseAxis(P_0, this);
				}
			}

			[CustomObfuscation(rename = false)]
			internal new const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Relative;

			[CustomObfuscation(rename = false)]
			internal const float defaultAbsoluteToRelativeSensitivity = 600f;

			public override float value
			{
				get
				{
					float num = base.value;
					if (num == 0f)
					{
						return 0f;
					}
					if (base.coordinateMode == AxisCoordinateMode.Relative && base.player.GetAxisCoordinateMode(base.actionId) == AxisCoordinateMode.Absolute)
					{
						num *= (float)Screen.currentResolution.width / 1920f;
					}
					return num;
				}
			}

			internal MouseAxis(PlayerController parent, Definition definition)
				: base(parent, definition)
			{
			}
		}

		public abstract class CompoundElement : Element
		{
			public new abstract class Definition : Element.Definition
			{
				public Definition()
				{
				}
			}

			private readonly List<Element> uGpQQIwzyDgccAzdMieIrottQjF;

			internal int elementCount => uGpQQIwzyDgccAzdMieIrottQjF.Count;

			internal CompoundElement(PlayerController parent, Definition definition, Element.Definition[] elementDefinitions)
				: base(parent, definition)
			{
				uGpQQIwzyDgccAzdMieIrottQjF = new List<Element>();
				if (elementDefinitions == null)
				{
					return;
				}
				for (int i = 0; i < elementDefinitions.Length; i++)
				{
					if (elementDefinitions[i] != null)
					{
						WqsdoDpSvzDOWFFxuzffBuWiPsvG(elementDefinitions[i].WPECLgBucUixAUfvtkXWqQIjMNXU(parent));
					}
				}
			}

			internal T eCWODyubZajVwOmkGSFXlCGBdhT<T>(int P_0) where T : Element
			{
				if ((uint)P_0 >= (uint)uGpQQIwzyDgccAzdMieIrottQjF.Count)
				{
					return null;
				}
				return uGpQQIwzyDgccAzdMieIrottQjF[P_0] as T;
			}

			internal void hbJjHqDqEmQCGFttwvYMHMLbhD(List<Element> P_0)
			{
				for (int i = 0; i < uGpQQIwzyDgccAzdMieIrottQjF.Count; i++)
				{
					if (uGpQQIwzyDgccAzdMieIrottQjF[i] is CompoundElement)
					{
						(uGpQQIwzyDgccAzdMieIrottQjF[i] as CompoundElement).hbJjHqDqEmQCGFttwvYMHMLbhD(P_0);
					}
					else
					{
						P_0.Add(uGpQQIwzyDgccAzdMieIrottQjF[i]);
					}
				}
			}

			internal void WqsdoDpSvzDOWFFxuzffBuWiPsvG(Element P_0)
			{
				if (P_0 == null)
				{
					throw new ArgumentNullException("element");
				}
				uGpQQIwzyDgccAzdMieIrottQjF.Add(P_0);
				P_0.isMemberElement = true;
			}
		}

		public class Axis2D : CompoundElement
		{
			public new class Definition : CompoundElement.Definition
			{
				private Axis.Definition xOXXmkWgHtOuXYKaXguPqBGjCAcK;

				private Axis.Definition jPGdwLDOLmxDesttUPPHZtMIIup;

				public Axis.Definition xAxis
				{
					get
					{
						return xOXXmkWgHtOuXYKaXguPqBGjCAcK;
					}
					set
					{
						xOXXmkWgHtOuXYKaXguPqBGjCAcK = value;
					}
				}

				public Axis.Definition yAxis
				{
					get
					{
						return jPGdwLDOLmxDesttUPPHZtMIIup;
					}
					set
					{
						jPGdwLDOLmxDesttUPPHZtMIIup = value;
					}
				}

				internal override Element WPECLgBucUixAUfvtkXWqQIjMNXU(PlayerController P_0)
				{
					return new Axis2D(P_0, this);
				}
			}

			internal const int PaoklvxlBxonYxtsHltcNxJXyoy = 0;

			internal const int FqbWMqOeCUXhvfSwhWnONHKdCVo = 1;

			internal const int RCOaFZSvnpHitKxuywWvAmCQNDKG = 2;

			public Axis xAxis => eCWODyubZajVwOmkGSFXlCGBdhT<Axis>(0);

			public Axis yAxis => eCWODyubZajVwOmkGSFXlCGBdhT<Axis>(1);

			public virtual Vector2 value => new Vector2(eCWODyubZajVwOmkGSFXlCGBdhT<Axis>(0).value, eCWODyubZajVwOmkGSFXlCGBdhT<Axis>(1).value);

			public virtual Vector2 valueRaw => new Vector2(eCWODyubZajVwOmkGSFXlCGBdhT<Axis>(0).valueRaw, eCWODyubZajVwOmkGSFXlCGBdhT<Axis>(1).valueRaw);

			internal Axis2D(PlayerController parent, Definition definition, Element.Definition[] definitions)
				: base(parent, definition, definitions)
			{
			}

			internal Axis2D(PlayerController parent, Definition definition)
				: base(parent, definition, (definition != null) ? new Element.Definition[2]
				{
					(definition.xAxis != null) ? definition.xAxis : new Axis.Definition(),
					(definition.yAxis != null) ? definition.yAxis : new Axis.Definition()
				} : null)
			{
			}
		}

		public sealed class MouseAxis2D : Axis2D
		{
			public new class Definition : Axis2D.Definition
			{
				public new MouseAxis.Definition xAxis
				{
					get
					{
						return base.xAxis as MouseAxis.Definition;
					}
					set
					{
						base.xAxis = value;
					}
				}

				public new MouseAxis.Definition yAxis
				{
					get
					{
						return base.yAxis as MouseAxis.Definition;
					}
					set
					{
						base.yAxis = value;
					}
				}

				internal override Element WPECLgBucUixAUfvtkXWqQIjMNXU(PlayerController P_0)
				{
					return new MouseAxis2D(P_0, this);
				}
			}

			public new MouseAxis xAxis => eCWODyubZajVwOmkGSFXlCGBdhT<MouseAxis>(0);

			public new MouseAxis yAxis => eCWODyubZajVwOmkGSFXlCGBdhT<MouseAxis>(1);

			internal MouseAxis2D(PlayerController parent, Definition definition)
				: base(parent, definition, (definition != null) ? new Element.Definition[2]
				{
					(definition.xAxis != null) ? definition.xAxis : new MouseAxis.Definition(),
					(definition.yAxis != null) ? definition.yAxis : new MouseAxis.Definition()
				} : null)
			{
			}
		}

		public sealed class Button : ElementWithSource
		{
			public new class Definition : ElementWithSource.Definition
			{
				internal override Element WPECLgBucUixAUfvtkXWqQIjMNXU(PlayerController P_0)
				{
					return new Button(P_0, this);
				}
			}

			public bool value
			{
				get
				{
					if (!base.selfAndParentEnabled || base.player == null)
					{
						return false;
					}
					return base.player.GetButton(base.actionId);
				}
			}

			public bool valuePrev
			{
				get
				{
					if (!base.selfAndParentEnabled || base.player == null)
					{
						return false;
					}
					return base.player.GetButtonPrev(base.actionId);
				}
			}

			public bool justPressed
			{
				get
				{
					if (!base.selfAndParentEnabled || base.player == null)
					{
						return false;
					}
					return base.player.GetButtonDown(base.actionId);
				}
			}

			public bool justReleased
			{
				get
				{
					if (!base.selfAndParentEnabled || base.player == null)
					{
						return false;
					}
					return base.player.GetButtonUp(base.actionId);
				}
			}

			internal Button(PlayerController parent, Definition definition)
				: base(parent, definition)
			{
			}
		}

		public sealed class MouseWheel : Axis2D
		{
			public new class Definition : Axis2D.Definition
			{
				public new MouseWheelAxis.Definition xAxis
				{
					get
					{
						return base.xAxis as MouseWheelAxis.Definition;
					}
					set
					{
						base.xAxis = value;
					}
				}

				public new MouseWheelAxis.Definition yAxis
				{
					get
					{
						return base.yAxis as MouseWheelAxis.Definition;
					}
					set
					{
						base.yAxis = value;
					}
				}

				internal override Element WPECLgBucUixAUfvtkXWqQIjMNXU(PlayerController P_0)
				{
					return new MouseWheel(P_0, this);
				}
			}

			public new MouseWheelAxis xAxis => eCWODyubZajVwOmkGSFXlCGBdhT<MouseWheelAxis>(0);

			public new MouseWheelAxis yAxis => eCWODyubZajVwOmkGSFXlCGBdhT<MouseWheelAxis>(1);

			internal MouseWheel(PlayerController parent, Definition definition)
				: base(parent, definition, (definition != null) ? new Element.Definition[2]
				{
					(definition.xAxis != null) ? definition.xAxis : new MouseWheelAxis.Definition(),
					(definition.yAxis != null) ? definition.yAxis : new MouseWheelAxis.Definition()
				} : null)
			{
			}
		}

		public sealed class MouseWheelAxis : Axis
		{
			public new class Definition : Axis.Definition
			{
				public float repeatRate;

				public Definition()
				{
					coordinateMode = AxisCoordinateMode.Relative;
					repeatRate = 4f;
				}

				internal override Element WPECLgBucUixAUfvtkXWqQIjMNXU(PlayerController P_0)
				{
					return new MouseWheelAxis(P_0, this);
				}
			}

			[CustomObfuscation(rename = false)]
			internal const float defaultRepeatRate = 4f;

			[CustomObfuscation(rename = false)]
			internal new const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Relative;

			private const float tLjycPEuDhlDpdpAiZjnVmpDFJx = 0.01f;

			private float NomRrrPinyFaqfnFysWeLcPVRHFk = 0.25f;

			private double rEFaZygBHWfLaYdHtGNoROADzFIO;

			private float bvCAKWIqWpqXDpHqoSmmOfdNAgMo;

			public float repeatRate
			{
				get
				{
					if (NomRrrPinyFaqfnFysWeLcPVRHFk == 0f)
					{
						return 0f;
					}
					return 1f / NomRrrPinyFaqfnFysWeLcPVRHFk;
				}
				set
				{
					if (value < 0f)
					{
						value = 0f;
					}
					if (value == 0f)
					{
						NomRrrPinyFaqfnFysWeLcPVRHFk = 0f;
					}
					else
					{
						NomRrrPinyFaqfnFysWeLcPVRHFk = 1f / value;
					}
				}
			}

			public override float value
			{
				get
				{
					if (!base.selfAndParentEnabled)
					{
						return 0f;
					}
					return bvCAKWIqWpqXDpHqoSmmOfdNAgMo;
				}
			}

			internal MouseWheelAxis(PlayerController parent, Definition definition)
				: base(parent, definition)
			{
				repeatRate = definition.repeatRate;
			}

			internal override void mtiNfGzpXHszOwiOIAVYQuMZclV()
			{
				base.mtiNfGzpXHszOwiOIAVYQuMZclV();
				if (base.selfAndParentEnabled)
				{
					bvCAKWIqWpqXDpHqoSmmOfdNAgMo = pUPlwqHFfaSMHYJDqEqoDvFxsUZ();
				}
			}

			protected override void EnabledStateChanged(bool state)
			{
				base.EnabledStateChanged(state);
				if (!state)
				{
					LlCkzvOeJVaCziTDPktzBWuYotAZ();
				}
			}

			private float pUPlwqHFfaSMHYJDqEqoDvFxsUZ()
			{
				if (base.player == null)
				{
					return 0f;
				}
				float num = base.player.GetAxis(base.actionId);
				switch (base.player.GetAxisCoordinateMode(base.actionId))
				{
				case AxisCoordinateMode.Absolute:
				{
					bool flag = false;
					if (base.player.GetButtonDown(base.actionId))
					{
						flag = true;
						num = 1f;
					}
					else if (base.player.GetNegativeButtonDown(base.actionId))
					{
						flag = true;
						num = -1f;
					}
					if (!flag && ReInput.unscaledTime < rEFaZygBHWfLaYdHtGNoROADzFIO + (double)NomRrrPinyFaqfnFysWeLcPVRHFk)
					{
						return 0f;
					}
					if (Mathf.Abs(num) <= 0.01f)
					{
						return 0f;
					}
					num = Mathf.Sign(num);
					num *= base.absoluteToRelativeSensitivity;
					rEFaZygBHWfLaYdHtGNoROADzFIO = ReInput.unscaledTime;
					break;
				}
				}
				return num;
			}

			private void LlCkzvOeJVaCziTDPktzBWuYotAZ()
			{
				bvCAKWIqWpqXDpHqoSmmOfdNAgMo = 0f;
				rEFaZygBHWfLaYdHtGNoROADzFIO = 0.0;
			}
		}

		internal readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

		private bool nZTtfeZBpthDaoAvSONdTABGEaM;

		private int IUWpTXMJPIJwDJdybAJNwpRpcYp;

		private readonly AList<Element> uGpQQIwzyDgccAzdMieIrottQjF;

		private readonly AList<Button> XMmeKfLALLiqakhkZdFxAjspFgaC;

		private readonly AList<Axis> nhriWQPeWgGbYcNCMSloCGMDlpbH;

		private readonly ReadOnlyCollection<Element> EZanZBVAuiJIOisjNsKtlblpPjs;

		private readonly ReadOnlyCollection<Button> qcayjwJGLhgSrXkPUjgcWvPSnsA;

		private readonly ReadOnlyCollection<Axis> tdOiKeLHLKVlPthfTFBcPGJSFvqe;

		private readonly List<Element.ovniMRpSrNuJsnrcPCxGGoPpcTv> CLyKrrEyDNLCduYNBkQLObhvqAN;

		private Action<int, bool> cUqUTkzPIQFuEeddbuHCHuBziIm;

		private Action<int, float> VpnAlZEvaIiiDiEKuJtBbTisMqN;

		private Action<bool> hymBvkFHtIvcnukoWkIwFfGCkitK;

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
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					if (nZTtfeZBpthDaoAvSONdTABGEaM == value)
					{
						return;
					}
					if (!value)
					{
						ClearVars();
					}
					nZTtfeZBpthDaoAvSONdTABGEaM = value;
					for (int i = 0; i < uGpQQIwzyDgccAzdMieIrottQjF._count; i++)
					{
						uGpQQIwzyDgccAzdMieIrottQjF[i].enabled = value;
					}
					if (hymBvkFHtIvcnukoWkIwFfGCkitK != null)
					{
						try
						{
							hymBvkFHtIvcnukoWkIwFfGCkitK(value);
						}
						catch (Exception ex)
						{
							Logger.LogError("An exception occurred in a listener of EnabledStateChangedEvent. This means an exception was thrown by your code.\n" + ex);
						}
					}
				}
			}
		}

		public int playerId
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1;
				}
				return IUWpTXMJPIJwDJdybAJNwpRpcYp;
			}
			set
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else if (IUWpTXMJPIJwDJdybAJNwpRpcYp != value)
				{
					IUWpTXMJPIJwDJdybAJNwpRpcYp = value;
					ClearVars();
				}
			}
		}

		public IList<Button> buttons
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return qcayjwJGLhgSrXkPUjgcWvPSnsA;
			}
		}

		public IList<Axis> axes
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return tdOiKeLHLKVlPthfTFBcPGJSFvqe;
			}
		}

		public IList<Element> elements
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

		public int buttonCount
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0;
				}
				if (XMmeKfLALLiqakhkZdFxAjspFgaC == null)
				{
					return 0;
				}
				return XMmeKfLALLiqakhkZdFxAjspFgaC._count;
			}
		}

		public int axisCount
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0;
				}
				if (nhriWQPeWgGbYcNCMSloCGMDlpbH == null)
				{
					return 0;
				}
				return nhriWQPeWgGbYcNCMSloCGMDlpbH._count;
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
				if (uGpQQIwzyDgccAzdMieIrottQjF == null)
				{
					return 0;
				}
				return uGpQQIwzyDgccAzdMieIrottQjF._count;
			}
		}

		internal Player player
		{
			get
			{
				if (!ReInput.isReady)
				{
					return null;
				}
				return ReInput.players.GetPlayer(playerId);
			}
		}

		public event Action<int, bool> ButtonStateChangedEvent
		{
			add
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					cUqUTkzPIQFuEeddbuHCHuBziIm = (Action<int, bool>)Delegate.Combine(cUqUTkzPIQFuEeddbuHCHuBziIm, value);
				}
			}
			remove
			{
				cUqUTkzPIQFuEeddbuHCHuBziIm = (Action<int, bool>)Delegate.Remove(cUqUTkzPIQFuEeddbuHCHuBziIm, value);
			}
		}

		public event Action<int, float> AxisValueChangedEvent
		{
			add
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					VpnAlZEvaIiiDiEKuJtBbTisMqN = (Action<int, float>)Delegate.Combine(VpnAlZEvaIiiDiEKuJtBbTisMqN, value);
				}
			}
			remove
			{
				VpnAlZEvaIiiDiEKuJtBbTisMqN = (Action<int, float>)Delegate.Remove(VpnAlZEvaIiiDiEKuJtBbTisMqN, value);
			}
		}

		public event Action<bool> EnabledStateChangedEvent
		{
			add
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					hymBvkFHtIvcnukoWkIwFfGCkitK = (Action<bool>)Delegate.Combine(hymBvkFHtIvcnukoWkIwFfGCkitK, value);
				}
			}
			remove
			{
				hymBvkFHtIvcnukoWkIwFfGCkitK = (Action<bool>)Delegate.Remove(hymBvkFHtIvcnukoWkIwFfGCkitK, value);
			}
		}

		internal PlayerController(Definition definition)
		{
			if (definition == null)
			{
				throw new ArgumentNullException("definition");
			}
			if (definition.elements == null)
			{
				throw new ArgumentNullException("definition.elements");
			}
			PivQvdYMhUssuLwaglJVqkqXMSH = ReInput._id;
			IUWpTXMJPIJwDJdybAJNwpRpcYp = definition.playerId;
			nZTtfeZBpthDaoAvSONdTABGEaM = definition.enabled;
			List<Element> list = new List<Element>();
			List<Element> list2 = new List<Element>();
			List<Button> list3 = new List<Button>();
			List<Axis> list4 = new List<Axis>();
			foreach (Element.Definition element in definition.elements)
			{
				WqsdoDpSvzDOWFFxuzffBuWiPsvG(element.WPECLgBucUixAUfvtkXWqQIjMNXU(this), list, list2, list3, list4);
			}
			list.AddRange(list2);
			uGpQQIwzyDgccAzdMieIrottQjF = new AList<Element>(list);
			XMmeKfLALLiqakhkZdFxAjspFgaC = new AList<Button>(list3);
			nhriWQPeWgGbYcNCMSloCGMDlpbH = new AList<Axis>(list4);
			EZanZBVAuiJIOisjNsKtlblpPjs = new ReadOnlyCollection<Element>(uGpQQIwzyDgccAzdMieIrottQjF);
			qcayjwJGLhgSrXkPUjgcWvPSnsA = new ReadOnlyCollection<Button>(XMmeKfLALLiqakhkZdFxAjspFgaC);
			tdOiKeLHLKVlPthfTFBcPGJSFvqe = new ReadOnlyCollection<Axis>(nhriWQPeWgGbYcNCMSloCGMDlpbH);
			CLyKrrEyDNLCduYNBkQLObhvqAN = new List<Element.ovniMRpSrNuJsnrcPCxGGoPpcTv>();
			ReInput.UpdateEndedEvent += EsMhoPqAHoBFPBeDrJCrkGzDsbv;
		}

		~PlayerController()
		{
			ReInput.UpdateEndedEvent -= EsMhoPqAHoBFPBeDrJCrkGzDsbv;
		}

		public bool GetButton(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if ((uint)index >= (uint)XMmeKfLALLiqakhkZdFxAjspFgaC._count)
			{
				return false;
			}
			return XMmeKfLALLiqakhkZdFxAjspFgaC[index].value;
		}

		public bool GetButtonDown(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if ((uint)index >= (uint)XMmeKfLALLiqakhkZdFxAjspFgaC._count)
			{
				return false;
			}
			return XMmeKfLALLiqakhkZdFxAjspFgaC[index].justPressed;
		}

		public bool GetButtonUp(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if ((uint)index >= (uint)XMmeKfLALLiqakhkZdFxAjspFgaC._count)
			{
				return false;
			}
			return XMmeKfLALLiqakhkZdFxAjspFgaC[index].justReleased;
		}

		public float GetAxis(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			if ((uint)index >= (uint)nhriWQPeWgGbYcNCMSloCGMDlpbH._count)
			{
				return 0f;
			}
			return nhriWQPeWgGbYcNCMSloCGMDlpbH[index].value;
		}

		public float GetAxisRaw(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			if ((uint)index >= (uint)nhriWQPeWgGbYcNCMSloCGMDlpbH._count)
			{
				return 0f;
			}
			return nhriWQPeWgGbYcNCMSloCGMDlpbH[index].valueRaw;
		}

		public Element GetElement(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			if ((uint)index >= (uint)nhriWQPeWgGbYcNCMSloCGMDlpbH._count)
			{
				return null;
			}
			return uGpQQIwzyDgccAzdMieIrottQjF[index];
		}

		public T GetElement<T>(int index) where T : Element
		{
			return GetElement(index) as T;
		}

		private void EsMhoPqAHoBFPBeDrJCrkGzDsbv(UpdateLoopType P_0)
		{
			Update(P_0);
			UpdateFinished();
		}

		protected virtual bool Update(UpdateLoopType updateLoop)
		{
			if (!nZTtfeZBpthDaoAvSONdTABGEaM)
			{
				return false;
			}
			bool flag = VpnAlZEvaIiiDiEKuJtBbTisMqN != null;
			bool flag2 = cUqUTkzPIQFuEeddbuHCHuBziIm != null;
			for (int i = 0; i < uGpQQIwzyDgccAzdMieIrottQjF._count; i++)
			{
				float num = 0f;
				if (flag && uGpQQIwzyDgccAzdMieIrottQjF[i] is Axis)
				{
					Axis axis = uGpQQIwzyDgccAzdMieIrottQjF[i] as Axis;
					num = ((axis.coordinateMode != 0) ? 0f : axis.value);
				}
				uGpQQIwzyDgccAzdMieIrottQjF[i].mtiNfGzpXHszOwiOIAVYQuMZclV();
				if (flag2 && uGpQQIwzyDgccAzdMieIrottQjF[i] is Button)
				{
					Button button = uGpQQIwzyDgccAzdMieIrottQjF[i] as Button;
					if (button.justPressed && button.value)
					{
						CLyKrrEyDNLCduYNBkQLObhvqAN.Add(new Element.ovniMRpSrNuJsnrcPCxGGoPpcTv(ControllerElementType.Button, i, 1f));
					}
					else if (button.justReleased && !button.value)
					{
						CLyKrrEyDNLCduYNBkQLObhvqAN.Add(new Element.ovniMRpSrNuJsnrcPCxGGoPpcTv(ControllerElementType.Button, i, 0f));
					}
				}
				else if (flag && uGpQQIwzyDgccAzdMieIrottQjF[i] is Axis)
				{
					CLyKrrEyDNLCduYNBkQLObhvqAN.Add(new Element.ovniMRpSrNuJsnrcPCxGGoPpcTv(ControllerElementType.Axis, i, (uGpQQIwzyDgccAzdMieIrottQjF[i] as Axis).value - num));
				}
			}
			return true;
		}

		protected virtual void UpdateFinished()
		{
			int count = CLyKrrEyDNLCduYNBkQLObhvqAN.Count;
			if (count <= 0)
			{
				return;
			}
			for (int i = 0; i < count; i++)
			{
				Element.ovniMRpSrNuJsnrcPCxGGoPpcTv ovniMRpSrNuJsnrcPCxGGoPpcTv = CLyKrrEyDNLCduYNBkQLObhvqAN[i];
				if (ovniMRpSrNuJsnrcPCxGGoPpcTv.DffVgxLTxGtWFSQnSTfYIAPKKDj == ControllerElementType.Button)
				{
					try
					{
						cUqUTkzPIQFuEeddbuHCHuBziIm(ovniMRpSrNuJsnrcPCxGGoPpcTv.MfVGCAceIAkEXxwxwAsLGoqQvdj, ovniMRpSrNuJsnrcPCxGGoPpcTv.foSRcEqSuRsWnadDiKcGnhBewOU > 0f);
					}
					catch (Exception ex)
					{
						Logger.LogError("An exception occurred in a listener of ButtonStateChangedEvent. This means an exception was thrown by your code.\n" + ex);
					}
				}
				else if (ovniMRpSrNuJsnrcPCxGGoPpcTv.DffVgxLTxGtWFSQnSTfYIAPKKDj == ControllerElementType.Axis)
				{
					try
					{
						VpnAlZEvaIiiDiEKuJtBbTisMqN(ovniMRpSrNuJsnrcPCxGGoPpcTv.MfVGCAceIAkEXxwxwAsLGoqQvdj, ovniMRpSrNuJsnrcPCxGGoPpcTv.foSRcEqSuRsWnadDiKcGnhBewOU);
					}
					catch (Exception ex2)
					{
						Logger.LogError("An exception occurred in a listener of AxisValueChangedEvent. This means an exception was thrown by your code.\n" + ex2);
					}
				}
			}
			CLyKrrEyDNLCduYNBkQLObhvqAN.Clear();
		}

		protected virtual void ClearVars()
		{
			CLyKrrEyDNLCduYNBkQLObhvqAN.Clear();
		}

		internal void WqsdoDpSvzDOWFFxuzffBuWiPsvG(Element P_0)
		{
			if (P_0 != null)
			{
				if (P_0 is Axis)
				{
					nhriWQPeWgGbYcNCMSloCGMDlpbH.Add(P_0 as Axis);
				}
				else if (P_0 is Button)
				{
					XMmeKfLALLiqakhkZdFxAjspFgaC.Add(P_0 as Button);
				}
				uGpQQIwzyDgccAzdMieIrottQjF.Add(P_0);
			}
		}

		private void WqsdoDpSvzDOWFFxuzffBuWiPsvG(Element P_0, List<Element> P_1, List<Element> P_2, List<Button> P_3, List<Axis> P_4)
		{
			if (P_0 == null)
			{
				return;
			}
			P_0.GetType();
			if (P_0 is ElementWithSource)
			{
				if (P_0 is Button)
				{
					P_3.Add((Button)P_0);
				}
				else
				{
					if (!(P_0 is Axis))
					{
						Logger.LogWarning("Unknown Element type encountered: " + P_0.GetType());
						return;
					}
					P_4.Add((Axis)P_0);
				}
				P_1.Add(P_0);
			}
			else if (P_0 is CompoundElement)
			{
				using (TempListPool.TList<Element> tList = TempListPool.GetTList<Element>())
				{
					List<Element> list = tList.list;
					(P_0 as CompoundElement).hbJjHqDqEmQCGFttwvYMHMLbhD(list);
					for (int i = 0; i < list.Count; i++)
					{
						WqsdoDpSvzDOWFFxuzffBuWiPsvG(list[i], P_1, P_2, P_3, P_4);
					}
				}
				P_2.Add(P_0);
			}
			else
			{
				Logger.LogWarning("Unknown Element type encountered: " + P_0.GetType());
			}
		}

		internal static int ArAJziBDDqblUPTGKFgxIUeNiqD<T>(IList<T> P_0, Predicate<T> P_1, int P_2) where T : Element
		{
			int num = 0;
			for (int i = 0; i < P_0.Count; i++)
			{
				if (P_1(P_0[i]))
				{
					num++;
				}
				if (num == P_2)
				{
					return i;
				}
			}
			return -1;
		}
	}
}
