/*************
 *by Ryan Scheppler
 * date: 1 / 7 / 20
 * desc: add this to a textmeshpro object to control the text and display
 * 
 * note this is from the platfromer game
 * note change enough
 *************/

///
//note score function doesn't work yet
///

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public static TextMeshProUGUI myTMP;
    // Start is called before the first frame update
    void Start()
    {
        myTMP = GetComponent<TextMeshProUGUI>();
        UpdateScore();
        GameManager.OnScoreUpdate.AddListener(UpdateScore);
    }
    public static void UpdateScore()
    {
        myTMP.text = "Score: " + GameManager.currentScore.ToString();
    }
    private void OnDestroy()
    {
        GameManager.OnScoreUpdate.RemoveListener(UpdateScore);
    }

}
