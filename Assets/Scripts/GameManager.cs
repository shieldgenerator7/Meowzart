using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public const int LANE_AMOUNT = 7;
    public const float LANE_Y_TOP = 2.78f;
    public const float LANE_Y_BOTTOM = -4.84f;

    public enum GameState
    {
        OutOfGame,//other scenes beside the PlayScene and EndScene
        StartGame,//game is starting
        GameInProgress,//game is in progress
        GameEnding,//animations play after the game ends and before the results screen shows
        GameEnded
    }
    GameState gameState = GameState.OutOfGame;

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    /// <summary>
    /// Returns the laneId of the given y coordinate
    /// </summary>
    /// <param name="posY">The y coordinate to find the laneId of</param>
    /// <returns>The laneId if the posY is valid</returns>
    public int laneId(float posY)
    {
        if (posY > LANE_Y_TOP || posY < LANE_Y_BOTTOM)
        {
            throw new System.ArgumentException("posY is " + posY + " but it should be between ("+LANE_Y_BOTTOM+", "+LANE_Y_TOP+")");
        }
        return Mathf.FloorToInt(Utility.convertToRange(posY, LANE_Y_BOTTOM, LANE_Y_TOP, 1, LANE_AMOUNT+1));
    }
    /// <summary>
    /// Returns the y coordinate of the center of the lane with the given laneId
    /// </summary>
    /// <param name="posY">The y coordinate to find the laneId of</param>
    /// <returns>The laneId if the posY is valid</returns>
    public float laneCenter(int laneId)
    {
        float halfLaneWidth = (LANE_Y_TOP - LANE_Y_BOTTOM) / LANE_AMOUNT / 2;
        return Utility.convertToRange(laneId, 1, LANE_AMOUNT+1, LANE_Y_BOTTOM, LANE_Y_TOP) + halfLaneWidth;
    }
}
