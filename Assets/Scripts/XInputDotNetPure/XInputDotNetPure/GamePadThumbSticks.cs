namespace XInputDotNetPure
{
	public struct GamePadThumbSticks
	{
		public struct StickValue
		{
			private float x;

			private float y;

			public float X => x;

			public float Y => y;

			internal StickValue(float x, float y)
			{
				this.x = x;
				this.y = y;
			}
		}

		private StickValue left;

		private StickValue right;

		public StickValue Left => left;

		public StickValue Right => right;

		internal GamePadThumbSticks(StickValue left, StickValue right)
		{
			this.left = left;
			this.right = right;
		}
	}
}
