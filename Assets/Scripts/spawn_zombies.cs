using System.Collections;
using UnityEngine;

public class spawn_zombies : MonoBehaviour
{
    
    public GameObject zombie;// run line                 }
    public GameObject zombie_1;// run from side to side  }----->spawn
    public GameObject human;// run humen                 }
    
    //	Use this for initialization

    void Start()
    {
      //  yield.WaitForSeconds(3f);
        //if (Start_g.start_game==true)
      //  {
            StartCoroutine(Spawn());
       // }

	}
    


    IEnumerator Spawn()
    {

            //  if (start_game == true)
            //{
            while (!player.lose)//false to start , true to stop
            {

                Instantiate(zombie, new Vector2(Random.Range(-2.5f, 2.5f), 7.1f), Quaternion.identity); // parametrs spawn x=-2.8 2.8 y=7.1 turn=0
                yield return new WaitForSeconds(1f);
                Instantiate(zombie_1, new Vector2(UnityEngine.Random.Range(0, 0), 7.1f), Quaternion.identity); // parametrs spawn x=0 0 y=7.1 turn=0
                yield return new WaitForSeconds(1f);
                Instantiate(human, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 7.1f), Quaternion.identity); // parametrs spawn x=-2.8 2.8 y=7.1 turn=0
                yield return new WaitForSeconds(3f);

            }

            // }
    }
    
}
