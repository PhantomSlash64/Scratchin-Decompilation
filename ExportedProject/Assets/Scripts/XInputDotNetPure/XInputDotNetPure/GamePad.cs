namespace XInputDotNetPure
{
	public class GamePad
	{
		public static GamePadState GetState(PlayerIndex playerIndex)
		{
			return GetState(playerIndex, GamePadDeadZone.IndependentAxes);
		}

		public static GamePadState GetState(PlayerIndex playerIndex, GamePadDeadZone deadZone)
		{
			GamePadState.RawState state;
			return new GamePadState(Imports.XInputGamePadGetState((uint)playerIndex, out state) == 0, state, deadZone);
		}

		public static void SetVibration(PlayerIndex playerIndex, float leftMotor, float rightMotor)
		{
			Imports.XInputGamePadSetState((uint)playerIndex, leftMotor, rightMotor);
		}
	}
}
