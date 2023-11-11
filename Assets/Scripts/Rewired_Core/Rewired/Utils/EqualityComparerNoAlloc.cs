using System;
using System.Collections;
using System.Collections.Generic;

namespace Rewired.Utils
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal static class EqualityComparerNoAlloc<T>
	{
		private class bzfpIAidbvcSViCIviGfCLSdlyVb : IEqualityComparer, IEqualityComparer<int>
		{
			private static bzfpIAidbvcSViCIviGfCLSdlyVb dOauCPdrYoBACsQaqLqkfDDqkgW;

			public static bzfpIAidbvcSViCIviGfCLSdlyVb iZRfKKTEZrbyLvwfdbhJgLEHTxh => dOauCPdrYoBACsQaqLqkfDDqkgW ?? (dOauCPdrYoBACsQaqLqkfDDqkgW = new bzfpIAidbvcSViCIviGfCLSdlyVb());

			public bool Equals(int x, int y)
			{
				return x == y;
			}

			public int GetHashCode(int obj)
			{
				return obj.GetHashCode();
			}

			bool IEqualityComparer.Equals(object x, object y)
			{
				if (object.ReferenceEquals(x, null))
				{
					if (object.ReferenceEquals(y, null))
					{
						return true;
					}
					return false;
				}
				if (!(x is int) || !(y is int))
				{
					return false;
				}
				return Equals((int)x, (int)y);
			}

			int IEqualityComparer.GetHashCode(object obj)
			{
				if (object.ReferenceEquals(obj, null) || !(obj is int))
				{
					return 0;
				}
				return GetHashCode((int)obj);
			}
		}

		private class SsNSaKXbFhwRYsBMFmKdIojVKbj : IEqualityComparer, IEqualityComparer<ulong>
		{
			private static SsNSaKXbFhwRYsBMFmKdIojVKbj dOauCPdrYoBACsQaqLqkfDDqkgW;

			public static SsNSaKXbFhwRYsBMFmKdIojVKbj iZRfKKTEZrbyLvwfdbhJgLEHTxh => dOauCPdrYoBACsQaqLqkfDDqkgW ?? (dOauCPdrYoBACsQaqLqkfDDqkgW = new SsNSaKXbFhwRYsBMFmKdIojVKbj());

			public bool Equals(ulong x, ulong y)
			{
				return x == y;
			}

			public int GetHashCode(ulong obj)
			{
				return obj.GetHashCode();
			}

			bool IEqualityComparer.Equals(object x, object y)
			{
				if (object.ReferenceEquals(x, null))
				{
					if (object.ReferenceEquals(y, null))
					{
						return true;
					}
					return false;
				}
				if (!(x is ulong) || !(y is ulong))
				{
					return false;
				}
				return Equals((ulong)x, (ulong)y);
			}

			int IEqualityComparer.GetHashCode(object obj)
			{
				if (object.ReferenceEquals(obj, null) || !(obj is ulong))
				{
					return 0;
				}
				return GetHashCode((ulong)obj);
			}
		}

		private class WnBVqLNZnGmwMOrRQqNUvktjbeP : IEqualityComparer, IEqualityComparer<uint>
		{
			private static WnBVqLNZnGmwMOrRQqNUvktjbeP dOauCPdrYoBACsQaqLqkfDDqkgW;

			public static WnBVqLNZnGmwMOrRQqNUvktjbeP iZRfKKTEZrbyLvwfdbhJgLEHTxh => dOauCPdrYoBACsQaqLqkfDDqkgW ?? (dOauCPdrYoBACsQaqLqkfDDqkgW = new WnBVqLNZnGmwMOrRQqNUvktjbeP());

			public bool Equals(uint x, uint y)
			{
				return x == y;
			}

			public int GetHashCode(uint obj)
			{
				return obj.GetHashCode();
			}

			bool IEqualityComparer.Equals(object x, object y)
			{
				if (object.ReferenceEquals(x, null))
				{
					if (object.ReferenceEquals(y, null))
					{
						return true;
					}
					return false;
				}
				if (!(x is uint) || !(y is uint))
				{
					return false;
				}
				return Equals((uint)x, (uint)y);
			}

			int IEqualityComparer.GetHashCode(object obj)
			{
				if (object.ReferenceEquals(obj, null) || !(obj is uint))
				{
					return 0;
				}
				return GetHashCode((uint)obj);
			}
		}

		private class nMFNZBpBMTeIoIAkPNVFZVxdFGFg : IEqualityComparer, IEqualityComparer<ulong>
		{
			private static nMFNZBpBMTeIoIAkPNVFZVxdFGFg dOauCPdrYoBACsQaqLqkfDDqkgW;

			public static nMFNZBpBMTeIoIAkPNVFZVxdFGFg iZRfKKTEZrbyLvwfdbhJgLEHTxh => dOauCPdrYoBACsQaqLqkfDDqkgW ?? (dOauCPdrYoBACsQaqLqkfDDqkgW = new nMFNZBpBMTeIoIAkPNVFZVxdFGFg());

			public bool Equals(ulong x, ulong y)
			{
				return x == y;
			}

			public int GetHashCode(ulong obj)
			{
				return obj.GetHashCode();
			}

			bool IEqualityComparer.Equals(object x, object y)
			{
				if (object.ReferenceEquals(x, null))
				{
					if (object.ReferenceEquals(y, null))
					{
						return true;
					}
					return false;
				}
				if (!(x is ulong) || !(y is ulong))
				{
					return false;
				}
				return Equals((ulong)x, (ulong)y);
			}

			int IEqualityComparer.GetHashCode(object obj)
			{
				if (object.ReferenceEquals(obj, null) || !(obj is ulong))
				{
					return 0;
				}
				return GetHashCode((ulong)obj);
			}
		}

		private class cKvbkvFFMRsDwDiIBwfIlkRxPJB : IEqualityComparer, IEqualityComparer<float>
		{
			private static cKvbkvFFMRsDwDiIBwfIlkRxPJB dOauCPdrYoBACsQaqLqkfDDqkgW;

			public static cKvbkvFFMRsDwDiIBwfIlkRxPJB iZRfKKTEZrbyLvwfdbhJgLEHTxh => dOauCPdrYoBACsQaqLqkfDDqkgW ?? (dOauCPdrYoBACsQaqLqkfDDqkgW = new cKvbkvFFMRsDwDiIBwfIlkRxPJB());

			public bool Equals(float x, float y)
			{
				return x == y;
			}

			public int GetHashCode(float obj)
			{
				return obj.GetHashCode();
			}

			bool IEqualityComparer.Equals(object x, object y)
			{
				if (object.ReferenceEquals(x, null))
				{
					if (object.ReferenceEquals(y, null))
					{
						return true;
					}
					return false;
				}
				if (!(x is float) || !(y is float))
				{
					return false;
				}
				return Equals((float)x, (float)y);
			}

			int IEqualityComparer.GetHashCode(object obj)
			{
				if (object.ReferenceEquals(obj, null) || !(obj is float))
				{
					return 0;
				}
				return GetHashCode((float)obj);
			}
		}

		private class zbWqapxeATpRSKXAwYcTGsgKhQT : IEqualityComparer, IEqualityComparer<double>
		{
			private static zbWqapxeATpRSKXAwYcTGsgKhQT dOauCPdrYoBACsQaqLqkfDDqkgW;

			public static zbWqapxeATpRSKXAwYcTGsgKhQT iZRfKKTEZrbyLvwfdbhJgLEHTxh => dOauCPdrYoBACsQaqLqkfDDqkgW ?? (dOauCPdrYoBACsQaqLqkfDDqkgW = new zbWqapxeATpRSKXAwYcTGsgKhQT());

			public bool Equals(double x, double y)
			{
				return x == y;
			}

			public int GetHashCode(double obj)
			{
				return obj.GetHashCode();
			}

			bool IEqualityComparer.Equals(object x, object y)
			{
				if (object.ReferenceEquals(x, null))
				{
					if (object.ReferenceEquals(y, null))
					{
						return true;
					}
					return false;
				}
				if (!(x is double) || !(y is double))
				{
					return false;
				}
				return Equals((double)x, (double)y);
			}

			int IEqualityComparer.GetHashCode(object obj)
			{
				if (object.ReferenceEquals(obj, null) || !(obj is double))
				{
					return 0;
				}
				return GetHashCode((double)obj);
			}
		}

		private class nCtMHQhZnffRKnANYgpLqVspTtO : IEqualityComparer, IEqualityComparer<byte>
		{
			private static nCtMHQhZnffRKnANYgpLqVspTtO dOauCPdrYoBACsQaqLqkfDDqkgW;

			public static nCtMHQhZnffRKnANYgpLqVspTtO iZRfKKTEZrbyLvwfdbhJgLEHTxh => dOauCPdrYoBACsQaqLqkfDDqkgW ?? (dOauCPdrYoBACsQaqLqkfDDqkgW = new nCtMHQhZnffRKnANYgpLqVspTtO());

			public bool Equals(byte x, byte y)
			{
				return x == y;
			}

			public int GetHashCode(byte obj)
			{
				return obj.GetHashCode();
			}

			bool IEqualityComparer.Equals(object x, object y)
			{
				if (object.ReferenceEquals(x, null))
				{
					if (object.ReferenceEquals(y, null))
					{
						return true;
					}
					return false;
				}
				if (!(x is byte) || !(y is byte))
				{
					return false;
				}
				return Equals((byte)x, (byte)y);
			}

			int IEqualityComparer.GetHashCode(object obj)
			{
				if (object.ReferenceEquals(obj, null) || !(obj is byte))
				{
					return 0;
				}
				return GetHashCode((byte)obj);
			}
		}

		private class sBlnRvPMpVCYSLdJusBomVNIDY : IEqualityComparer, IEqualityComparer<sbyte>
		{
			private static sBlnRvPMpVCYSLdJusBomVNIDY dOauCPdrYoBACsQaqLqkfDDqkgW;

			public static sBlnRvPMpVCYSLdJusBomVNIDY iZRfKKTEZrbyLvwfdbhJgLEHTxh => dOauCPdrYoBACsQaqLqkfDDqkgW ?? (dOauCPdrYoBACsQaqLqkfDDqkgW = new sBlnRvPMpVCYSLdJusBomVNIDY());

			public bool Equals(sbyte x, sbyte y)
			{
				return x == y;
			}

			public int GetHashCode(sbyte obj)
			{
				return obj.GetHashCode();
			}

			bool IEqualityComparer.Equals(object x, object y)
			{
				if (object.ReferenceEquals(x, null))
				{
					if (object.ReferenceEquals(y, null))
					{
						return true;
					}
					return false;
				}
				if (!(x is sbyte) || !(y is sbyte))
				{
					return false;
				}
				return Equals((sbyte)x, (sbyte)y);
			}

			int IEqualityComparer.GetHashCode(object obj)
			{
				if (object.ReferenceEquals(obj, null) || !(obj is sbyte))
				{
					return 0;
				}
				return GetHashCode((sbyte)obj);
			}
		}

		private class HkCFViIiYylWCQOmVOSTyfjAaYt : IEqualityComparer, IEqualityComparer<bool>
		{
			private static HkCFViIiYylWCQOmVOSTyfjAaYt dOauCPdrYoBACsQaqLqkfDDqkgW;

			public static HkCFViIiYylWCQOmVOSTyfjAaYt iZRfKKTEZrbyLvwfdbhJgLEHTxh => dOauCPdrYoBACsQaqLqkfDDqkgW ?? (dOauCPdrYoBACsQaqLqkfDDqkgW = new HkCFViIiYylWCQOmVOSTyfjAaYt());

			public bool Equals(bool x, bool y)
			{
				return x == y;
			}

			public int GetHashCode(bool obj)
			{
				return obj.GetHashCode();
			}

			bool IEqualityComparer.Equals(object x, object y)
			{
				if (object.ReferenceEquals(x, null))
				{
					if (object.ReferenceEquals(y, null))
					{
						return true;
					}
					return false;
				}
				if (!(x is bool) || !(y is bool))
				{
					return false;
				}
				return Equals((bool)x, (bool)y);
			}

			int IEqualityComparer.GetHashCode(object obj)
			{
				if (object.ReferenceEquals(obj, null) || !(obj is bool))
				{
					return 0;
				}
				return GetHashCode((bool)obj);
			}
		}

		private class RBJbcXoxcmvpGcwPDxOLWdOpHrI : IEqualityComparer, IEqualityComparer<IntPtr>
		{
			private static RBJbcXoxcmvpGcwPDxOLWdOpHrI dOauCPdrYoBACsQaqLqkfDDqkgW;

			public static RBJbcXoxcmvpGcwPDxOLWdOpHrI iZRfKKTEZrbyLvwfdbhJgLEHTxh => dOauCPdrYoBACsQaqLqkfDDqkgW ?? (dOauCPdrYoBACsQaqLqkfDDqkgW = new RBJbcXoxcmvpGcwPDxOLWdOpHrI());

			public bool Equals(IntPtr x, IntPtr y)
			{
				return x == y;
			}

			public int GetHashCode(IntPtr obj)
			{
				return obj.GetHashCode();
			}

			bool IEqualityComparer.Equals(object x, object y)
			{
				if (object.ReferenceEquals(x, null))
				{
					if (object.ReferenceEquals(y, null))
					{
						return true;
					}
					return false;
				}
				if (!(x is IntPtr) || !(y is IntPtr))
				{
					return false;
				}
				return Equals((IntPtr)x, (IntPtr)y);
			}

			int IEqualityComparer.GetHashCode(object obj)
			{
				if (object.ReferenceEquals(obj, null) || !(obj is IntPtr))
				{
					return 0;
				}
				return GetHashCode((IntPtr)obj);
			}
		}

		public static IEqualityComparer<T> Default
		{
			get
			{
				Type typeFromHandle = typeof(T);
				if (object.ReferenceEquals(typeFromHandle, typeof(int)))
				{
					return (IEqualityComparer<T>)bzfpIAidbvcSViCIviGfCLSdlyVb.iZRfKKTEZrbyLvwfdbhJgLEHTxh;
				}
				if (object.ReferenceEquals(typeFromHandle, typeof(long)))
				{
					return (IEqualityComparer<T>)SsNSaKXbFhwRYsBMFmKdIojVKbj.iZRfKKTEZrbyLvwfdbhJgLEHTxh;
				}
				if (object.ReferenceEquals(typeFromHandle, typeof(uint)))
				{
					return (IEqualityComparer<T>)WnBVqLNZnGmwMOrRQqNUvktjbeP.iZRfKKTEZrbyLvwfdbhJgLEHTxh;
				}
				if (object.ReferenceEquals(typeFromHandle, typeof(ulong)))
				{
					return (IEqualityComparer<T>)nMFNZBpBMTeIoIAkPNVFZVxdFGFg.iZRfKKTEZrbyLvwfdbhJgLEHTxh;
				}
				if (object.ReferenceEquals(typeFromHandle, typeof(float)))
				{
					return (IEqualityComparer<T>)cKvbkvFFMRsDwDiIBwfIlkRxPJB.iZRfKKTEZrbyLvwfdbhJgLEHTxh;
				}
				if (object.ReferenceEquals(typeFromHandle, typeof(double)))
				{
					return (IEqualityComparer<T>)zbWqapxeATpRSKXAwYcTGsgKhQT.iZRfKKTEZrbyLvwfdbhJgLEHTxh;
				}
				if (object.ReferenceEquals(typeFromHandle, typeof(byte)))
				{
					return (IEqualityComparer<T>)nCtMHQhZnffRKnANYgpLqVspTtO.iZRfKKTEZrbyLvwfdbhJgLEHTxh;
				}
				if (object.ReferenceEquals(typeFromHandle, typeof(sbyte)))
				{
					return (IEqualityComparer<T>)sBlnRvPMpVCYSLdJusBomVNIDY.iZRfKKTEZrbyLvwfdbhJgLEHTxh;
				}
				if (object.ReferenceEquals(typeFromHandle, typeof(bool)))
				{
					return (IEqualityComparer<T>)HkCFViIiYylWCQOmVOSTyfjAaYt.iZRfKKTEZrbyLvwfdbhJgLEHTxh;
				}
				if (object.ReferenceEquals(typeFromHandle, typeof(IntPtr)))
				{
					return (IEqualityComparer<T>)RBJbcXoxcmvpGcwPDxOLWdOpHrI.iZRfKKTEZrbyLvwfdbhJgLEHTxh;
				}
				return EqualityComparer<T>.Default;
			}
		}
	}
}
