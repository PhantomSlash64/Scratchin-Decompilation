using System;
using Rewired;

internal sealed class UsMQnVXJOgAELSCkvEBzkFdKjFNq : IControllerTemplateElementSource, IControllerTemplateAxisSource, IControllerTemplateButtonSource
{
	private ControllerTemplateElementType CWgkufixEoUdwdpwyiLRHFzgLqi;

	private bool jxfIpZOZzSjMSRQmjxIQeGHvaJk;

	private IControllerElementTarget HOzVbenRtSDkKAqmPyECWoYOfWfD;

	private IControllerElementTarget GwEgIiweqPZWGfzcPtxxGyrbIFV;

	private IControllerElementTarget DsbKhrpbLbqPZwifJFAFaJtuis;

	ControllerTemplateElementSourceType IControllerTemplateElementSource.iqarjzSaOyGHWzqurcwjfFkbdSg => BbpfTcGSZRHmltstKOfXrucHPJO.rSUkgfnozivmnWHamNHCDcgysjp(CWgkufixEoUdwdpwyiLRHFzgLqi, false);

	bool IControllerTemplateAxisSource.dkbAilJkcnZyUjvZQzGuZhoVhCY => jxfIpZOZzSjMSRQmjxIQeGHvaJk;

	IControllerElementTarget IControllerTemplateAxisSource.sLjBAMHLhbeqUtENdzCPtLJCVOEW => HOzVbenRtSDkKAqmPyECWoYOfWfD;

	IControllerElementTarget IControllerTemplateAxisSource.HQjmIqMBauEzkGEUTiiVyODrKpzH => GwEgIiweqPZWGfzcPtxxGyrbIFV;

	IControllerElementTarget IControllerTemplateAxisSource.vMjgolAdnburNtdpOWTJahKNzQjG => DsbKhrpbLbqPZwifJFAFaJtuis;

	IControllerElementTarget IControllerTemplateButtonSource.ZSpWHRDDWPyWyxpSGYhodLYTei => HOzVbenRtSDkKAqmPyECWoYOfWfD;

	internal UsMQnVXJOgAELSCkvEBzkFdKjFNq(ControllerTemplateElementType elementType, bool splitAxis, IControllerElementTarget target, IControllerElementTarget positiveTarget, IControllerElementTarget negativeTarget)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (negativeTarget == null)
		{
			throw new ArgumentNullException("positiveTarget");
		}
		if (positiveTarget == null)
		{
			throw new ArgumentNullException("negativeTarget");
		}
		CWgkufixEoUdwdpwyiLRHFzgLqi = elementType;
		jxfIpZOZzSjMSRQmjxIQeGHvaJk = splitAxis;
		HOzVbenRtSDkKAqmPyECWoYOfWfD = target;
		GwEgIiweqPZWGfzcPtxxGyrbIFV = positiveTarget;
		DsbKhrpbLbqPZwifJFAFaJtuis = negativeTarget;
	}

	internal static UsMQnVXJOgAELSCkvEBzkFdKjFNq kbUEkrjNKrFkwKWFaqXQToCsrDji(ControllerTemplateElementType P_0)
	{
		return new UsMQnVXJOgAELSCkvEBzkFdKjFNq(P_0, splitAxis: false, bjWEjHBROAVpeyUanBwIblyUmUNK.kbUEkrjNKrFkwKWFaqXQToCsrDji(), bjWEjHBROAVpeyUanBwIblyUmUNK.kbUEkrjNKrFkwKWFaqXQToCsrDji(), bjWEjHBROAVpeyUanBwIblyUmUNK.kbUEkrjNKrFkwKWFaqXQToCsrDji());
	}
}
