/****************
 * Name: Turin Thompson
 * Date: 3/29/2021
 * Desc: tracks things like score and such
 * Note some stuff is grabbed and modified from the platformer game script
 * **************/

///
//note score function doesn't work yet
///

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    //private float highestScore = 0;
    static public float currentScore = 0;
    //adjust
    public static UnityEvent OnScoreUpdate = new UnityEvent();

    public static float Score
    {
        get => currentScore;
        set
        {
            if (value != currentScore)
            {
                currentScore = value;
                OnScoreUpdate.Invoke();
            }
        }
    }
}
