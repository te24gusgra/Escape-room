using UnityEngine;
using TMPro;
using System;
using UnityEngine.Scripting;

public class TimeManagement : MonoBehaviour
{
    TimeSpan timeSpan = TimeSpan.FromSeconds(90);
    private float timeLimit = 90f;
    private double timeLeft;

    [SerializeField] private TMP_Text timeLimitCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeLimitCounter.text = $"{timeLimit}";
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft = timeLimit -= Time.deltaTime;

        
        timeLimitCounter.text = $"{timeLeft}";
    

    }
}
