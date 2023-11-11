using System;
using Rewired.Utils;
using Rewired.Utils.Attributes;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	public sealed class CustomControllerSelector
	{
		[SerializeField]
		[Tooltip("If true, the Custom Controller will be searched for by its source controller id. This can be used with Find in Player and/or Find Using Tag to further refine the search parameters.")]
		[CustomObfuscation(rename = false)]
		private bool _findUsingSourceId = true;

		[SerializeField]
		[FieldRange(0, int.MaxValue)]
		[CustomObfuscation(rename = false)]
		[Tooltip("The source id of the Custom Controller. This is used to find the Custom Controller if Find Using Source Id is True.")]
		private int _sourceId;

		[SerializeField]
		[Tooltip("If true, the Custom Controller will be found using the tag specified here. This can be used with Find in Player and/or Find Using Source Id to further refine the search parameters.")]
		[CustomObfuscation(rename = false)]
		private bool _findUsingTag;

		[Tooltip("The tag on the Custom Controller you wish to use. This is used to find the Custom Controller.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private string _tag;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		[Tooltip("If true, the Custom Controller will be searched for in the Player specified in the Player Id field. This can be used with Find Using Source Id and/or Find Using Tag to further refine the search parameters.")]
		private bool _findInPlayer;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("The Player Id of the Player that owns the Custom Controller.")]
		private int _playerId;

		public bool findUsingSourceId
		{
			get
			{
				return _findUsingSourceId;
			}
			set
			{
				if (_findUsingSourceId != value)
				{
					_findUsingSourceId = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public int sourceId
		{
			get
			{
				return _sourceId;
			}
			set
			{
				value = MathTools.Max(0, value);
				if (_sourceId != value)
				{
					_sourceId = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool findUsingTag
		{
			get
			{
				return _findUsingTag;
			}
			set
			{
				if (_findUsingTag != value)
				{
					_findUsingTag = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public string tag
		{
			get
			{
				return _tag;
			}
			set
			{
				if (!(_tag == value))
				{
					_tag = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool findInPlayer
		{
			get
			{
				return _findInPlayer;
			}
			set
			{
				if (_findInPlayer != value)
				{
					_findInPlayer = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public int playerId
		{
			get
			{
				return _playerId;
			}
			set
			{
				if (_playerId != value)
				{
					_playerId = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		internal Rewired.CustomController GetCustomController()
		{
			if (!ReInput.isReady)
			{
				return null;
			}
			if (findInPlayer)
			{
				Player player = ReInput.players.GetPlayer(playerId);
				if (player == null)
				{
					Logger.LogError("Invalid playerId " + playerId);
					return null;
				}
			}
			for (int i = 0; i < ReInput.controllers.customControllerCount; i++)
			{
				Rewired.CustomController customController = ReInput.controllers.CustomControllers[i];
				if ((!findUsingSourceId || customController.sourceControllerId == sourceId) && (!findUsingTag || !(customController.tag != tag)) && (!findInPlayer || ReInput.controllers.IsControllerAssignedToPlayer(customController.type, customController.id, playerId)))
				{
					return customController;
				}
			}
			return null;
		}

		private void QCALZHBveTZKrIACkwpJsrxWoUa()
		{
		}
	}
}
