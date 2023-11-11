using Rewired.Utils;

internal struct lRSfiBroMYjWUDXxdgmaOiFISuD
{
	public float BMNgtthGpqCSTnlmLgeEDQRCdItL;

	public float pTKbMhixySNJoEdgwZWgQxGJIbx;

	public float iTlxJdyaFwEJdfRgiouoDdRUJTlE;

	public static lRSfiBroMYjWUDXxdgmaOiFISuD RQhVdlJmHBUBxjFOXASAGOUlEEU
	{
		get
		{
			lRSfiBroMYjWUDXxdgmaOiFISuD result = default(lRSfiBroMYjWUDXxdgmaOiFISuD);
			result.BMNgtthGpqCSTnlmLgeEDQRCdItL = 0f;
			result.pTKbMhixySNJoEdgwZWgQxGJIbx = 0f;
			result.iTlxJdyaFwEJdfRgiouoDdRUJTlE = 0f;
			return result;
		}
	}

	public lRSfiBroMYjWUDXxdgmaOiFISuD(float inX, float inY, float inZ)
	{
		BMNgtthGpqCSTnlmLgeEDQRCdItL = inX;
		pTKbMhixySNJoEdgwZWgQxGJIbx = inY;
		iTlxJdyaFwEJdfRgiouoDdRUJTlE = inZ;
	}

	public void BlEpJzKrARSmsemSZuRuhnNljiDf(float P_0, float P_1, float P_2)
	{
		BMNgtthGpqCSTnlmLgeEDQRCdItL = P_0;
		pTKbMhixySNJoEdgwZWgQxGJIbx = P_1;
		iTlxJdyaFwEJdfRgiouoDdRUJTlE = P_2;
	}

	public float qXYWdcfqzzCsvjOXwDZmgChGPoz()
	{
		return MathTools.Sqrt(BMNgtthGpqCSTnlmLgeEDQRCdItL * BMNgtthGpqCSTnlmLgeEDQRCdItL + pTKbMhixySNJoEdgwZWgQxGJIbx * pTKbMhixySNJoEdgwZWgQxGJIbx + iTlxJdyaFwEJdfRgiouoDdRUJTlE * iTlxJdyaFwEJdfRgiouoDdRUJTlE);
	}

	public void mmXhrYWooNgHGCiaxKBYItLXDdZj()
	{
		float num = qXYWdcfqzzCsvjOXwDZmgChGPoz();
		if ((double)num != 0.0)
		{
			float num2 = 1f / num;
			BMNgtthGpqCSTnlmLgeEDQRCdItL *= num2;
			pTKbMhixySNJoEdgwZWgQxGJIbx *= num2;
			iTlxJdyaFwEJdfRgiouoDdRUJTlE *= num2;
		}
	}

	public lRSfiBroMYjWUDXxdgmaOiFISuD AufwMkethFIgMhyWtKMadfKxjgO()
	{
		lRSfiBroMYjWUDXxdgmaOiFISuD result = this;
		result.mmXhrYWooNgHGCiaxKBYItLXDdZj();
		return result;
	}

	public static lRSfiBroMYjWUDXxdgmaOiFISuD operator +(lRSfiBroMYjWUDXxdgmaOiFISuD lhs, lRSfiBroMYjWUDXxdgmaOiFISuD rhs)
	{
		lRSfiBroMYjWUDXxdgmaOiFISuD result = default(lRSfiBroMYjWUDXxdgmaOiFISuD);
		result.BlEpJzKrARSmsemSZuRuhnNljiDf(lhs.BMNgtthGpqCSTnlmLgeEDQRCdItL + rhs.BMNgtthGpqCSTnlmLgeEDQRCdItL, lhs.pTKbMhixySNJoEdgwZWgQxGJIbx + rhs.pTKbMhixySNJoEdgwZWgQxGJIbx, lhs.iTlxJdyaFwEJdfRgiouoDdRUJTlE + rhs.iTlxJdyaFwEJdfRgiouoDdRUJTlE);
		return result;
	}

	public static lRSfiBroMYjWUDXxdgmaOiFISuD operator -(lRSfiBroMYjWUDXxdgmaOiFISuD lhs, lRSfiBroMYjWUDXxdgmaOiFISuD rhs)
	{
		lRSfiBroMYjWUDXxdgmaOiFISuD result = default(lRSfiBroMYjWUDXxdgmaOiFISuD);
		result.BlEpJzKrARSmsemSZuRuhnNljiDf(lhs.BMNgtthGpqCSTnlmLgeEDQRCdItL - rhs.BMNgtthGpqCSTnlmLgeEDQRCdItL, lhs.pTKbMhixySNJoEdgwZWgQxGJIbx - rhs.pTKbMhixySNJoEdgwZWgQxGJIbx, lhs.iTlxJdyaFwEJdfRgiouoDdRUJTlE - rhs.iTlxJdyaFwEJdfRgiouoDdRUJTlE);
		return result;
	}

	public static lRSfiBroMYjWUDXxdgmaOiFISuD operator *(lRSfiBroMYjWUDXxdgmaOiFISuD lhs, float rhs)
	{
		lRSfiBroMYjWUDXxdgmaOiFISuD result = default(lRSfiBroMYjWUDXxdgmaOiFISuD);
		result.BlEpJzKrARSmsemSZuRuhnNljiDf(lhs.BMNgtthGpqCSTnlmLgeEDQRCdItL * rhs, lhs.pTKbMhixySNJoEdgwZWgQxGJIbx * rhs, lhs.iTlxJdyaFwEJdfRgiouoDdRUJTlE * rhs);
		return result;
	}

	public static lRSfiBroMYjWUDXxdgmaOiFISuD operator /(lRSfiBroMYjWUDXxdgmaOiFISuD lhs, float rhs)
	{
		lRSfiBroMYjWUDXxdgmaOiFISuD result = default(lRSfiBroMYjWUDXxdgmaOiFISuD);
		result.BlEpJzKrARSmsemSZuRuhnNljiDf(lhs.BMNgtthGpqCSTnlmLgeEDQRCdItL / rhs, lhs.pTKbMhixySNJoEdgwZWgQxGJIbx / rhs, lhs.iTlxJdyaFwEJdfRgiouoDdRUJTlE / rhs);
		return result;
	}

	public static lRSfiBroMYjWUDXxdgmaOiFISuD operator *(lRSfiBroMYjWUDXxdgmaOiFISuD lhs, EsmEDqJyiPuxLXNtMNqwWHhHcii rhs)
	{
		lRSfiBroMYjWUDXxdgmaOiFISuD result = default(lRSfiBroMYjWUDXxdgmaOiFISuD);
		EsmEDqJyiPuxLXNtMNqwWHhHcii esmEDqJyiPuxLXNtMNqwWHhHcii = rhs * new EsmEDqJyiPuxLXNtMNqwWHhHcii(0f, lhs.BMNgtthGpqCSTnlmLgeEDQRCdItL, lhs.pTKbMhixySNJoEdgwZWgQxGJIbx, lhs.iTlxJdyaFwEJdfRgiouoDdRUJTlE) * rhs.duRsjAvQsUkyCatFcPqLfbmhQnj();
		result.BlEpJzKrARSmsemSZuRuhnNljiDf(esmEDqJyiPuxLXNtMNqwWHhHcii.BMNgtthGpqCSTnlmLgeEDQRCdItL, esmEDqJyiPuxLXNtMNqwWHhHcii.pTKbMhixySNJoEdgwZWgQxGJIbx, esmEDqJyiPuxLXNtMNqwWHhHcii.iTlxJdyaFwEJdfRgiouoDdRUJTlE);
		return result;
	}

	public static lRSfiBroMYjWUDXxdgmaOiFISuD operator -(lRSfiBroMYjWUDXxdgmaOiFISuD lhs)
	{
		return new lRSfiBroMYjWUDXxdgmaOiFISuD(0f - lhs.BMNgtthGpqCSTnlmLgeEDQRCdItL, 0f - lhs.pTKbMhixySNJoEdgwZWgQxGJIbx, 0f - lhs.iTlxJdyaFwEJdfRgiouoDdRUJTlE);
	}

	public float uPWoJUkvOQPalVdbxpzoRWeftOn(lRSfiBroMYjWUDXxdgmaOiFISuD P_0)
	{
		return BMNgtthGpqCSTnlmLgeEDQRCdItL * P_0.BMNgtthGpqCSTnlmLgeEDQRCdItL + pTKbMhixySNJoEdgwZWgQxGJIbx * P_0.pTKbMhixySNJoEdgwZWgQxGJIbx + iTlxJdyaFwEJdfRgiouoDdRUJTlE * P_0.iTlxJdyaFwEJdfRgiouoDdRUJTlE;
	}

	public lRSfiBroMYjWUDXxdgmaOiFISuD LtYdaQBKzAHsfuhCsLQkwgAmQTt(lRSfiBroMYjWUDXxdgmaOiFISuD P_0)
	{
		return new lRSfiBroMYjWUDXxdgmaOiFISuD(pTKbMhixySNJoEdgwZWgQxGJIbx * P_0.iTlxJdyaFwEJdfRgiouoDdRUJTlE - iTlxJdyaFwEJdfRgiouoDdRUJTlE * P_0.pTKbMhixySNJoEdgwZWgQxGJIbx, iTlxJdyaFwEJdfRgiouoDdRUJTlE * P_0.BMNgtthGpqCSTnlmLgeEDQRCdItL - BMNgtthGpqCSTnlmLgeEDQRCdItL * P_0.iTlxJdyaFwEJdfRgiouoDdRUJTlE, BMNgtthGpqCSTnlmLgeEDQRCdItL * P_0.pTKbMhixySNJoEdgwZWgQxGJIbx - pTKbMhixySNJoEdgwZWgQxGJIbx * P_0.BMNgtthGpqCSTnlmLgeEDQRCdItL);
	}
}
