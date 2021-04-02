/****************
 * Name: Turin T
 * Date: 3/29/2021
 * Desc: tracks things like score and such
 * 
 * Note some stuff is grabbed and modified from the platformer game script
 * **************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    //get the highscore
    static private int highestScore = 0;
    //get the players current score
    static public int currentScore = 0;

    public static UnityEvent OnScoreUpdate = new UnityEvent();

    public static int Score
    {
        get => currentScore;
        set
        {
            if (value != currentScore)
            {
                currentScore = value;
                OnScoreUpdate.Invoke();
            }
            //set new high score
            if (currentScore > highestScore)
            {
                highestScore = currentScore;
            }
        }
    }
}
