using UnityEngine;
using TMPro;
using System;
using UnityEngine.Scripting;
using UnityEditor.Experimental.GraphView;
using System.Threading;

public class TimeManagement : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    [SerializeField] WinManagement winManagement;
    [SerializeField] GameObject door;

    private void Start()
    {
        winManagement = door.GetComponent<WinManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingTime - Time.deltaTime >= 0)
        {
            if (!winManagement.hasWon)
            {
                remainingTime -= Time.deltaTime;
                int minutes = Mathf.FloorToInt(remainingTime / 60);
                int seconds = Mathf.FloorToInt(remainingTime % 60);
                timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
        }
        else if (remainingTime - Time.deltaTime <= 0)
        {
            Lose();
        }
    }

    void Lose()
    {
        timerText.text = "You Lose";
    }
}
