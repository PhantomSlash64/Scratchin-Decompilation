using System;
using UnityEngine;

namespace Rewired.ComponentControls.Effects
{
	[AddComponentMenu("Rewired/Rotate Around Axis")]
	public class RotateAroundAxis : MonoBehaviour
	{
		public enum Speed
		{
			Stopped = 0,
			Slow = 1,
			Fast = 2
		}

		public enum RotationAxis
		{
			X = 0,
			Y = 1,
			Z = 2
		}

		[Tooltip("The current speed of rotation.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private Speed _speed;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("The speed of rotation when Speed is set to Slow. This measured in degrees per second.")]
		private float _slowRotationSpeed = 5f;

		[Tooltip("The speed of rotation when Speed is set to Fast. This measured in degrees per second.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private float _fastRotationSpeed = 20f;

		[Tooltip("The axis around which rotation will occur.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private RotationAxis _rotateAroundAxis = RotationAxis.Z;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("The space in which rotation will occur.")]
		private Space _relativeTo = Space.Self;

		[Tooltip("Reverses the rotation direction.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _reverse;

		public Speed speed
		{
			get
			{
				return _speed;
			}
			set
			{
				_speed = value;
			}
		}

		public float slowRotationSpeed
		{
			get
			{
				return _slowRotationSpeed;
			}
			set
			{
				_slowRotationSpeed = value;
			}
		}

		public float fastRotationSpeed
		{
			get
			{
				return _fastRotationSpeed;
			}
			set
			{
				_fastRotationSpeed = value;
			}
		}

		public RotationAxis rotateAroundAxis
		{
			get
			{
				return _rotateAroundAxis;
			}
			set
			{
				_rotateAroundAxis = value;
			}
		}

		public Space relativeTo
		{
			get
			{
				return _relativeTo;
			}
			set
			{
				_relativeTo = value;
			}
		}

		public bool reverse
		{
			get
			{
				return _reverse;
			}
			set
			{
				_reverse = value;
			}
		}

		[CustomObfuscation(rename = false)]
		private void Update()
		{
			if (_speed != 0)
			{
				float num = ((_speed == Speed.Fast) ? _fastRotationSpeed : _slowRotationSpeed);
				if (_reverse)
				{
					num *= -1f;
				}
				base.transform.Rotate(HDJmmawljyHEGkRlSvHBwfkwrft(_rotateAroundAxis), num * Time.deltaTime, _relativeTo);
			}
		}

		private static Vector3 HDJmmawljyHEGkRlSvHBwfkwrft(RotationAxis P_0)
		{
			return P_0 switch
			{
				RotationAxis.X => new Vector3(1f, 0f, 0f), 
				RotationAxis.Y => new Vector3(0f, 1f, 0f), 
				RotationAxis.Z => new Vector3(0f, 0f, 1f), 
				_ => throw new NotImplementedException(), 
			};
		}

		public void SetSpeed(Speed speed)
		{
			_speed = speed;
		}

		public void SetSpeed(int speed)
		{
			if (Enum.IsDefined(typeof(Speed), speed))
			{
				_speed = (Speed)speed;
			}
		}
	}
}
