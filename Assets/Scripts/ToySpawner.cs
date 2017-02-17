using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToySpawner : MonoBehaviour {
    //Spawns a toy that is launched from a lane
    //Place this script on the GameManager object

    Vector2 launchVector = new Vector2(1000, 0);//assuming toys don't fall

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// Spawns a toy in the given lane
    /// </summary>
    /// <param name="laneId"></param>
    public void spawnToy(int laneId)
    {

    }
}
