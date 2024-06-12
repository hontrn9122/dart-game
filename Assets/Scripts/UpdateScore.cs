using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class UpdateScore : MonoBehaviour
{
    public int score;
    private Score currentScore;

    // Start is called before the first frame update
    void Awake()
    {
        currentScore = GameObject.FindWithTag("Score").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider dart)
    {
        //if (dart.CompareTag("dart"))
        //{
            currentScore.addScore(score);
        //}
    }
}
