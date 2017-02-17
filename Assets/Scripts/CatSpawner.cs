using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour {
    //Spawns cats
    //Place on the GameManager

    //Processing
    float lastSpawnTime = 0f;//the time the last cat spawned
    float spawnDelay = 0.25f;//the amount of delay between cat spawns

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        spawnCats();
	}

    /// <summary>
    /// Logic for deciding which cats to spawn where and when
    /// </summary>
    void spawnCats()
    {
        if (Time.time > lastSpawnTime)
        {
            lastSpawnTime = Time.time + spawnDelay;
            int laneId = Random.Range(1, GameManager.LANE_AMOUNT);
            spawnCat(laneId);
        }
    }

    /// <summary>
    /// Spawns a cat in the given lane
    /// </summary>
    /// <param name="laneId"></param>
    public void spawnCat(int laneId)
    {

    }
}
