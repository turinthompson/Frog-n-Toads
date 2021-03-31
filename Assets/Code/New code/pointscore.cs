/**************
 * by Ryan Scheppler
 * date: 1/7/20
 * desc add this to a object with collision, the player should be able to collide with this to get points
 * 
 * this is from the platformer game there are minor changes to make it work better
 * ************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class pointscore : MonoBehaviour
{
    public int points = 10;
    private AudioSource myAud;

    public UnityEvent OnDestory;

    private void Start()
    {
        if (OnDestory == null)
        {
            OnDestory = new UnityEvent();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") != false)
        {
            GameManager.Score += points;
            OnDestory.Invoke();
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") != false)
        {
            GameManager.Score += points;
            OnDestory.Invoke();
            Destroy(gameObject);
        }
    }

}
