using UnityEngine;

public class player : MonoBehaviour 
{    
	public static bool kill = false;
    public volatile static bool lose = false;
    private float num;               // counter zombies
    public GameObject restart;
    private void Awake()
    {
        lose = false;
    }

    void OnTriggerEnter2D (Collider2D other)
	{

        if (other.gameObject.tag == "zombe_0")
        {
            
            num++;
            if (num >= 3)
            {
                 lose = true;
            }
        }
        //  Ain_on_human end;
        //bool check;
       // Ain_on_human end;
        //end = new Ain_on_human();

      //  if (end.lose_h==1)
      //  {
        //    lose = true;
       // }
        
      // if (Ain_on_human.lose_h==1)// problem 
      //   {
        //       lose = true;
       //  }
        if (lose==true)
        {
            restart.SetActive(true);
        }

	}
		
}
