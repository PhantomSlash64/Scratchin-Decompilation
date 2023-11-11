using System;
using System.Runtime.CompilerServices;

internal abstract class sXMRGCQcXzxOmcumzBGPmYEKWMf : IDisposable
{
	[CompilerGenerated]
	private bool AGUDYBUoBCBnxrhzXCtGJGyeFDP;

	public bool dWavPjnAilGJEegdrXbbgEfgFoTT
	{
		[CompilerGenerated]
		get
		{
			return AGUDYBUoBCBnxrhzXCtGJGyeFDP;
		}
		[CompilerGenerated]
		private set
		{
			AGUDYBUoBCBnxrhzXCtGJGyeFDP = value;
		}
	}

	public event EventHandler<EventArgs> acxiTqtotyjDRNWUoapFUSxkWKt;

	public event EventHandler<EventArgs> FhZdesQSnVczlzbnupkPBGhswUP;

	~sXMRGCQcXzxOmcumzBGPmYEKWMf()
	{
		BVIraKpspohbdfKCLcQhhQBoGazb(false);
	}

	public void Dispose()
	{
		BVIraKpspohbdfKCLcQhhQBoGazb(true);
	}

	private void BVIraKpspohbdfKCLcQhhQBoGazb(bool P_0)
	{
		if (!dWavPjnAilGJEegdrXbbgEfgFoTT)
		{
			this.acxiTqtotyjDRNWUoapFUSxkWKt?.Invoke(this, EventArgs.Empty);
			PMzamCeIIFqnzgwGlxEbIeTHBFUL(P_0);
			GC.SuppressFinalize(this);
			dWavPjnAilGJEegdrXbbgEfgFoTT = true;
			this.FhZdesQSnVczlzbnupkPBGhswUP?.Invoke(this, EventArgs.Empty);
		}
	}

	protected abstract void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0);
}
