namespace UnityEngine.Rendering
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.core@11.0/manual/Free-Camera.html")]
	public class FreeCamera : MonoBehaviour
	{
		public float m_LookSpeedController = 120f;

		public float m_LookSpeedMouse = 10f;

		public float m_MoveSpeed = 10f;

		public float m_MoveSpeedIncrement = 2.5f;

		public float m_Turbo = 10f;

		private static string kMouseX = "Mouse X";

		private static string kMouseY = "Mouse Y";

		private static string kRightStickX = "Controller Right Stick X";

		private static string kRightStickY = "Controller Right Stick Y";

		private static string kVertical = "Vertical";

		private static string kHorizontal = "Horizontal";

		private static string kYAxis = "YAxis";

		private static string kSpeedAxis = "Speed Axis";

		private float inputRotateAxisX;

		private float inputRotateAxisY;

		private float inputChangeSpeed;

		private float inputVertical;

		private float inputHorizontal;

		private float inputYAxis;

		private bool leftShiftBoost;

		private bool leftShift;

		private bool fire1;

		private void OnEnable()
		{
			RegisterInputs();
		}

		private void RegisterInputs()
		{
		}

		private void UpdateInputs()
		{
			inputRotateAxisX = 0f;
			inputRotateAxisY = 0f;
			leftShiftBoost = false;
			fire1 = false;
			if (Input.GetMouseButton(1))
			{
				leftShiftBoost = true;
				inputRotateAxisX = Input.GetAxis(kMouseX) * m_LookSpeedMouse;
				inputRotateAxisY = Input.GetAxis(kMouseY) * m_LookSpeedMouse;
			}
			inputRotateAxisX += Input.GetAxis(kRightStickX) * m_LookSpeedController * Time.deltaTime;
			inputRotateAxisY += Input.GetAxis(kRightStickY) * m_LookSpeedController * Time.deltaTime;
			leftShift = Input.GetKey(KeyCode.LeftShift);
			fire1 = Input.GetAxis("Fire1") > 0f;
			inputChangeSpeed = Input.GetAxis(kSpeedAxis);
			inputVertical = Input.GetAxis(kVertical);
			inputHorizontal = Input.GetAxis(kHorizontal);
			inputYAxis = Input.GetAxis(kYAxis);
		}

		private void Update()
		{
			if (DebugManager.instance.displayRuntimeUI)
			{
				return;
			}
			UpdateInputs();
			if (inputChangeSpeed != 0f)
			{
				m_MoveSpeed += inputChangeSpeed * m_MoveSpeedIncrement;
				if (m_MoveSpeed < m_MoveSpeedIncrement)
				{
					m_MoveSpeed = m_MoveSpeedIncrement;
				}
			}
			if (inputRotateAxisX != 0f || inputRotateAxisY != 0f || inputVertical != 0f || inputHorizontal != 0f || inputYAxis != 0f)
			{
				float x = base.transform.localEulerAngles.x;
				float y = base.transform.localEulerAngles.y + inputRotateAxisX;
				float num = x - inputRotateAxisY;
				if (x <= 90f && num >= 0f)
				{
					num = Mathf.Clamp(num, 0f, 90f);
				}
				if (x >= 270f)
				{
					num = Mathf.Clamp(num, 270f, 360f);
				}
				base.transform.localRotation = Quaternion.Euler(num, y, base.transform.localEulerAngles.z);
				float num2 = Time.deltaTime * m_MoveSpeed;
				if (fire1 || (leftShiftBoost && leftShift))
				{
					num2 *= m_Turbo;
				}
				base.transform.position += base.transform.forward * num2 * inputVertical;
				base.transform.position += base.transform.right * num2 * inputHorizontal;
				base.transform.position += Vector3.up * num2 * inputYAxis;
			}
		}
	}
}
