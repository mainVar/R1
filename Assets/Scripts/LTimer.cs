//!Copyright(C) 2017 Panchenko Vladislav
//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  10/07/2017 | Panchenko Vladislav | script timer
//
//******************************************************************************
using UnityEngine;
using UnityEngine.UI;
//-----------------------------------------------------------------------------
public class LTimer : MonoBehaviour
{
    //-----------------------------------------------------------------------------
    public float timer;
    public Text timerText;
    
 //   spawn_zombies stop;   // stop spawn zombi
    public GameObject spawn; // obj spawn_zombies 
   //-----------------------------------------------------------------------------
    
    // Update is called once per frame
    void Update() //using for timer (time (onli) - TIME)
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = timer.ToString("Time :") + timer.ToString( "f1");

        }
        if (timer <= 0)
        {
            //    stop.play_s = false;  // stop spawn zombi
          player.lose = true; // Stops the loop that works on the state of the variable (lose)

        }
    }
   //-----------------------------------------------------------------------------
}

