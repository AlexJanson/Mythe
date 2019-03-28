using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private Timer timer;

    private void Start()
    {
        timer = GetComponentInChildren<Timer>();
    }

    public int getFinalScore()
    {
        int finalScore = 0;
        finalScore += (int)timer.GetTimeLeft();

        //calculate how accurate the soup color is
        // int soupAccuracy = ????
        // finalScore += soupAccuracy

        return finalScore;
    }
}
