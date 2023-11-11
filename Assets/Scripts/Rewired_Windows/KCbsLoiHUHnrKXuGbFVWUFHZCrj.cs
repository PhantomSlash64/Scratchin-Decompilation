using System;

[AttributeUsage(AttributeTargets.Interface)]
internal class KCbsLoiHUHnrKXuGbFVWUFHZCrj : Attribute
{
	private Type XbtRhDcBfTdsjgFjQSStpXcQRAU;

	public Type HmQyuofUsvomGjtCuiqveOpNWlh => XbtRhDcBfTdsjgFjQSStpXcQRAU;

	public KCbsLoiHUHnrKXuGbFVWUFHZCrj(Type typeOfTheAssociatedShadow)
	{
		XbtRhDcBfTdsjgFjQSStpXcQRAU = typeOfTheAssociatedShadow;
	}

	public static KCbsLoiHUHnrKXuGbFVWUFHZCrj NuvzugUZDfrUIDfyWDWrzXgIdAZ(Type P_0)
	{
		object[] customAttributes = P_0.GetCustomAttributes(typeof(KCbsLoiHUHnrKXuGbFVWUFHZCrj), inherit: false);
		if (customAttributes.Length == 0)
		{
			return null;
		}
		return (KCbsLoiHUHnrKXuGbFVWUFHZCrj)customAttributes[0];
	}
}
