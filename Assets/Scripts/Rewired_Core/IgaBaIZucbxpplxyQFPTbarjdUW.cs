using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired;
using Rewired.Data;

internal class IgaBaIZucbxpplxyQFPTbarjdUW
{
	private int tJlELxQpfxUbMxhAzXbEJEmaMfv;

	private int pBtboVKMuIDuJBzELtvwbCXyVkle;

	private Player yNADsZEDfVHBdzVahFEbcLpkVTBO;

	private Player[] AHATpKuuagFJdvGUIQJLKUJBvTf;

	private Player[] PGmUlACNPbcUVVxoZHQHmyDtIlz;

	private IList<Player> ZgDHfZIafDFwxXYXXtUdWdIjVWu;

	private IList<Player> MtVUniYMBBizxHahBgUiZDnBqbiz;

	private ConfigVars wsqAVTjIqNDRqGlAEGJnDQDDBDPp;

	private bool sQTBWTNxxjaWNFsekFBPFIwaffDK;

	public int NLEpalNfODFjJdDoCFTTlDEgNFWP => tJlELxQpfxUbMxhAzXbEJEmaMfv;

	public int oSarMBcfjNTXBjKUPFrfGRvrNvg => pBtboVKMuIDuJBzELtvwbCXyVkle;

	public Player[] OxyBMJoLSnuINnjJbjwxOnluXdE => AHATpKuuagFJdvGUIQJLKUJBvTf;

	public Player[] ScSRLIvTiupEEFPdeQkuejIgEwXC => PGmUlACNPbcUVVxoZHQHmyDtIlz;

	public IList<Player> XBmQMIGjKCKiWxZTMiAxCRnDpms => MtVUniYMBBizxHahBgUiZDnBqbiz;

	public IList<Player> TdDjMQjxsetnDFRTEyCUGBlCNULw => ZgDHfZIafDFwxXYXXtUdWdIjVWu;

	public IgaBaIZucbxpplxyQFPTbarjdUW(ConfigVars configVars)
	{
		wsqAVTjIqNDRqGlAEGJnDQDDBDPp = configVars;
	}

	public void ijQPrfbohIDtyfCSvLMVhrlmSpB()
	{
		if (sQTBWTNxxjaWNFsekFBPFIwaffDK)
		{
			return;
		}
		pBtboVKMuIDuJBzELtvwbCXyVkle = ReInput.UserData.playerCount;
		tJlELxQpfxUbMxhAzXbEJEmaMfv = pBtboVKMuIDuJBzELtvwbCXyVkle - 1;
		PGmUlACNPbcUVVxoZHQHmyDtIlz = new Player[tJlELxQpfxUbMxhAzXbEJEmaMfv];
		AHATpKuuagFJdvGUIQJLKUJBvTf = new Player[pBtboVKMuIDuJBzELtvwbCXyVkle];
		IList<Player_Editor> players_readOnly = ReInput.UserData.Players_readOnly;
		if (players_readOnly == null)
		{
			throw new ArgumentNullException("Players cannot be null!");
		}
		for (int i = 0; i < players_readOnly.Count; i++)
		{
			Player_Editor player_Editor = players_readOnly[i];
			hoGZGoKcYjvzMpyhYIdlAPtnxIh startingControllerMapInfo = player_Editor.mxWhjvUZEzirQJYkqEAMYLCggjvA();
			ControllerMapLayoutManager.lRHvetoYBHZvdHTlYVwfdpCPcAs controllerMapLayoutManagerSettings = player_Editor.controllerMapLayoutManagerSettings.pRKrGlOxYBVuYhJzdFUPxUehMOi();
			ControllerMapEnabler.xIhBRlVXbtrPkJZqdoJCRHAyPSc controllerMapEnablerSettings = player_Editor.controllerMapEnablerSettings.pRKrGlOxYBVuYhJzdFUPxUehMOi();
			Player player;
			if (i == 0)
			{
				player = (yNADsZEDfVHBdzVahFEbcLpkVTBO = new Player(isSystem: true, 9999999, player_Editor.name, player_Editor.descriptiveName, startingControllerMapInfo, controllerMapLayoutManagerSettings, controllerMapEnablerSettings));
			}
			else
			{
				player = new Player(isSystem: false, i - 1, player_Editor.name, player_Editor.descriptiveName, startingControllerMapInfo, controllerMapLayoutManagerSettings, controllerMapEnablerSettings);
				PGmUlACNPbcUVVxoZHQHmyDtIlz[i - 1] = player;
			}
			AHATpKuuagFJdvGUIQJLKUJBvTf[i] = player;
			player.isPlaying = player_Editor.startPlaying;
			player.controllers.hasMouse = player_Editor.assignMouseOnStart;
			player.controllers.hasKeyboard = player_Editor.assignKeyboardOnStart;
			player.controllers.excludeFromControllerAutoAssignment = player_Editor.excludeFromControllerAutoAssignment;
			player.controllers.maps.pdsPntvZRmLdnPXkPsrHZHwBQMd(true);
			player.controllers.maps.iDfbghcMlaGnlCtgBDgFLIJpUkWG(true);
		}
		ZgDHfZIafDFwxXYXXtUdWdIjVWu = new ReadOnlyCollection<Player>(PGmUlACNPbcUVVxoZHQHmyDtIlz);
		MtVUniYMBBizxHahBgUiZDnBqbiz = new ReadOnlyCollection<Player>(AHATpKuuagFJdvGUIQJLKUJBvTf);
		sQTBWTNxxjaWNFsekFBPFIwaffDK = true;
	}

	public void VyWIhItGhSxSEjJCkrmWFbQURHc(Joystick P_0)
	{
		if (ReInput.controllerAssigner != null && ReInput.controllerAssigner.CanHandleAssignment(ControllerType.Joystick, P_0))
		{
			ReInput.controllerAssigner.AssignController(ControllerType.Joystick, P_0);
		}
		else if (!wsqAVTjIqNDRqGlAEGJnDQDDBDPp.reassignJoystickToPreviousOwnerOnReconnect || !BqypRstRTTufUiIXGIxYWxDSLEA(P_0))
		{
			BuwcSpQAJCZWIaAkvSMuDmSBEOQ(P_0);
		}
	}

	public void aZWbkiBOxODPcIADgntnipJaMwue(Joystick P_0)
	{
		if (wsqAVTjIqNDRqGlAEGJnDQDDBDPp.autoAssignJoysticks)
		{
			VyWIhItGhSxSEjJCkrmWFbQURHc(P_0);
		}
	}

	public void dtXEdAqZRgEMhsrbkILgSLkCBYHB(ControllerType P_0, int P_1)
	{
		for (int i = 0; i < pBtboVKMuIDuJBzELtvwbCXyVkle; i++)
		{
			AHATpKuuagFJdvGUIQJLKUJBvTf[i].controllers.RemoveController(P_0, P_1);
		}
	}

	public Player fFKuoGTmbMrpFMTwXsWqdvvrhNG(int P_0)
	{
		if (P_0 != 9999999 && (P_0 < 0 || P_0 >= tJlELxQpfxUbMxhAzXbEJEmaMfv))
		{
			Logger.LogError("Player id " + P_0 + " does not exist!");
			return null;
		}
		if (P_0 == 9999999)
		{
			return yNADsZEDfVHBdzVahFEbcLpkVTBO;
		}
		for (int i = 0; i < tJlELxQpfxUbMxhAzXbEJEmaMfv; i++)
		{
			if (PGmUlACNPbcUVVxoZHQHmyDtIlz[i].id == P_0)
			{
				return PGmUlACNPbcUVVxoZHQHmyDtIlz[P_0];
			}
		}
		return null;
	}

	public Player fFKuoGTmbMrpFMTwXsWqdvvrhNG(string P_0)
	{
		if (P_0 != null && !(P_0 == string.Empty))
		{
			if (yNADsZEDfVHBdzVahFEbcLpkVTBO.name.Equals(P_0, StringComparison.OrdinalIgnoreCase))
			{
				return yNADsZEDfVHBdzVahFEbcLpkVTBO;
			}
			for (int i = 0; i < tJlELxQpfxUbMxhAzXbEJEmaMfv; i++)
			{
				if (PGmUlACNPbcUVVxoZHQHmyDtIlz[i].name.Equals(P_0, StringComparison.OrdinalIgnoreCase))
				{
					return PGmUlACNPbcUVVxoZHQHmyDtIlz[i];
				}
			}
		}
		Logger.LogError("Player \"" + P_0 + "\" does not exist!");
		return null;
	}

	public Player iZJWprFjAAltkususAHsWjhtNDP()
	{
		return yNADsZEDfVHBdzVahFEbcLpkVTBO;
	}

	public int OHuyewEnBAsmCWItZdFIiMcmJbz(string P_0)
	{
		if (P_0 == null || P_0 == string.Empty)
		{
			return -1;
		}
		if (yNADsZEDfVHBdzVahFEbcLpkVTBO.name.Equals(P_0, StringComparison.OrdinalIgnoreCase))
		{
			return 9999999;
		}
		for (int i = 0; i < tJlELxQpfxUbMxhAzXbEJEmaMfv; i++)
		{
			if (PGmUlACNPbcUVVxoZHQHmyDtIlz[i].name.Equals(P_0, StringComparison.OrdinalIgnoreCase))
			{
				return PGmUlACNPbcUVVxoZHQHmyDtIlz[i].id;
			}
		}
		return -1;
	}

	public bool kKZHnwadKpinaoikthYpxtWlAkO(int P_0)
	{
		if (P_0 != 9999999 && (P_0 < 0 || P_0 >= tJlELxQpfxUbMxhAzXbEJEmaMfv))
		{
			return false;
		}
		return true;
	}

	public Player[] BUlKogcXPycpFtWgLvtCtOeBODp(bool P_0)
	{
		int num = tJlELxQpfxUbMxhAzXbEJEmaMfv;
		if (P_0)
		{
			num++;
		}
		Player[] array = new Player[num];
		int num2 = 0;
		if (P_0)
		{
			array[0] = yNADsZEDfVHBdzVahFEbcLpkVTBO;
			num2 = 1;
		}
		for (int i = 0; i < tJlELxQpfxUbMxhAzXbEJEmaMfv; i++)
		{
			array[num2 + i] = PGmUlACNPbcUVVxoZHQHmyDtIlz[i];
		}
		return array;
	}

	public string[] TLBTsonOINiALJclXjrIXNhexfSu(bool P_0)
	{
		int num = tJlELxQpfxUbMxhAzXbEJEmaMfv;
		if (P_0)
		{
			num++;
		}
		string[] array = new string[num];
		int num2 = 0;
		if (P_0)
		{
			array[0] = yNADsZEDfVHBdzVahFEbcLpkVTBO.name;
			num2 = 1;
		}
		for (int i = 0; i < tJlELxQpfxUbMxhAzXbEJEmaMfv; i++)
		{
			array[num2 + i] = PGmUlACNPbcUVVxoZHQHmyDtIlz[i].name;
		}
		return array;
	}

	public string[] JAYziTJCEcBpGZqNzRahpKnXIhfd(bool P_0)
	{
		int num = tJlELxQpfxUbMxhAzXbEJEmaMfv;
		if (P_0)
		{
			num++;
		}
		string[] array = new string[num];
		int num2 = 0;
		if (P_0)
		{
			array[0] = yNADsZEDfVHBdzVahFEbcLpkVTBO.descriptiveName;
			num2 = 1;
		}
		for (int i = 0; i < tJlELxQpfxUbMxhAzXbEJEmaMfv; i++)
		{
			array[num2 + i] = PGmUlACNPbcUVVxoZHQHmyDtIlz[i].descriptiveName;
		}
		return array;
	}

	public int[] RGLYuWhbxxOTozqOgdFuhsKmkxR(bool P_0)
	{
		int num = tJlELxQpfxUbMxhAzXbEJEmaMfv;
		if (P_0)
		{
			num++;
		}
		int[] array = new int[num];
		int num2 = 0;
		if (P_0)
		{
			array[0] = yNADsZEDfVHBdzVahFEbcLpkVTBO.id;
			num2 = 1;
		}
		for (int i = 0; i < tJlELxQpfxUbMxhAzXbEJEmaMfv; i++)
		{
			array[num2 + i] = PGmUlACNPbcUVVxoZHQHmyDtIlz[i].id;
		}
		return array;
	}

	public bool SlsYfLFiuIuKBaQKiUdIlrKVgwt(Controller P_0)
	{
		if (P_0 == null || AHATpKuuagFJdvGUIQJLKUJBvTf == null)
		{
			return false;
		}
		return SlsYfLFiuIuKBaQKiUdIlrKVgwt(P_0.type, P_0.id);
	}

	public bool SlsYfLFiuIuKBaQKiUdIlrKVgwt(ControllerType P_0, int P_1)
	{
		if (AHATpKuuagFJdvGUIQJLKUJBvTf == null)
		{
			return false;
		}
		for (int i = 0; i < AHATpKuuagFJdvGUIQJLKUJBvTf.Length; i++)
		{
			if (AHATpKuuagFJdvGUIQJLKUJBvTf[i].controllers.ContainsController(P_0, P_1))
			{
				return true;
			}
		}
		return false;
	}

	public bool bKntgmyGjyazWFJbYvPqjxmirnBN(ControllerType P_0, int P_1, int P_2)
	{
		return fFKuoGTmbMrpFMTwXsWqdvvrhNG(P_2)?.controllers.ContainsController(P_0, P_1) ?? false;
	}

	public void EHrbNUBocfEQVxXyOIOUDfWyOaXa(Controller P_0, bool P_1)
	{
		if (P_0 != null)
		{
			if (P_1)
			{
				yNADsZEDfVHBdzVahFEbcLpkVTBO.controllers.RemoveController(P_0);
			}
			for (int i = 0; i < tJlELxQpfxUbMxhAzXbEJEmaMfv; i++)
			{
				PGmUlACNPbcUVVxoZHQHmyDtIlz[i].controllers.RemoveController(P_0);
			}
		}
	}

	public void EHrbNUBocfEQVxXyOIOUDfWyOaXa(ControllerType P_0, int P_1, bool P_2)
	{
		Controller controller = ReInput.controllers.GetController(P_0, P_1);
		if (controller != null)
		{
			EHrbNUBocfEQVxXyOIOUDfWyOaXa(controller, P_2);
		}
	}

	public bool kwUmQWagqcFRBBbxAyNgkOFtWUOb(Joystick P_0)
	{
		if (P_0 == null || AHATpKuuagFJdvGUIQJLKUJBvTf == null)
		{
			return false;
		}
		for (int i = 0; i < AHATpKuuagFJdvGUIQJLKUJBvTf.Length; i++)
		{
			if (AHATpKuuagFJdvGUIQJLKUJBvTf[i].controllers.ContainsController(P_0))
			{
				return true;
			}
		}
		return false;
	}

	public bool kwUmQWagqcFRBBbxAyNgkOFtWUOb(int P_0)
	{
		if (AHATpKuuagFJdvGUIQJLKUJBvTf == null)
		{
			return false;
		}
		for (int i = 0; i < AHATpKuuagFJdvGUIQJLKUJBvTf.Length; i++)
		{
			if (AHATpKuuagFJdvGUIQJLKUJBvTf[i].controllers.ContainsController(ControllerType.Joystick, P_0))
			{
				return true;
			}
		}
		return false;
	}

	public bool QbbwFfJhffUmWMJOrFbXaAhwmhC(int P_0, int P_1)
	{
		return fFKuoGTmbMrpFMTwXsWqdvvrhNG(P_1)?.controllers.ContainsController(ControllerType.Joystick, P_0) ?? false;
	}

	public void GapalyaAwKpNlcbqgsiwPGaCKKnG(Joystick P_0, bool P_1)
	{
		if (P_0 != null)
		{
			if (P_1)
			{
				yNADsZEDfVHBdzVahFEbcLpkVTBO.controllers.JWZmhyjAyCCSfFSFTwjTOGtVJIh(P_0);
			}
			for (int i = 0; i < tJlELxQpfxUbMxhAzXbEJEmaMfv; i++)
			{
				PGmUlACNPbcUVVxoZHQHmyDtIlz[i].controllers.JWZmhyjAyCCSfFSFTwjTOGtVJIh(P_0);
			}
		}
	}

	public void GapalyaAwKpNlcbqgsiwPGaCKKnG(int P_0, bool P_1)
	{
		Joystick joystick = ReInput.controllers.GetJoystick(P_0);
		if (joystick != null)
		{
			GapalyaAwKpNlcbqgsiwPGaCKKnG(joystick, P_1);
		}
	}

	public bool bkoftzdrzQyGVqwFyrrPXquXqCO(CustomController P_0)
	{
		if (P_0 == null || AHATpKuuagFJdvGUIQJLKUJBvTf == null)
		{
			return false;
		}
		for (int i = 0; i < AHATpKuuagFJdvGUIQJLKUJBvTf.Length; i++)
		{
			if (AHATpKuuagFJdvGUIQJLKUJBvTf[i].controllers.ContainsController(P_0))
			{
				return true;
			}
		}
		return false;
	}

	public bool bkoftzdrzQyGVqwFyrrPXquXqCO(int P_0)
	{
		if (AHATpKuuagFJdvGUIQJLKUJBvTf == null)
		{
			return false;
		}
		for (int i = 0; i < AHATpKuuagFJdvGUIQJLKUJBvTf.Length; i++)
		{
			if (AHATpKuuagFJdvGUIQJLKUJBvTf[i].controllers.ContainsController(ControllerType.Custom, P_0))
			{
				return true;
			}
		}
		return false;
	}

	public bool eNWBkTEhPScqFKjrgRdEuHrKcRlA(int P_0, int P_1)
	{
		return fFKuoGTmbMrpFMTwXsWqdvvrhNG(P_1)?.controllers.ContainsController(ControllerType.Custom, P_0) ?? false;
	}

	public void JNaLNXRUyUdbrEjqRgXrQDdCTtg(CustomController P_0, bool P_1)
	{
		if (P_0 != null)
		{
			if (P_1)
			{
				yNADsZEDfVHBdzVahFEbcLpkVTBO.controllers.bPqJQkzKFDbRgIQpDdYVjahWPJBg(P_0);
			}
			for (int i = 0; i < tJlELxQpfxUbMxhAzXbEJEmaMfv; i++)
			{
				PGmUlACNPbcUVVxoZHQHmyDtIlz[i].controllers.bPqJQkzKFDbRgIQpDdYVjahWPJBg(P_0);
			}
		}
	}

	public void JNaLNXRUyUdbrEjqRgXrQDdCTtg(int P_0, bool P_1)
	{
		CustomController customController = ReInput.controllers.GetCustomController(P_0);
		if (customController != null)
		{
			JNaLNXRUyUdbrEjqRgXrQDdCTtg(customController, P_1);
		}
	}

	private bool BqypRstRTTufUiIXGIxYWxDSLEA(Joystick P_0)
	{
		if (wsqAVTjIqNDRqGlAEGJnDQDDBDPp.distributeJoysticksEvenly)
		{
			int num = bIAJckapBNvlhXCscwptgUCOtry();
			if (num < 0)
			{
				return false;
			}
			int num2 = zUSeWGHfpFeJWkRhZpThTSjZUZhF(P_0.id);
			if (num2 < 0)
			{
				return false;
			}
			Player player = PGmUlACNPbcUVVxoZHQHmyDtIlz[num];
			Player player2 = PGmUlACNPbcUVVxoZHQHmyDtIlz[num2];
			if (num2 >= 0 && player2.controllers.joystickCount <= player.controllers.joystickCount)
			{
				PGmUlACNPbcUVVxoZHQHmyDtIlz[num2].controllers.jXcIleFqupiPcaNOuNJYVoHIGet(P_0, true);
				return true;
			}
			return false;
		}
		int num3 = zUSeWGHfpFeJWkRhZpThTSjZUZhF(P_0.id);
		if (num3 < 0)
		{
			return false;
		}
		PGmUlACNPbcUVVxoZHQHmyDtIlz[num3].controllers.jXcIleFqupiPcaNOuNJYVoHIGet(P_0, true);
		return true;
	}

	private bool BuwcSpQAJCZWIaAkvSMuDmSBEOQ(Joystick P_0)
	{
		if (wsqAVTjIqNDRqGlAEGJnDQDDBDPp.distributeJoysticksEvenly)
		{
			int num = bIAJckapBNvlhXCscwptgUCOtry();
			if (num >= 0)
			{
				PGmUlACNPbcUVVxoZHQHmyDtIlz[num].controllers.jXcIleFqupiPcaNOuNJYVoHIGet(P_0, true);
				return true;
			}
		}
		else
		{
			for (int i = 0; i < tJlELxQpfxUbMxhAzXbEJEmaMfv; i++)
			{
				Player player = PGmUlACNPbcUVVxoZHQHmyDtIlz[i];
				if (!player.controllers.excludeFromControllerAutoAssignment && (!wsqAVTjIqNDRqGlAEGJnDQDDBDPp.assignJoysticksToPlayingPlayersOnly || player.isPlaying) && player.controllers.joystickCount < wsqAVTjIqNDRqGlAEGJnDQDDBDPp.maxJoysticksPerPlayer)
				{
					player.controllers.jXcIleFqupiPcaNOuNJYVoHIGet(P_0, true);
					return true;
				}
			}
		}
		return false;
	}

	private int bIAJckapBNvlhXCscwptgUCOtry()
	{
		int num = -1;
		int num2 = 0;
		for (int i = 0; i < tJlELxQpfxUbMxhAzXbEJEmaMfv; i++)
		{
			Player player = PGmUlACNPbcUVVxoZHQHmyDtIlz[i];
			if (!player.controllers.excludeFromControllerAutoAssignment && (!wsqAVTjIqNDRqGlAEGJnDQDDBDPp.assignJoysticksToPlayingPlayersOnly || player.isPlaying))
			{
				int joystickCount = player.controllers.joystickCount;
				if (joystickCount < wsqAVTjIqNDRqGlAEGJnDQDDBDPp.maxJoysticksPerPlayer && (num == -1 || joystickCount < num2))
				{
					num = i;
					num2 = joystickCount;
				}
			}
		}
		return num;
	}

	public int zUSeWGHfpFeJWkRhZpThTSjZUZhF(int P_0)
	{
		int num = -1;
		double num2 = 0.0;
		for (int i = 0; i < tJlELxQpfxUbMxhAzXbEJEmaMfv; i++)
		{
			Player player = PGmUlACNPbcUVVxoZHQHmyDtIlz[i];
			if (!player.controllers.excludeFromControllerAutoAssignment && (!wsqAVTjIqNDRqGlAEGJnDQDDBDPp.assignJoysticksToPlayingPlayersOnly || player.isPlaying) && player.controllers.joystickCount < wsqAVTjIqNDRqGlAEGJnDQDDBDPp.maxJoysticksPerPlayer)
			{
				double num3 = player.controllers.dfdOiowwLZcMZBIipiTiccpUkTG(P_0);
				if (!(num3 < 0.0) && (num < 0 || num3 > num2))
				{
					num2 = num3;
					num = i;
				}
			}
		}
		return num;
	}
}
