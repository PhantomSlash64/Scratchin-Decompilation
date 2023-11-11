namespace UnityEngine.U2D.Animation
{
	internal enum SpriteSkinValidationResult
	{
		SpriteNotFound = 0,
		SpriteHasNoSkinningInformation = 1,
		SpriteHasNoWeights = 2,
		RootTransformNotFound = 3,
		InvalidTransformArray = 4,
		InvalidTransformArrayLength = 5,
		TransformArrayContainsNull = 6,
		RootNotFoundInTransformArray = 7,
		Ready = 8
	}
}
