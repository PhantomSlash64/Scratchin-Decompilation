using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.IK
{
	[MovedFrom("UnityEngine.Experimental.U2D.IK")]
	[Solver2DMenu("Limb")]
	public class LimbSolver2D : Solver2D
	{
		[SerializeField]
		private IKChain2D m_Chain = new IKChain2D();

		[SerializeField]
		private bool m_Flip;

		private Vector3[] m_Positions = new Vector3[3];

		private float[] m_Lengths = new float[2];

		private float[] m_Angles = new float[2];

		public bool flip
		{
			get
			{
				return m_Flip;
			}
			set
			{
				m_Flip = value;
			}
		}

		protected override void DoInitialize()
		{
			m_Chain.transformCount = ((!(m_Chain.effector == null) && IKUtility.GetAncestorCount(m_Chain.effector) >= 2) ? 3 : 0);
			base.DoInitialize();
		}

		protected override int GetChainCount()
		{
			return 1;
		}

		public override IKChain2D GetChain(int index)
		{
			return m_Chain;
		}

		protected override void DoPrepare()
		{
			float[] lengths = m_Chain.lengths;
			m_Positions[0] = m_Chain.transforms[0].position;
			m_Positions[1] = m_Chain.transforms[1].position;
			m_Positions[2] = m_Chain.transforms[2].position;
			m_Lengths[0] = lengths[0];
			m_Lengths[1] = lengths[1];
		}

		protected override void DoUpdateIK(List<Vector3> effectorPositions)
		{
			Vector3 position = effectorPositions[0];
			Vector2 vector = m_Chain.transforms[0].InverseTransformPoint(position);
			position = m_Chain.transforms[0].TransformPoint(vector);
			if (vector.sqrMagnitude > 0f && Limb.Solve(position, m_Lengths, m_Positions, ref m_Angles))
			{
				float num = (flip ? (-1f) : 1f);
				m_Chain.transforms[0].localRotation *= Quaternion.FromToRotation(Vector3.right, vector) * Quaternion.FromToRotation(m_Chain.transforms[1].localPosition, Vector3.right);
				m_Chain.transforms[0].localRotation *= Quaternion.AngleAxis(num * m_Angles[0], Vector3.forward);
				m_Chain.transforms[1].localRotation *= Quaternion.FromToRotation(Vector3.right, m_Chain.transforms[1].InverseTransformPoint(position)) * Quaternion.FromToRotation(m_Chain.transforms[2].localPosition, Vector3.right);
			}
		}
	}
}
