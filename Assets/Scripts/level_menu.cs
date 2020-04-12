//!Copyright(C) 2017 Panchenko Vladislav
//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  10/07/2017 | Panchenko Vladislav | script load scene
//
//******************************************************************************
using UnityEngine;
using UnityEngine.SceneManagement;
//-----------------------------------------------------------------------------
public class level_menu : MonoBehaviour
{
//-----------------------------------------------------------------------------
    // if mouse click on button who have box collider 
    void OnMouseDown()
    {
        
      //  GetComponent<spawn_zombies>().play_s = true;
        SceneManager.LoadScene("main");
    }
//-----------------------------------------------------------------------------
}
