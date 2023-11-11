using Unity.Collections;

namespace UnityEngine.U2D.Animation
{
	internal class VertexBuffer
	{
		private readonly int m_Id;

		private bool m_IsActive = true;

		private int m_DeactivateFrame = -1;

		private NativeByteArray[] m_Buffers;

		private int m_ActiveIndex;

		public int bufferCount => m_Buffers.Length;

		public VertexBuffer(int id, int size, bool needDoubleBuffering)
		{
			m_Id = id;
			int num = ((!needDoubleBuffering) ? 1 : 2);
			m_Buffers = new NativeByteArray[num];
			for (int i = 0; i < num; i++)
			{
				m_Buffers[i] = new NativeByteArray(new NativeArray<byte>(size, Allocator.Persistent, NativeArrayOptions.UninitializedMemory));
			}
		}

		public override int GetHashCode()
		{
			return m_Id;
		}

		private static int GetCurrentFrame()
		{
			return Time.frameCount;
		}

		public NativeByteArray GetBuffer(int size)
		{
			if (!m_IsActive)
			{
				Debug.LogError($"Cannot request deactivated buffer. ID: {m_Id}");
				return null;
			}
			m_ActiveIndex = (m_ActiveIndex + 1) % m_Buffers.Length;
			if (m_Buffers[m_ActiveIndex].Length != size)
			{
				ResizeBuffer(m_ActiveIndex, size);
			}
			return m_Buffers[m_ActiveIndex];
		}

		private void ResizeBuffer(int bufferId, int newSize)
		{
			m_Buffers[bufferId].Dispose();
			m_Buffers[bufferId] = new NativeByteArray(new NativeArray<byte>(newSize, Allocator.Persistent, NativeArrayOptions.UninitializedMemory));
		}

		public void Deactivate()
		{
			if (m_IsActive)
			{
				m_IsActive = false;
				m_DeactivateFrame = GetCurrentFrame();
			}
		}

		public void Dispose()
		{
			for (int i = 0; i < m_Buffers.Length; i++)
			{
				if (m_Buffers[i].IsCreated)
				{
					m_Buffers[i].Dispose();
				}
			}
		}

		public bool IsSafeToDispose()
		{
			if (!m_IsActive)
			{
				return GetCurrentFrame() > m_DeactivateFrame;
			}
			return false;
		}
	}
}
