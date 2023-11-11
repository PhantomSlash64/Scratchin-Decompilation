using UnityEngine;

public class ScreenFadeControl : MonoBehaviour
{
	public Material fadeMaterial;

	private Camera Camera;

	private void Awake()
	{
		Camera = GetComponent<Camera>();
	}

	private void OnPostRender()
	{
		if (fadeMaterial != null)
		{
			fadeMaterial.SetPass(0);
			GL.PushMatrix();
			GL.LoadOrtho();
			GL.Color(fadeMaterial.color);
			GL.Begin(7);
			GL.Vertex3(0f, 0f, -12f);
			GL.Vertex3(0f, 1f, -12f);
			GL.Vertex3(1f, 1f, -12f);
			GL.Vertex3(1f, 0f, -12f);
			GL.End();
			GL.PopMatrix();
		}
	}
}
