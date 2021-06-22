using UnityEngine;

[CreateAssetMenu]
public class GameConfig : ScriptableObject
{
	private static GameConfig instance;
	public static GameConfig Instance
	{
		get
		{
			if (instance == null)
			{
				instance = Resources.Load<GameConfig>("GameConfig");
			}

			return instance;
		}
	}

	public float multiplier;
}