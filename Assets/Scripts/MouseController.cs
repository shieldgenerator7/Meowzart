using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour {
    //This controls things for the mouse, including fire cooldowns

    public const float FIRE_DELAY = 0.5f;//the delay between firing (seconds)

    //Info
    int laneId;//the id of the lane this mouse is in

    //Processing
    float earliestFireTime = 0;//the earliest time the shot can be fired    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void fireToy()
    {
        if (Time.time > earliestFireTime)
        {
            earliestFireTime = Time.time + FIRE_DELAY;
            //ToySpawner.spawnToy(laneId);//fire toy
        }
    }
}
