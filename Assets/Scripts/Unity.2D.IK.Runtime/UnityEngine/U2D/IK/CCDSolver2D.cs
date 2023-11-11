using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.IK
{
	[MovedFrom("UnityEngine.Experimental.U2D.IK")]
	[Solver2DMenu("Chain (CCD)")]
	public class CCDSolver2D : Solver2D
	{
		private const float kMinTolerance = 0.001f;

		private const int kMinIterations = 1;

		private const float kMinVelocity = 0.01f;

		private const float kMaxVelocity = 1f;

		[SerializeField]
		private IKChain2D m_Chain = new IKChain2D();

		[SerializeField]
		[Range(1f, 50f)]
		private int m_Iterations = 10;

		[SerializeField]
		[Range(0.001f, 0.1f)]
		private float m_Tolerance = 0.01f;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_Velocity = 0.5f;

		private Vector3[] m_Positions;

		public int iterations
		{
			get
			{
				return m_Iterations;
			}
			set
			{
				m_Iterations = Mathf.Max(value, 1);
			}
		}

		public float tolerance
		{
			get
			{
				return m_Tolerance;
			}
			set
			{
				m_Tolerance = Mathf.Max(value, 0.001f);
			}
		}

		public float velocity
		{
			get
			{
				return m_Velocity;
			}
			set
			{
				m_Velocity = Mathf.Clamp01(value);
			}
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
			if (m_Positions == null || m_Positions.Length != m_Chain.transformCount)
			{
				m_Positions = new Vector3[m_Chain.transformCount];
			}
			for (int i = 0; i < m_Chain.transformCount; i++)
			{
				m_Positions[i] = m_Chain.transforms[i].position;
			}
		}

		protected override void DoUpdateIK(List<Vector3> effectorPositions)
		{
			Vector3 position = effectorPositions[0];
			Vector2 vector = m_Chain.transforms[0].InverseTransformPoint(position);
			position = m_Chain.transforms[0].TransformPoint(vector);
			if (CCD2D.Solve(position, GetPlaneRootTransform().forward, iterations, tolerance, Mathf.Lerp(0.01f, 1f, m_Velocity), ref m_Positions))
			{
				for (int i = 0; i < m_Chain.transformCount - 1; i++)
				{
					Vector3 localPosition = m_Chain.transforms[i + 1].localPosition;
					Vector3 toDirection = m_Chain.transforms[i].InverseTransformPoint(m_Positions[i + 1]);
					m_Chain.transforms[i].localRotation *= Quaternion.FromToRotation(localPosition, toDirection);
				}
			}
		}
	}
}
