//!Copyright(C) 2017 Panchenko Vladislav
//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  10/07/2017 | Panchenko Vladislav | script restart
//
//******************************************************************************
using UnityEngine;
using UnityEngine.SceneManagement;
//-----------------------------------------------------------------------------
public class Restart : MonoBehaviour
{
//-----------------------------------------------------------------------------
    void OnMouseDown() // if clik on button 
    {
        SceneManager.LoadScene("main");   // load scene main 
    }
//-----------------------------------------------------------------------------	
}
