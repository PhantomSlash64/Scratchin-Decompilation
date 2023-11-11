using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.U2D.Animation
{
	internal class BufferManager : ScriptableObject
	{
		private static BufferManager s_Instance;

		private Dictionary<int, VertexBuffer> m_Buffers = new Dictionary<int, VertexBuffer>();

		private Queue<VertexBuffer> m_BuffersToDispose = new Queue<VertexBuffer>();

		public int bufferCount
		{
			get
			{
				int num = 0;
				foreach (VertexBuffer value in m_Buffers.Values)
				{
					num += value.bufferCount;
				}
				return num;
			}
		}

		public bool needDoubleBuffering { get; set; }

		public static BufferManager instance
		{
			get
			{
				if (s_Instance == null)
				{
					BufferManager[] array = Resources.FindObjectsOfTypeAll<BufferManager>();
					if (array.Length != 0)
					{
						s_Instance = array[0];
					}
					else
					{
						s_Instance = ScriptableObject.CreateInstance<BufferManager>();
					}
					s_Instance.hideFlags = HideFlags.HideAndDontSave;
				}
				return s_Instance;
			}
		}

		private void OnEnable()
		{
			if (s_Instance == null)
			{
				s_Instance = this;
			}
			needDoubleBuffering = SystemInfo.renderingThreadingMode != RenderingThreadingMode.Direct;
			Application.onBeforeRender += Update;
		}

		private void OnDisable()
		{
			if (s_Instance == this)
			{
				s_Instance = null;
			}
			ForceClearBuffers();
			Application.onBeforeRender -= Update;
		}

		private void ForceClearBuffers()
		{
			foreach (VertexBuffer value in m_Buffers.Values)
			{
				value.Dispose();
			}
			foreach (VertexBuffer item in m_BuffersToDispose)
			{
				item.Dispose();
			}
			m_Buffers.Clear();
			m_BuffersToDispose.Clear();
		}

		public NativeByteArray GetBuffer(int id, int bufferSize)
		{
			if (!m_Buffers.TryGetValue(id, out var value))
			{
				value = CreateBuffer(id, bufferSize);
			}
			return value?.GetBuffer(bufferSize);
		}

		private VertexBuffer CreateBuffer(int id, int bufferSize)
		{
			if (bufferSize < 1)
			{
				Debug.LogError("Cannot create a buffer smaller than 1 byte.");
				return null;
			}
			VertexBuffer vertexBuffer = new VertexBuffer(id, bufferSize, needDoubleBuffering);
			m_Buffers.Add(id, vertexBuffer);
			return vertexBuffer;
		}

		public void ReturnBuffer(int id)
		{
			if (m_Buffers.TryGetValue(id, out var value))
			{
				value.Deactivate();
				m_BuffersToDispose.Enqueue(value);
				m_Buffers.Remove(id);
			}
		}

		private void Update()
		{
			while (m_BuffersToDispose.Count > 0 && m_BuffersToDispose.Peek().IsSafeToDispose())
			{
				m_BuffersToDispose.Dequeue().Dispose();
			}
		}
	}
}
