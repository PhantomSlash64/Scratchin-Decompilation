namespace UnityEngine.U2D.IK
{
	public static class FABRIK2D
	{
		public static bool Solve(Vector2 targetPosition, int solverLimit, float tolerance, float[] lengths, ref Vector2[] positions)
		{
			int num = positions.Length - 1;
			int num2 = 0;
			float num3 = tolerance * tolerance;
			float sqrMagnitude = (targetPosition - positions[num]).sqrMagnitude;
			Vector2 originPosition = positions[0];
			while (sqrMagnitude > num3)
			{
				Forward(targetPosition, lengths, ref positions);
				Backward(originPosition, lengths, ref positions);
				sqrMagnitude = (targetPosition - positions[num]).sqrMagnitude;
				if (++num2 >= solverLimit)
				{
					break;
				}
			}
			return num2 != 0;
		}

		public static bool SolveChain(int solverLimit, ref FABRIKChain2D[] chains)
		{
			if (ValidateChain(chains))
			{
				return false;
			}
			for (int i = 0; i < solverLimit; i++)
			{
				SolveForwardsChain(0, ref chains);
				if (!SolveBackwardsChain(0, ref chains))
				{
					break;
				}
			}
			return true;
		}

		private static bool ValidateChain(FABRIKChain2D[] chains)
		{
			for (int i = 0; i < chains.Length; i++)
			{
				FABRIKChain2D fABRIKChain2D = chains[i];
				if (fABRIKChain2D.subChainIndices.Length == 0 && (fABRIKChain2D.target - fABRIKChain2D.last).sqrMagnitude > fABRIKChain2D.sqrTolerance)
				{
					return false;
				}
			}
			return true;
		}

		private static void SolveForwardsChain(int idx, ref FABRIKChain2D[] chains)
		{
			Vector2 targetPosition = chains[idx].target;
			if (chains[idx].subChainIndices.Length != 0)
			{
				targetPosition = Vector2.zero;
				for (int i = 0; i < chains[idx].subChainIndices.Length; i++)
				{
					int num = chains[idx].subChainIndices[i];
					SolveForwardsChain(num, ref chains);
					targetPosition += chains[num].first;
				}
				targetPosition /= (float)chains[idx].subChainIndices.Length;
			}
			Forward(targetPosition, chains[idx].lengths, ref chains[idx].positions);
		}

		private static bool SolveBackwardsChain(int idx, ref FABRIKChain2D[] chains)
		{
			bool flag = false;
			Backward(chains[idx].origin, chains[idx].lengths, ref chains[idx].positions);
			for (int i = 0; i < chains[idx].subChainIndices.Length; i++)
			{
				int num = chains[idx].subChainIndices[i];
				chains[num].origin = chains[idx].last;
				flag |= SolveBackwardsChain(num, ref chains);
			}
			if (chains[idx].subChainIndices.Length == 0)
			{
				flag |= (chains[idx].target - chains[idx].last).sqrMagnitude > chains[idx].sqrTolerance;
			}
			return flag;
		}

		private static void Forward(Vector2 targetPosition, float[] lengths, ref Vector2[] positions)
		{
			int num = positions.Length - 1;
			positions[num] = targetPosition;
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				Vector2 vector = positions[num2 + 1] - positions[num2];
				float num3 = lengths[num2] / vector.magnitude;
				Vector2 vector2 = (1f - num3) * positions[num2 + 1] + num3 * positions[num2];
				positions[num2] = vector2;
			}
		}

		private static void Backward(Vector2 originPosition, float[] lengths, ref Vector2[] positions)
		{
			positions[0] = originPosition;
			int num = positions.Length - 1;
			for (int i = 0; i < num; i++)
			{
				Vector2 vector = positions[i + 1] - positions[i];
				float num2 = lengths[i] / vector.magnitude;
				Vector2 vector2 = (1f - num2) * positions[i] + num2 * positions[i + 1];
				positions[i + 1] = vector2;
			}
		}

		private static Vector2 ValidateJoint(Vector2 endPosition, Vector2 startPosition, Vector2 right, float min, float max)
		{
			Vector2 to = endPosition - startPosition;
			float num = Vector2.SignedAngle(right, to);
			Vector2 result = endPosition;
			if (num < min)
			{
				Quaternion quaternion = Quaternion.Euler(0f, 0f, min);
				result = startPosition + (Vector2)(quaternion * right * to.magnitude);
			}
			else if (num > max)
			{
				Quaternion quaternion2 = Quaternion.Euler(0f, 0f, max);
				result = startPosition + (Vector2)(quaternion2 * right * to.magnitude);
			}
			return result;
		}
	}
}
