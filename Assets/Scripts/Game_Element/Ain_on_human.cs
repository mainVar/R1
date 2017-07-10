//!Copyright(C) 2017 Panchenko Vladislav
//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  10/07/2017 | Panchenko Vladislav | script aim on human
//
//******************************************************************************
using UnityEngine;
//-----------------------------------------------------------------------------
public class Ain_on_human : MonoBehaviour
{
//-----------------------------------------------------------------------------
    public GameObject restart;
    public GameObject spawn;
    //-----------------------------------------------------------------------------

    void OnTriggerEnter2D(Collider2D trig)
    {
        //-----------------------------------------------------------------------------
        // Update is called once per frame
        if (trig.gameObject.tag == "human")
        {
           // stop.enabled = false;
            spawn.GetComponent<spawn_zombies>().enabled = false;
            player.lose = true;
            restart.SetActive(true);
        }
        //-----------------------------------------------------------------------------
    }
//-----------------------------------------------------------------------------
}