using Rewired;
using Rewired.Interfaces;
using Rewired.Internal;
using Rewired.Platforms;
using Rewired.Utils;
using UnityEngine;

internal sealed class MidhwdEpAgeQchCqDaHVqRFpvaY : IElementIdentifierTool
{
	private Rewired.Internal.GUIText FCpbsiiscczuXEhXobHBWHMgVXt;

	private string bUvaInftmWNiFktHvCsNUXlnmMW;

	private int rwiAEffVMgQrMGlBNSUEmGfxxMjp = 1;

	public void Initialize(Rewired.Internal.GUIText text)
	{
		FCpbsiiscczuXEhXobHBWHMgVXt = text;
	}

	public void Start()
	{
		string[] joystickNames = Input.GetJoystickNames();
		string text = "Detected " + joystickNames.Length + " attached joysticks";
		if (joystickNames.Length > 0)
		{
			text += ":\n";
		}
		string[] array = joystickNames;
		foreach (string text2 in array)
		{
			text = text + "\"" + text2 + "\"\n";
		}
		Rewired.Logger.Log(text);
	}

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Equals) || Input.GetKeyDown(KeyCode.Plus) || Input.GetKeyDown(KeyCode.KeypadPlus))
		{
			rwiAEffVMgQrMGlBNSUEmGfxxMjp++;
		}
		if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
		{
			rwiAEffVMgQrMGlBNSUEmGfxxMjp--;
		}
		if (rwiAEffVMgQrMGlBNSUEmGfxxMjp <= 0)
		{
			rwiAEffVMgQrMGlBNSUEmGfxxMjp = 16;
		}
		else if (rwiAEffVMgQrMGlBNSUEmGfxxMjp > 16)
		{
			rwiAEffVMgQrMGlBNSUEmGfxxMjp = 1;
		}
		bUvaInftmWNiFktHvCsNUXlnmMW = "Unity Joystick Element Identifier:\n\n";
		string[] joystickNames = Input.GetJoystickNames();
		if (joystickNames.Length > 0)
		{
			bUvaInftmWNiFktHvCsNUXlnmMW += "Connected joysticks:\n";
		}
		else
		{
			bUvaInftmWNiFktHvCsNUXlnmMW += "No joysticks detected.\n";
		}
		for (int i = 0; i < joystickNames.Length; i++)
		{
			object obj = bUvaInftmWNiFktHvCsNUXlnmMW;
			bUvaInftmWNiFktHvCsNUXlnmMW = string.Concat(obj, "[", i, "] \"", joystickNames[i], "\"");
			if (UnityTools.platform == Platform.Linux && UnityTools.externalTools.LinuxInput_IsJoystickPreconfigured(joystickNames[i]))
			{
				bUvaInftmWNiFktHvCsNUXlnmMW += " [UNITY PRE-CONFIGURED]";
			}
			bUvaInftmWNiFktHvCsNUXlnmMW += "\n";
		}
		bUvaInftmWNiFktHvCsNUXlnmMW += "\n";
		object obj2 = bUvaInftmWNiFktHvCsNUXlnmMW;
		bUvaInftmWNiFktHvCsNUXlnmMW = string.Concat(obj2, "Current Unity Joystick Id: ", rwiAEffVMgQrMGlBNSUEmGfxxMjp, "\n");
		bUvaInftmWNiFktHvCsNUXlnmMW += "(Press + or - to change monitored joystick id.)\n\n";
		for (int j = 0; j < 29; j++)
		{
			string text = "Axis " + j;
			float joystickAxisValueByJoystickId = UnityInputHelper.GetJoystickAxisValueByJoystickId(rwiAEffVMgQrMGlBNSUEmGfxxMjp, j);
			qhaXlUOXBjJXlxarfbJVCQxEgdA(text, joystickAxisValueByJoystickId);
		}
		for (int k = 0; k < 20; k++)
		{
			string text2 = "Button " + k;
			bool joystickButtonValueByJoystickId = UnityInputHelper.GetJoystickButtonValueByJoystickId(rwiAEffVMgQrMGlBNSUEmGfxxMjp, k);
			qhaXlUOXBjJXlxarfbJVCQxEgdA(text2, joystickButtonValueByJoystickId);
		}
		FCpbsiiscczuXEhXobHBWHMgVXt.text = bUvaInftmWNiFktHvCsNUXlnmMW;
	}

	public void OnDestroy()
	{
	}

	private void qhaXlUOXBjJXlxarfbJVCQxEgdA(string P_0, object P_1)
	{
		string text = bUvaInftmWNiFktHvCsNUXlnmMW;
		bUvaInftmWNiFktHvCsNUXlnmMW = text + P_0 + " = " + P_1.ToString() + "\n";
	}
}
