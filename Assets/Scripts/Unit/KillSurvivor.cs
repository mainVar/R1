//!Copyright(C) 2017 Panchenko Vladislav
//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  10/07/2017 | Panchenko Vladislav | kill human
//
//******************************************************************************
using UnityEngine;

public class KillSurvivor : MonoBehaviour
{
//-----------------------------------------------------------------------------
    // using triger to cheek object type
    void OnTriggerEnter2D(Collider2D teg)
    {
        // if object heve teg "Aim"
        if (teg.gameObject.tag == "Aim")
        {
            Destroy(gameObject);// destroy gameobject who have this script
        }
    }
//-----------------------------------------------------------------------------
}
