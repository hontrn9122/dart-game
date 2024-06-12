using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text currentScore;

    // Update is called once per frame
    public void addScore(int score)
    {
        currentScore.text = (Convert.ToInt32(currentScore.text) + score).ToString();
    }

    public void resetScore()
    {
        currentScore.text = "0";
    }
}
