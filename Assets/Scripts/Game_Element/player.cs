//!Copyright(C) 2017 Panchenko Vladislav
//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  10/07/2017 | Panchenko Vladislav | script player
//
//******************************************************************************
using UnityEngine;
//-----------------------------------------------------------------------------
public class player : MonoBehaviour 
{
    //-----------------------------------------------------------------------------
    public static bool kill = false;
    public volatile static bool lose = false;
    private int num;               // counter zombies
    public GameObject restart;
    public GameObject zombi_miss1;
    public GameObject zombi_miss2;
    public GameObject zombi_miss3;
   // spawn_zombies chek;
    public GameObject spawn_zombi;
    public GameObject end_level;
    //-----------------------------------------------------------------------------
    private void Awake()
    {
        lose = false; //need if game restart 
    }
    //-----------------------------------------------------------------------------
    private void Start()
    {
     //   chek =spawn_zombi.GetComponent<spawn_zombies>();
    }
    //-----------------------------------------------------------------------------
    void OnTriggerEnter2D (Collider2D other)
	{

        if (other.gameObject.tag == "zombe_0")
        {
            
            num++; // +1 zombi
            if (num >= 3) // end game lose
            {
                lose = true;
                spawn_zombi.GetComponent<spawn_zombies>().enabled = false;
                num = 0;
            }
            switch (num)
            {
                case 1:
                 zombi_miss1.SetActive(false);
                    break;
                case 2:
                 zombi_miss2.SetActive(false);
                    break;
                case 3:
                 zombi_miss3.SetActive(false);
                    break;

            }

        }
        //-----------------------------------------------------------------------------
        //  Ain_on_human end;                             /
        //bool check;                                     /
        // Ain_on_human end;                               /
        //end = new Ain_on_human();

        //  if (end.lose_h==1)
        //  {
        //    lose = true;
        // }

        // if (Ain_on_human.lose_h==1)// problem 
        //   {
        //       lose = true; 
        //  }
        //-----------------------------------------------------------------------------
        if (lose==true)
        {
            //chek.play_s = false;
            spawn_zombi.GetComponent<spawn_zombies>().enabled = false; // call in script spawn_zombies end off him
            end_level.SetActive(true);                                 // button nest level active
            restart.SetActive(true);                                   // button restaret active
        }
        //-----------------------------------------------------------------------------
    }
    //-----------------------------------------------------------------------------
}
