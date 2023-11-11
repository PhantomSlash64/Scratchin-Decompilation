using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.IK
{
	[MovedFrom("UnityEngine.Experimental.U2D.IK")]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class Solver2DMenuAttribute : Attribute
	{
		private string m_MenuPath;

		public string menuPath => m_MenuPath;

		public Solver2DMenuAttribute(string _menuPath)
		{
			m_MenuPath = _menuPath;
		}
	}
}
