using System;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	internal sealed class ControllerTemplateElementIdentifier_Editor : ControllerTemplateElementIdentifier, IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier, IControllerTemplateElementIdentifier_Editor
	{
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private string _scriptingName;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private string _alternateScriptingName;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _excludeFromExport;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private bool _useEditorElementTypeOverride;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private ControllerElementType _editorElementTypeOverride;

		internal string scriptingName
		{
			get
			{
				return _scriptingName;
			}
			set
			{
				_scriptingName = value;
			}
		}

		internal string alternateScriptingName
		{
			get
			{
				return _alternateScriptingName;
			}
			set
			{
				_alternateScriptingName = value;
			}
		}

		internal bool excludeFromExport => _excludeFromExport;

		internal override bool useEditorElementTypeOverride => _useEditorElementTypeOverride;

		internal override ControllerElementType editorElementTypeOverride => _editorElementTypeOverride;

		internal ControllerTemplateElementType effectiveElementType
		{
			get
			{
				if (!_useEditorElementTypeOverride)
				{
					return base.elementType;
				}
				return BbpfTcGSZRHmltstKOfXrucHPJO.nudKFIJmOVjJPNopdgOxQThceWi(_editorElementTypeOverride, false);
			}
		}

		string IControllerTemplateElementIdentifier_Editor.scriptingName => _scriptingName;

		string IControllerTemplateElementIdentifier_Editor.alternateScriptingName => _alternateScriptingName;

		public ControllerTemplateElementIdentifier_Editor()
		{
		}

		public ControllerTemplateElementIdentifier_Editor(ControllerTemplateElementIdentifier_Editor source)
			: base(source)
		{
			_scriptingName = source._scriptingName;
			_alternateScriptingName = source._alternateScriptingName;
			_excludeFromExport = source._excludeFromExport;
			_editorElementTypeOverride = source._editorElementTypeOverride;
			_useEditorElementTypeOverride = source._useEditorElementTypeOverride;
		}

		public override ControllerTemplateElementIdentifier Clone()
		{
			return new ControllerTemplateElementIdentifier_Editor(this);
		}
	}
}
