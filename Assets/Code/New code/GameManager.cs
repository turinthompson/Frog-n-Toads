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
    private float highestScore = 0;
    [HideInInspector] static public float currentScore = 0;
    private float oldScore = 0;

    //adjust
    public static UnityEvent OnScoreUpdate = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // FixedUpdate is called once per physic frame
    void FixedUpdate()
    {   
        //currentScore would most likely constanly changed, this is just to it doesn't keep going though
        if (currentScore > oldScore)
        {
            ScoreText.UpdateScore();
        }
        if (currentScore > highestScore)
        {
            highestScore = currentScore;
        }
    }
}
