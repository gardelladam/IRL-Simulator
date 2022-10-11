using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alarm : MonoBehaviour
{
  public bool alarm;
  public Text displayText;

    void Start()
    {
         alarm = false;
    }

    void Update()
    {
         if(alarm == false)
         {
            displayText.text = "";
         }
    }

    public void setAlarm()
    {
        alarm = true;
        displayText.text = "ALARM IS ON";

        Debug.Log(alarm);
    }

  
    
}
