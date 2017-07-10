using System.Collections;
using UnityEngine;

public class spawn_zombies : MonoBehaviour
{
    
    public GameObject zombie;// run line                 }
    public GameObject zombie_1;// run from side to side  }----->spawn
    public GameObject human;// run humen                 }
    public volatile bool play_s = true;
    public float time_zombe_0=1;
    public float time_zombe_1=1;
    public float time_survivor=3;
    //	Use this for initialization
    void Start()
    {
      //  yield.WaitForSeconds(3f);
      //  if (play_s==true)
      //  {
       //    StartCoroutine(Spawn());
      //  }
            StartCoroutine(Spawn());
           // yield return new WaitForSeconds(3f);
    }
    
  void Update ()
    {
      
       // if (Start_g.start_game == true)
      //  {
       //     play_s = true;
          //  StartCoroutine(Spawn());
        //}
    }

    IEnumerator Spawn()
    {
        if (play_s == true )
        {
            while (!player.lose)//false to start , true to stop
            {

                Instantiate(zombie, new Vector2(Random.Range(-2.5f, 2.5f), 7.1f), Quaternion.identity); // parametrs spawn x=-2.8 2.8 y=7.1 turn=0
                yield return new WaitForSeconds(time_zombe_0);
                Instantiate(zombie_1, new Vector2(UnityEngine.Random.Range(0, 0), 7.1f), Quaternion.identity); // parametrs spawn x=0 0 y=7.1 turn=0
                yield return new WaitForSeconds(time_zombe_1);
                Instantiate(human, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 7.1f), Quaternion.identity); // parametrs spawn x=-2.8 2.8 y=7.1 turn=0
                yield return new WaitForSeconds(time_survivor);

            }

        }
    }
    
}
