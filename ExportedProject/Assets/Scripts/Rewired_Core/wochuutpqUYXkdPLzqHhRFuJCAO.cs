using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;

internal class wochuutpqUYXkdPLzqHhRFuJCAO
{
	private class PcvWCrnJkLhhwHjYnptsWDWHDJy
	{
		private readonly AList<IControllerTemplate> giKLSgrhLNwAUMnedtVqLxbOwiO;

		private IList McMdjiZCeqttRcaEpDElKzpgaLWa;

		private IList jNYtMlCkOAiYgaaEgbGhJwsuSxA;

		public readonly Type flYmSKXdxEbrkbApyjuUarnstyO;

		public PcvWCrnJkLhhwHjYnptsWDWHDJy(Type type)
		{
			flYmSKXdxEbrkbApyjuUarnstyO = type;
			giKLSgrhLNwAUMnedtVqLxbOwiO = new AList<IControllerTemplate>();
		}

		public IList<T> lNQimYThrafnaIoBhBJyUhJMjHA<T>() where T : IControllerTemplate
		{
			if (McMdjiZCeqttRcaEpDElKzpgaLWa == null)
			{
				qoauBqyfqqWptdCNmnHFATjJEmh<T>();
			}
			return jNYtMlCkOAiYgaaEgbGhJwsuSxA as IList<T>;
		}

		public void SxRenVshBREfxhMTnKRbfUFvwoJi(IControllerTemplate P_0)
		{
			if (P_0 != null)
			{
				giKLSgrhLNwAUMnedtVqLxbOwiO.Add(P_0);
				if (McMdjiZCeqttRcaEpDElKzpgaLWa != null)
				{
					McMdjiZCeqttRcaEpDElKzpgaLWa.Add(P_0);
				}
			}
		}

		public void vtEeJHlHmADXshapyyaNEbLgpF(IControllerTemplate P_0)
		{
			if (P_0 != null)
			{
				giKLSgrhLNwAUMnedtVqLxbOwiO.Remove(P_0);
				if (McMdjiZCeqttRcaEpDElKzpgaLWa != null)
				{
					McMdjiZCeqttRcaEpDElKzpgaLWa.Remove(P_0);
				}
			}
		}

		private void qoauBqyfqqWptdCNmnHFATjJEmh<T>() where T : IControllerTemplate
		{
			McMdjiZCeqttRcaEpDElKzpgaLWa = new AList<T>();
			jNYtMlCkOAiYgaaEgbGhJwsuSxA = new ReadOnlyCollection<T>((AList<T>)McMdjiZCeqttRcaEpDElKzpgaLWa);
			for (int i = 0; i < giKLSgrhLNwAUMnedtVqLxbOwiO._count; i++)
			{
				McMdjiZCeqttRcaEpDElKzpgaLWa.Add(giKLSgrhLNwAUMnedtVqLxbOwiO._items[i]);
			}
		}
	}

	private readonly AList<PcvWCrnJkLhhwHjYnptsWDWHDJy> bbZZfctOelnRnkMIbwwmqdGXCjt;

	private readonly Type[] IkawHaEJNIqVhStsYeiUEgxjKYs;

	private readonly Type[] wNXsZyHRzLYhOahVcPOgbVnuRfy;

	private readonly int KVUUPjpozXVYcLtRfOARzlZaLGg;

	public wochuutpqUYXkdPLzqHhRFuJCAO(Type[] templateTypes, Type[] interfaceTypes)
	{
		if (templateTypes.Length != interfaceTypes.Length)
		{
			throw new Exception("Controller template types and controller template interface types array lengths do not match.");
		}
		IkawHaEJNIqVhStsYeiUEgxjKYs = templateTypes;
		wNXsZyHRzLYhOahVcPOgbVnuRfy = interfaceTypes;
		KVUUPjpozXVYcLtRfOARzlZaLGg = IkawHaEJNIqVhStsYeiUEgxjKYs.Length;
		bbZZfctOelnRnkMIbwwmqdGXCjt = new AList<PcvWCrnJkLhhwHjYnptsWDWHDJy>();
		for (int i = 0; i < KVUUPjpozXVYcLtRfOARzlZaLGg; i++)
		{
			bbZZfctOelnRnkMIbwwmqdGXCjt.Add(new PcvWCrnJkLhhwHjYnptsWDWHDJy(wNXsZyHRzLYhOahVcPOgbVnuRfy[i]));
		}
	}

	public void rXfrpsKYmqSvVJAFxhmUjsiGnVlp(Controller P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		int templateCount = P_0.templateCount;
		for (int i = 0; i < templateCount; i++)
		{
			IControllerTemplate controllerTemplate = P_0.Templates[i];
			if (controllerTemplate == null)
			{
				Logger.LogError("Template was null.");
				continue;
			}
			Type type = ZxMRVezBdKJVqbdYOSBUbHHsASL(controllerTemplate.GetType());
			if ((object)type == null)
			{
				Logger.LogError("Interface type " + controllerTemplate.GetType().Name + " was not found.");
			}
			else
			{
				qHngPLvVSaiURrDiZfMLjMnRgpc(type)?.SxRenVshBREfxhMTnKRbfUFvwoJi(controllerTemplate);
			}
		}
	}

	public void QGwSMXaWKSCNARuGHBNVpuHCjHs(Controller P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		int templateCount = P_0.templateCount;
		for (int i = 0; i < templateCount; i++)
		{
			IControllerTemplate controllerTemplate = P_0.Templates[i];
			if (controllerTemplate == null)
			{
				Logger.LogError("Template was null.");
				continue;
			}
			Type type = ZxMRVezBdKJVqbdYOSBUbHHsASL(controllerTemplate.GetType());
			if ((object)type == null)
			{
				Logger.LogError("Interface type " + controllerTemplate.GetType().Name + " was not found.");
			}
			else
			{
				qHngPLvVSaiURrDiZfMLjMnRgpc(type)?.vtEeJHlHmADXshapyyaNEbLgpF(controllerTemplate);
			}
		}
	}

	public IList<T> lNQimYThrafnaIoBhBJyUhJMjHA<T>() where T : IControllerTemplate
	{
		Type typeFromHandle = typeof(T);
		for (int i = 0; i < bbZZfctOelnRnkMIbwwmqdGXCjt._count; i++)
		{
			PcvWCrnJkLhhwHjYnptsWDWHDJy pcvWCrnJkLhhwHjYnptsWDWHDJy = bbZZfctOelnRnkMIbwwmqdGXCjt._items[i];
			if (object.ReferenceEquals(pcvWCrnJkLhhwHjYnptsWDWHDJy.flYmSKXdxEbrkbApyjuUarnstyO, typeFromHandle))
			{
				return pcvWCrnJkLhhwHjYnptsWDWHDJy.lNQimYThrafnaIoBhBJyUhJMjHA<T>();
			}
		}
		string text = "";
		for (int j = 0; j < wNXsZyHRzLYhOahVcPOgbVnuRfy.Length; j++)
		{
			text += wNXsZyHRzLYhOahVcPOgbVnuRfy[j].Name;
			if (j != wNXsZyHRzLYhOahVcPOgbVnuRfy.Length - 1)
			{
				text += "\n";
			}
		}
		Logger.LogError("Invalid Controller Template type \"" + typeFromHandle.Name + "\". Only the following Controller Template interface types are allowed:\n" + text);
		return EmptyObjects<T>.EmptyReadOnlyIListT;
	}

	private PcvWCrnJkLhhwHjYnptsWDWHDJy qHngPLvVSaiURrDiZfMLjMnRgpc(Type P_0)
	{
		for (int i = 0; i < bbZZfctOelnRnkMIbwwmqdGXCjt._count; i++)
		{
			if (object.ReferenceEquals(P_0, bbZZfctOelnRnkMIbwwmqdGXCjt._items[i].flYmSKXdxEbrkbApyjuUarnstyO))
			{
				return bbZZfctOelnRnkMIbwwmqdGXCjt._items[i];
			}
		}
		return null;
	}

	private Type ZxMRVezBdKJVqbdYOSBUbHHsASL(Type P_0)
	{
		for (int i = 0; i < KVUUPjpozXVYcLtRfOARzlZaLGg; i++)
		{
			if (object.ReferenceEquals(IkawHaEJNIqVhStsYeiUEgxjKYs[i], P_0))
			{
				return wNXsZyHRzLYhOahVcPOgbVnuRfy[i];
			}
		}
		return null;
	}
}
