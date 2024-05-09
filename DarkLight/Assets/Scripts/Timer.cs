using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;

public class Timer : MonoBehaviour
{

    public float TimeLeft;
    public bool TimerOn = false;

    public Text Clock;

    public UnityEvent OnTimerEnd;

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
                UpdateTimerText(TimeLeft);
            }
            else
            {
                if (TimeLeft <= 0)
                {
                    ChangeScene();
                }
            }       
            
        }
    }

  // Going from level 1 to Win Screen
    
    void ChangeScene()
    {
        SceneManager.LoadScene("WinScreen");
    }
    
    void UpdateTimerText(float currentTime)
    {
        currentTime += 1;
        
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        
        Clock.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        
    }
}
