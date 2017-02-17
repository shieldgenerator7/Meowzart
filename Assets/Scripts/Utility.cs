using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utility  {

    /// <summary>
    /// Converts the number from the range (curLow, curHigh) to the range (newLow, newHigh), inclusive.
    /// </summary>
    /// <param name="number">A number between (curLow, curHigh), inclusive</param>
    /// <param name="curLow">The low end of the current range</param>
    /// <param name="curHigh">The high end of the current range</param>
    /// <param name="newLow">The low end of the new range</param>
    /// <param name="newHigh">The high end of the new range</param>
    /// <returns>A number between (newLow, newHigh), inclusive</returns>
    public static float convertToRange(float number, float curLow, float curHigh, float newLow, float newHigh)
    {
        //Input checking
        if (number > curHigh || number < curLow)
        {
            throw new System.ArgumentException("number is " + number + " but it should be between (" + curLow + ", " + curHigh + ")");
        }
        if (curLow > curHigh)
        {
            throw new System.ArgumentException("curLow ("+ curLow + ") is higher than curHigh ("+ curHigh + ")!");
        }
        if (newLow > newHigh)
        {
            throw new System.ArgumentException("newLow (" + newLow + ") is higher than newHigh (" + newHigh + ")!");
        }
        //Conversion
        return (((number - curLow) * (newHigh - newLow) / (curHigh - curLow)) + newLow);
    }
}
