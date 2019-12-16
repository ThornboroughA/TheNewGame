using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelState : MonoBehaviour
{
	////SCENE STATE SAVING
	public static LevelState Instance;

    public string spawnPositionString;
    public string completedTiles;

	public int coziness;

	// Start is called before the first frame update
	void Awake()
	{
		if (Instance == null)
		{ 
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
		else if (Instance != this)
		{
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
