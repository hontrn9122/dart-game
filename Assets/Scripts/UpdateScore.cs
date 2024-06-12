using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class UpdateScore : MonoBehaviour
{

    private TMP_Text currentScore = GameObject.FindGameObjectWithTag("ScoreValue").GetComponent<TextMeshProUGUI>();
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider dart)
    {
        if (dart.CompareTag("dart"))
        {
            currentScore.text = (Convert.ToInt32(currentScore.text) + score).ToString();
        }
        
    }
}
