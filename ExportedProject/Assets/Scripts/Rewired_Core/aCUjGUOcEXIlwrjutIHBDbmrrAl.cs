using System;
using System.Collections.Generic;
using Rewired;
using Rewired.Utils;
using UnityEngine;

internal static class aCUjGUOcEXIlwrjutIHBDbmrrAl
{
	[CustomObfuscation(rename = false)]
	public delegate void EventFunction<T, TArgs>(T handler, TArgs value) where T : class;

	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	public class HierarchyEventHelper<THandler, TValue> where THandler : class
	{
		[Flags]
		public enum vtiWhEFOQTYDiYDpVsDLNTwoAgA
		{
			fUyeeVFhkdEderlnmYYFoAwmZEL = 0,
			BHfTRXTrjZGLuAZypWqahpfSYuB = 1,
			bAHCoppFcbVUVUHFRZFzvQzTYCM = 4,
			AJLUtwAvZMCnQCMmPbGGKtJhYbc = 8,
			LLjDhcTKbrFjHTkmwhdefbZbPpG = -1
		}

		private readonly EventFunction<THandler, TValue> lKLKzhppJEGuyvpZMBhDuJwEQcW;

		private readonly List<THandler> ZgWZSiPDBQbhNsdQvTAgSKSPckp;

		private readonly vtiWhEFOQTYDiYDpVsDLNTwoAgA VTucDLFKOlemuAVNbaEhujjNjTvI;

		public HierarchyEventHelper(EventFunction<THandler, TValue> executeDelegate)
			: this(executeDelegate, vtiWhEFOQTYDiYDpVsDLNTwoAgA.BHfTRXTrjZGLuAZypWqahpfSYuB | vtiWhEFOQTYDiYDpVsDLNTwoAgA.bAHCoppFcbVUVUHFRZFzvQzTYCM)
		{
		}

		public HierarchyEventHelper(EventFunction<THandler, TValue> executeDelegate, vtiWhEFOQTYDiYDpVsDLNTwoAgA executeOn)
		{
			if (executeDelegate == null)
			{
				throw new ArgumentNullException("delegate");
			}
			lKLKzhppJEGuyvpZMBhDuJwEQcW = executeDelegate;
			ZgWZSiPDBQbhNsdQvTAgSKSPckp = new List<THandler>();
			VTucDLFKOlemuAVNbaEhujjNjTvI = executeOn;
		}

		public void ExecuteOnAll(TValue value)
		{
			QOODAtJGiwSOUqzbpVANsAiBtm(ZgWZSiPDBQbhNsdQvTAgSKSPckp, value, lKLKzhppJEGuyvpZMBhDuJwEQcW, true);
		}

		public void GetHandlers(Transform transform)
		{
			if ((VTucDLFKOlemuAVNbaEhujjNjTvI & vtiWhEFOQTYDiYDpVsDLNTwoAgA.BHfTRXTrjZGLuAZypWqahpfSYuB) != 0 && (VTucDLFKOlemuAVNbaEhujjNjTvI & vtiWhEFOQTYDiYDpVsDLNTwoAgA.bAHCoppFcbVUVUHFRZFzvQzTYCM) != 0 && (VTucDLFKOlemuAVNbaEhujjNjTvI & vtiWhEFOQTYDiYDpVsDLNTwoAgA.AJLUtwAvZMCnQCMmPbGGKtJhYbc) != 0)
			{
				UnityTools.GetComponentsInSelfAndChildren(transform.root, ZgWZSiPDBQbhNsdQvTAgSKSPckp, append: false);
				return;
			}
			if ((VTucDLFKOlemuAVNbaEhujjNjTvI & vtiWhEFOQTYDiYDpVsDLNTwoAgA.bAHCoppFcbVUVUHFRZFzvQzTYCM) != 0)
			{
				if ((VTucDLFKOlemuAVNbaEhujjNjTvI & vtiWhEFOQTYDiYDpVsDLNTwoAgA.BHfTRXTrjZGLuAZypWqahpfSYuB) != 0)
				{
					UnityTools.GetComponentsInSelfAndChildren(transform, ZgWZSiPDBQbhNsdQvTAgSKSPckp, append: true);
				}
				else
				{
					UnityTools.GetComponents(transform, ZgWZSiPDBQbhNsdQvTAgSKSPckp, append: true);
				}
			}
			if ((VTucDLFKOlemuAVNbaEhujjNjTvI & vtiWhEFOQTYDiYDpVsDLNTwoAgA.AJLUtwAvZMCnQCMmPbGGKtJhYbc) != 0)
			{
				UnityTools.GetComponentsInParents(transform, ZgWZSiPDBQbhNsdQvTAgSKSPckp, append: true);
			}
		}
	}

	public static void fvdEgLPBdWfBVFFzEkxvVzVATQcR<T, TArgs>(T P_0, TArgs P_1, EventFunction<T, TArgs> P_2) where T : class
	{
		if (P_2 == null)
		{
			throw new ArgumentNullException("executeDelegate");
		}
		if (P_0 == null)
		{
			throw new ArgumentNullException("handler");
		}
		try
		{
			P_2(P_0, P_1);
		}
		catch (Exception ex)
		{
			Rewired.Logger.LogError("Caught exception in event handler:\n" + ex);
		}
	}

	public static void fvdEgLPBdWfBVFFzEkxvVzVATQcR<T, TArgs>(IList<T> P_0, TArgs P_1, EventFunction<T, TArgs> P_2) where T : class
	{
		if (P_2 == null)
		{
			throw new ArgumentNullException("executeDelegate");
		}
		if (P_0 == null)
		{
			throw new ArgumentNullException("handlers");
		}
		int count = P_0.Count;
		for (int i = 0; i < count; i++)
		{
			T val = P_0[i];
			if (val != null)
			{
				try
				{
					P_2(val, P_1);
				}
				catch (Exception ex)
				{
					Rewired.Logger.LogError("Caught exception in event handler:\n" + ex);
				}
			}
		}
	}

	public static void QOODAtJGiwSOUqzbpVANsAiBtm<T, TArgs>(IList<T> P_0, TArgs P_1, EventFunction<T, TArgs> P_2, bool P_3) where T : class
	{
		if (P_2 == null)
		{
			throw new ArgumentNullException("executeDelegate");
		}
		if (P_0 == null)
		{
			throw new ArgumentNullException("handlers");
		}
		int num = P_0.Count;
		for (int i = 0; i < num; i++)
		{
			T val = P_0[i];
			if (val as Component == null)
			{
				if (P_3)
				{
					P_0.RemoveAt(i);
					i--;
					num--;
				}
			}
			else
			{
				try
				{
					P_2(val, P_1);
				}
				catch (Exception ex)
				{
					Rewired.Logger.LogError("Caught exception in event handler:\n" + ex);
				}
			}
		}
	}
}
