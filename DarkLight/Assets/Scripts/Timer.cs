using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Timer : MonoBehaviour
{

    public float TimeLeft;
    public bool TimerOn = false;

    public Text Clock;
    
    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()

    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Time is up");
                TimeLeft = 0;
                TimerOn = false;
            }
        
        }
    }
    
    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.Floor(currentTime / 60);
        float seconds = Mathf.Floor(currentTime % 60);
    
        Clock.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
