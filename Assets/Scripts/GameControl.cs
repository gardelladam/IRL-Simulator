using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
         {
             Application.LoadLevel(0);
         }
         if (Input.GetKeyDown("space"))
         {
            if(Time.timeScale == 0){
                Time.timeScale = 1;
            }
            else if(Time.timeScale > 0){
                 Time.timeScale = 0;
            }
             
         }
         if (Input.GetKeyDown(KeyCode.M))
         {
            Time.timeScale = Mathf.Clamp(Time.timeScale + 2, 0,10);
             
         }
         if (Input.GetKeyDown(KeyCode.N))
         {
            Time.timeScale =  Mathf.Clamp(Time.timeScale - 2, 0,10);   
         }
         if (Input.GetKeyDown(KeyCode.B))
         {
            Time.timeScale = 1;   
         }
    }
}
