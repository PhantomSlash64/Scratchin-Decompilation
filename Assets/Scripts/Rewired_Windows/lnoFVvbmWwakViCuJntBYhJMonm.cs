using System;
using Rewired;
using Rewired.Platforms;
using Rewired.Utils.Classes.Utility;

internal static class lnoFVvbmWwakViCuJntBYhJMonm
{
	private const bool DVDZtTskzzirwEIrMKTUStvZFco = false;

	private static int jDihccWZYPlhFeKgzQvUajroeYT;

	private static ThreadHelper aHBDQAPLbKGkHGuFbbBtCqDMjIf;

	private static ThreadHelper McwAnjwWWlLGwtYpbJEWqDZfTPX;

	public static int bdwnaKkumjoZqcfKWJSyUhZBBWaF => jDihccWZYPlhFeKgzQvUajroeYT;

	public static ThreadHelper lxINYtPAiVLJeseGaYYGgsjTXjR => aHBDQAPLbKGkHGuFbbBtCqDMjIf;

	public static ThreadHelper zBVNEJoBbjelxFZcJghtHWZDbxho => McwAnjwWWlLGwtYpbJEWqDZfTPX;

	public static ThreadHelper vASBewikQenvassTqAnBRckmkUcD => aHBDQAPLbKGkHGuFbbBtCqDMjIf;

	public static ThreadHelper MYNiYSGhJNfIotfVQsakmqkmhLUH => McwAnjwWWlLGwtYpbJEWqDZfTPX;

	public static ThreadHelper edJPsbiBllGabmJkAHzAcLJGoNEj => aHBDQAPLbKGkHGuFbbBtCqDMjIf;

	public static ThreadHelper rtngKQnqgOShcSNkIEIrFnxKKmN => aHBDQAPLbKGkHGuFbbBtCqDMjIf;

	public static bool CnqATsgDGaKLufgGadixpUCORuME
	{
		get
		{
			if (aHBDQAPLbKGkHGuFbbBtCqDMjIf != null)
			{
				return aHBDQAPLbKGkHGuFbbBtCqDMjIf.isRunning;
			}
			return false;
		}
	}

	public static void MGdUCgKavLcKdZVSFfqcdWqSuzTp()
	{
		jDihccWZYPlhFeKgzQvUajroeYT = ReInput.configVars.GetPlatformVar_joystickRefreshRate();
		if (aHBDQAPLbKGkHGuFbbBtCqDMjIf != null)
		{
			throw new Exception("Input Thread Manager is already initialized.");
		}
		aHBDQAPLbKGkHGuFbbBtCqDMjIf = ThreadHelper.CreateFixedTimeStep(jDihccWZYPlhFeKgzQvUajroeYT);
		aHBDQAPLbKGkHGuFbbBtCqDMjIf.Start(wait: true);
		if (ReInput.configVars.useXInput || ReInput.configuration.windowsStandalonePrimaryInputSource == WindowsStandalonePrimaryInputSource.XInput)
		{
			McwAnjwWWlLGwtYpbJEWqDZfTPX = ThreadHelper.CreateFixedTimeStep(100);
			McwAnjwWWlLGwtYpbJEWqDZfTPX.Start(wait: true);
		}
		ReInput.UpdateStartedEvent += eUjowEHGHhBMYhdNZOnGVPwzlWh;
	}

	private static void eUjowEHGHhBMYhdNZOnGVPwzlWh(UpdateLoopType P_0)
	{
		if (P_0 == UpdateLoopType.Update)
		{
			int platformVar_joystickRefreshRate = ReInput.configVars.GetPlatformVar_joystickRefreshRate();
			if (jDihccWZYPlhFeKgzQvUajroeYT != platformVar_joystickRefreshRate)
			{
				jDihccWZYPlhFeKgzQvUajroeYT = platformVar_joystickRefreshRate;
				aHBDQAPLbKGkHGuFbbBtCqDMjIf.fixedTimeStepFPS = platformVar_joystickRefreshRate;
			}
		}
	}

	public static void PMzamCeIIFqnzgwGlxEbIeTHBFUL()
	{
		ReInput.UpdateStartedEvent -= eUjowEHGHhBMYhdNZOnGVPwzlWh;
		if (aHBDQAPLbKGkHGuFbbBtCqDMjIf != null)
		{
			aHBDQAPLbKGkHGuFbbBtCqDMjIf.WaitForActionQueueToFinish();
			aHBDQAPLbKGkHGuFbbBtCqDMjIf.Dispose();
			aHBDQAPLbKGkHGuFbbBtCqDMjIf = null;
		}
		if (McwAnjwWWlLGwtYpbJEWqDZfTPX != null)
		{
			McwAnjwWWlLGwtYpbJEWqDZfTPX.WaitForActionQueueToFinish();
			McwAnjwWWlLGwtYpbJEWqDZfTPX.Dispose();
			McwAnjwWWlLGwtYpbJEWqDZfTPX = null;
		}
	}
}
