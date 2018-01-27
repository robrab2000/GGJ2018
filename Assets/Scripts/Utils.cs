using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils {
// Mapping function
    public static float ofMap(float value, float inputMin, float inputMax, float outputMin, float outputMax){

        if (value < inputMin) { return outputMin; }
        if (value > inputMax) { return outputMax; }
 
        float OldRange = (inputMax - inputMin);
        float NewRange = (outputMax - outputMin);
        float NewValue = (((value - inputMin) * NewRange) / OldRange) + outputMin;
    
        return(NewValue);
    }
}
