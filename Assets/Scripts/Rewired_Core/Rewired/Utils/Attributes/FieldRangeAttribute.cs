using System;
using UnityEngine;

namespace Rewired.Utils.Attributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class FieldRangeAttribute : PropertyAttribute
	{
		private float oTcqurlkUPKeNTKsBrqnGOkbcvJ;

		private float lwPPQnMzpnJaIQcAunKTQCoPbgrj;

		private int bboLWFxOCPzkzLWdZIQCLCFCxQx;

		private int cOgdGoOYjjSsuZQDVbFtSPkkWWu;

		public float minFloat => oTcqurlkUPKeNTKsBrqnGOkbcvJ;

		public float maxFloat => lwPPQnMzpnJaIQcAunKTQCoPbgrj;

		public int minInt => bboLWFxOCPzkzLWdZIQCLCFCxQx;

		public int maxInt => cOgdGoOYjjSsuZQDVbFtSPkkWWu;

		public FieldRangeAttribute(float min, float max)
		{
			oTcqurlkUPKeNTKsBrqnGOkbcvJ = min;
			lwPPQnMzpnJaIQcAunKTQCoPbgrj = max;
			bboLWFxOCPzkzLWdZIQCLCFCxQx = (int)min;
			cOgdGoOYjjSsuZQDVbFtSPkkWWu = (int)max;
		}

		public FieldRangeAttribute(int min, int max)
		{
			bboLWFxOCPzkzLWdZIQCLCFCxQx = min;
			cOgdGoOYjjSsuZQDVbFtSPkkWWu = max;
			oTcqurlkUPKeNTKsBrqnGOkbcvJ = min;
			lwPPQnMzpnJaIQcAunKTQCoPbgrj = max;
		}
	}
}
