//!Copyright(C) 2017 Panchenko Vladislav
//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  10/07/2017 | Panchenko Vladislav | script Aim on Bomb
//
//******************************************************************************
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
//------------------------------------------------------------------------------

public class Aim_onBomb : MonoBehaviour
{
    public Transform bomb;
    private bool triggerChek = false;
    public GameObject bomba;
    public float timer=0;
    //------------------------------------------------------------------------------

    private void Start()
    {
      //  anim = GetComponent<Animation>();
    }
    //------------------------------------------------------------------------------

    private void Update() //using for timer (time (onli) - TIME)
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
        }
    }
    //------------------------------------------------------------------------------

    //  public GameObject bombsAnim;
    void OnTriggerEnter2D(Collider2D trig)
    {

        if (trig.gameObject.tag == "Aim")
        {
            triggerChek = true;
            timer = 0.5f; // set time to set new position 

        }

    }
    //------------------------------------------------------------------------------
    //  Function: 
    //           OnMouseDrag() 
    //! set position gameObject bomb & after chek posishen and  explosion
    void OnMouseDrag()
    {
        if (triggerChek == true)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // get Global coordinates player
            bomb.position = new Vector2(mousePos.x, mousePos.y);

            if (timer <= 0f)
            {
                bombD();
            }

        }
    }
    //------------------------------------------------------------------------------

    //  Function:
    //            bombD() 
    //! \ active animator & destructor
    void bombD()
    {
        //gameObject.GetComponent<Animator>().SetBool("BombEXP", true);
        
        gameObject.GetComponent<Animator>().SetTrigger("Eplou");
        //anim.SetBool(string BombEXP, bool false);
        // bomba.SetActive(false);
        Destroy(bomba,1f);
    }

    //------------------------------------------------------------------------------
}
