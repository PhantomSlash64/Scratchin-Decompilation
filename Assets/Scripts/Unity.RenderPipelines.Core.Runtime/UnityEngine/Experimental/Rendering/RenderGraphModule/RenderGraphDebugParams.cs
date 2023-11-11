using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal class RenderGraphDebugParams
	{
		public bool clearRenderTargetsAtCreation;

		public bool clearRenderTargetsAtRelease;

		public bool disablePassCulling;

		public bool immediateMode;

		public bool logFrameInformation;

		public bool logResources;

		public void RegisterDebug(string name)
		{
			List<DebugUI.Widget> list = new List<DebugUI.Widget>();
			list.Add(new DebugUI.BoolField
			{
				displayName = "Clear Render Targets at creation",
				getter = () => clearRenderTargetsAtCreation,
				setter = delegate(bool value)
				{
					clearRenderTargetsAtCreation = value;
				}
			});
			list.Add(new DebugUI.BoolField
			{
				displayName = "Disable Pass Culling",
				getter = () => disablePassCulling,
				setter = delegate(bool value)
				{
					disablePassCulling = value;
				}
			});
			list.Add(new DebugUI.BoolField
			{
				displayName = "Immediate Mode",
				getter = () => immediateMode,
				setter = delegate(bool value)
				{
					immediateMode = value;
				}
			});
			list.Add(new DebugUI.Button
			{
				displayName = "Log Frame Information",
				action = delegate
				{
					logFrameInformation = true;
				}
			});
			list.Add(new DebugUI.Button
			{
				displayName = "Log Resources",
				action = delegate
				{
					logResources = true;
				}
			});
			DebugManager.instance.GetPanel((name.Length == 0) ? "Render Graph" : name, createIfNull: true).children.Add(list.ToArray());
		}

		public void UnRegisterDebug(string name)
		{
			DebugManager.instance.RemovePanel((name.Length == 0) ? "Render Graph" : name);
		}
	}
}
