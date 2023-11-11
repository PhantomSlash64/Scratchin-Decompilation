using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.Undoc)]
	public static class RuntimeUtility
	{
		private static RaycastHit[] s_HitBuffer = new RaycastHit[16];

		private static int[] s_PenetrationIndexBuffer = new int[16];

		private static SphereCollider s_ScratchCollider;

		private static GameObject s_ScratchColliderGameObject;

		public static void DestroyObject(Object obj)
		{
			if (obj != null)
			{
				Object.Destroy(obj);
			}
		}

		public static bool IsPrefab(GameObject gameObject)
		{
			return false;
		}

		public static bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength, int layerMask, in string ignoreTag)
		{
			if (ignoreTag.Length == 0)
			{
				if (Physics.Raycast(ray, out hitInfo, rayLength, layerMask, QueryTriggerInteraction.Ignore))
				{
					return true;
				}
			}
			else
			{
				int num = -1;
				int num2 = Physics.RaycastNonAlloc(ray, s_HitBuffer, rayLength, layerMask, QueryTriggerInteraction.Ignore);
				for (int i = 0; i < num2; i++)
				{
					if (!s_HitBuffer[i].collider.CompareTag(ignoreTag) && (num < 0 || s_HitBuffer[i].distance < s_HitBuffer[num].distance))
					{
						num = i;
					}
				}
				if (num >= 0)
				{
					hitInfo = s_HitBuffer[num];
					if (num2 == s_HitBuffer.Length)
					{
						s_HitBuffer = new RaycastHit[s_HitBuffer.Length * 2];
					}
					return true;
				}
			}
			hitInfo = default(RaycastHit);
			return false;
		}

		public static bool SphereCastIgnoreTag(Vector3 rayStart, float radius, Vector3 dir, out RaycastHit hitInfo, float rayLength, int layerMask, in string ignoreTag)
		{
			int num = -1;
			int num2 = 0;
			float num3 = 0f;
			int num4 = Physics.SphereCastNonAlloc(rayStart, radius, dir, s_HitBuffer, rayLength, layerMask, QueryTriggerInteraction.Ignore);
			for (int i = 0; i < num4; i++)
			{
				RaycastHit raycastHit = s_HitBuffer[i];
				if (ignoreTag.Length > 0 && raycastHit.collider.CompareTag(ignoreTag))
				{
					continue;
				}
				if (raycastHit.distance == 0f && raycastHit.normal == -dir)
				{
					if (s_PenetrationIndexBuffer.Length > num2 + 1)
					{
						s_PenetrationIndexBuffer[num2++] = i;
					}
					SphereCollider scratchCollider = GetScratchCollider();
					scratchCollider.radius = radius;
					Collider collider = raycastHit.collider;
					if (!Physics.ComputePenetration(scratchCollider, rayStart, Quaternion.identity, collider, collider.transform.position, collider.transform.rotation, out var direction, out var distance))
					{
						continue;
					}
					raycastHit.point = rayStart + direction * (distance - radius);
					raycastHit.distance = distance - radius;
					raycastHit.normal = direction;
					s_HitBuffer[i] = raycastHit;
					num3 += raycastHit.distance;
				}
				if (num < 0 || raycastHit.distance < s_HitBuffer[num].distance)
				{
					num = i;
				}
			}
			if (num2 > 1)
			{
				hitInfo = default(RaycastHit);
				for (int j = 0; j < num2; j++)
				{
					RaycastHit raycastHit2 = s_HitBuffer[s_PenetrationIndexBuffer[j]];
					float num5 = raycastHit2.distance / num3;
					hitInfo.point += raycastHit2.point * num5;
					hitInfo.distance += raycastHit2.distance * num5;
					hitInfo.normal += raycastHit2.normal * num5;
				}
				hitInfo.normal = hitInfo.normal.normalized;
				return true;
			}
			if (num >= 0)
			{
				hitInfo = s_HitBuffer[num];
				if (num4 == s_HitBuffer.Length)
				{
					s_HitBuffer = new RaycastHit[s_HitBuffer.Length * 2];
				}
				return true;
			}
			hitInfo = default(RaycastHit);
			return false;
		}

		internal static SphereCollider GetScratchCollider()
		{
			if (s_ScratchColliderGameObject == null)
			{
				s_ScratchColliderGameObject = new GameObject("Cinemachine Scratch Collider");
				s_ScratchColliderGameObject.hideFlags = HideFlags.HideAndDontSave;
				s_ScratchColliderGameObject.transform.position = Vector3.zero;
				s_ScratchColliderGameObject.SetActive(value: true);
				s_ScratchCollider = s_ScratchColliderGameObject.AddComponent<SphereCollider>();
				s_ScratchCollider.isTrigger = true;
				Rigidbody rigidbody = s_ScratchColliderGameObject.AddComponent<Rigidbody>();
				rigidbody.detectCollisions = false;
				rigidbody.isKinematic = true;
			}
			return s_ScratchCollider;
		}

		internal static void DestroyScratchCollider()
		{
			if (s_ScratchColliderGameObject != null)
			{
				s_ScratchColliderGameObject.SetActive(value: false);
				DestroyObject(s_ScratchColliderGameObject.GetComponent<Rigidbody>());
			}
			DestroyObject(s_ScratchCollider);
			DestroyObject(s_ScratchColliderGameObject);
			s_ScratchColliderGameObject = null;
			s_ScratchCollider = null;
		}
	}
}
