using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Serialization;

namespace UnityEngine.U2D.IK
{
	[MovedFrom("UnityEngine.Experimental.U2D.IK")]
	public abstract class Solver2D : MonoBehaviour
	{
		[SerializeField]
		private bool m_ConstrainRotation = true;

		[FormerlySerializedAs("m_RestoreDefaultPose")]
		[SerializeField]
		private bool m_SolveFromDefaultPose = true;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_Weight = 1f;

		private Plane m_Plane;

		private List<Vector3> m_TargetPositions = new List<Vector3>();

		public int chainCount => GetChainCount();

		public bool constrainRotation
		{
			get
			{
				return m_ConstrainRotation;
			}
			set
			{
				m_ConstrainRotation = value;
			}
		}

		public bool solveFromDefaultPose
		{
			get
			{
				return m_SolveFromDefaultPose;
			}
			set
			{
				m_SolveFromDefaultPose = value;
			}
		}

		public bool isValid => Validate();

		public bool allChainsHaveTargets => HasTargets();

		public float weight
		{
			get
			{
				return m_Weight;
			}
			set
			{
				m_Weight = Mathf.Clamp01(value);
			}
		}

		private void OnEnable()
		{
		}

		protected virtual void OnValidate()
		{
			m_Weight = Mathf.Clamp01(m_Weight);
			if (!isValid)
			{
				Initialize();
			}
		}

		private bool Validate()
		{
			for (int i = 0; i < GetChainCount(); i++)
			{
				if (!GetChain(i).isValid)
				{
					return false;
				}
			}
			return DoValidate();
		}

		private bool HasTargets()
		{
			for (int i = 0; i < GetChainCount(); i++)
			{
				if (GetChain(i).target == null)
				{
					return false;
				}
			}
			return true;
		}

		public void Initialize()
		{
			DoInitialize();
			for (int i = 0; i < GetChainCount(); i++)
			{
				GetChain(i).Initialize();
			}
		}

		private void Prepare()
		{
			Transform planeRootTransform = GetPlaneRootTransform();
			if (planeRootTransform != null)
			{
				m_Plane.normal = planeRootTransform.forward;
				m_Plane.distance = 0f - Vector3.Dot(m_Plane.normal, planeRootTransform.position);
			}
			for (int i = 0; i < GetChainCount(); i++)
			{
				IKChain2D chain = GetChain(i);
				bool targetRotationIsConstrained = constrainRotation && chain.target != null;
				if (m_SolveFromDefaultPose)
				{
					chain.RestoreDefaultPose(targetRotationIsConstrained);
				}
			}
			DoPrepare();
		}

		private void PrepareEffectorPositions()
		{
			m_TargetPositions.Clear();
			for (int i = 0; i < GetChainCount(); i++)
			{
				IKChain2D chain = GetChain(i);
				if ((bool)chain.target)
				{
					m_TargetPositions.Add(chain.target.position);
				}
			}
		}

		public void UpdateIK(float globalWeight)
		{
			if (allChainsHaveTargets)
			{
				PrepareEffectorPositions();
				UpdateIK(m_TargetPositions, globalWeight);
			}
		}

		public void UpdateIK(List<Vector3> positions, float globalWeight)
		{
			if (positions.Count != chainCount)
			{
				return;
			}
			float num = globalWeight * weight;
			if (num == 0f || !isValid)
			{
				return;
			}
			Prepare();
			if (num < 1f)
			{
				StoreLocalRotations();
			}
			DoUpdateIK(positions);
			if (constrainRotation)
			{
				for (int i = 0; i < GetChainCount(); i++)
				{
					IKChain2D chain = GetChain(i);
					if ((bool)chain.target)
					{
						chain.effector.rotation = chain.target.rotation;
					}
				}
			}
			if (num < 1f)
			{
				BlendFkToIk(num);
			}
		}

		private void StoreLocalRotations()
		{
			for (int i = 0; i < GetChainCount(); i++)
			{
				GetChain(i).StoreLocalRotations();
			}
		}

		private void BlendFkToIk(float finalWeight)
		{
			for (int i = 0; i < GetChainCount(); i++)
			{
				IKChain2D chain = GetChain(i);
				bool targetRotationIsConstrained = constrainRotation && chain.target != null;
				chain.BlendFkToIk(finalWeight, targetRotationIsConstrained);
			}
		}

		public abstract IKChain2D GetChain(int index);

		protected abstract int GetChainCount();

		protected abstract void DoUpdateIK(List<Vector3> effectorPositions);

		protected virtual bool DoValidate()
		{
			return true;
		}

		protected virtual void DoInitialize()
		{
		}

		protected virtual void DoPrepare()
		{
		}

		protected virtual Transform GetPlaneRootTransform()
		{
			if (chainCount > 0)
			{
				return GetChain(0).rootTransform;
			}
			return null;
		}

		protected Vector3 GetPointOnSolverPlane(Vector3 worldPosition)
		{
			return GetPlaneRootTransform().InverseTransformPoint(m_Plane.ClosestPointOnPlane(worldPosition));
		}

		protected Vector3 GetWorldPositionFromSolverPlanePoint(Vector2 planePoint)
		{
			return GetPlaneRootTransform().TransformPoint(planePoint);
		}
	}
}
