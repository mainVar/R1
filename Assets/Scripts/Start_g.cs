//!Copyright(C) 2017 Panchenko Vladislav
//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  10/07/2017 | Panchenko Vladislav | script start game 
//
//******************************************************************************
using UnityEngine;
using UnityEngine.SceneManagement;
//-----------------------------------------------------------------------------
public class Start_g : MonoBehaviour {
    //-----------------------------------------------------------------------------
    public GameObject start;// Component that is needed for activation
    public GameObject Game_menu; 
    public volatile static bool start_game = false;

    // Use this for initialization
    //-----------------------------------------------------------------------------
    void OnMouseDown()
    {
        start.SetActive(false);  // set active component
        Game_menu.SetActive(true);
        start_game = true;
       
       // SceneManager.LoadScene("main");
    }
    //-----------------------------------------------------------------------------
}
