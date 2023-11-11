using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.IK
{
	[MovedFrom("UnityEngine.Experimental.U2D.IK")]
	public static class CCD2D
	{
		public static bool Solve(Vector3 targetPosition, Vector3 forward, int solverLimit, float tolerance, float velocity, ref Vector3[] positions)
		{
			int num = positions.Length - 1;
			int num2 = 0;
			float num3 = tolerance * tolerance;
			float sqrMagnitude = (targetPosition - positions[num]).sqrMagnitude;
			while (sqrMagnitude > num3)
			{
				DoIteration(targetPosition, forward, num, velocity, ref positions);
				sqrMagnitude = (targetPosition - positions[num]).sqrMagnitude;
				if (++num2 >= solverLimit)
				{
					break;
				}
			}
			return num2 != 0;
		}

		private static void DoIteration(Vector3 targetPosition, Vector3 forward, int last, float velocity, ref Vector3[] positions)
		{
			for (int num = last - 1; num >= 0; num--)
			{
				Vector3 to = targetPosition - positions[num];
				float b = Vector3.SignedAngle(positions[last] - positions[num], to, forward);
				b = Mathf.Lerp(0f, b, velocity);
				Quaternion rotation = Quaternion.AngleAxis(b, forward);
				for (int num2 = last; num2 > num; num2--)
				{
					positions[num2] = RotatePositionFrom(positions[num2], positions[num], rotation);
				}
			}
		}

		private static Vector3 RotatePositionFrom(Vector3 position, Vector3 pivot, Quaternion rotation)
		{
			Vector3 vector = position - pivot;
			vector = rotation * vector;
			return pivot + vector;
		}
	}
}
