using UnityEngine;

public class Ain_on_human : MonoBehaviour
{
    public GameObject restart;
    public GameObject spawn;
    private void Awake()
    {
        
    }
   
    void OnTriggerEnter2D(Collider2D trig)
    {
        // Update is called once per frame
        if (trig.gameObject.tag == "human")
        {
           // stop.enabled = false;
            spawn.GetComponent<spawn_zombies>().enabled = false;
            player.lose = true;
            restart.SetActive(true);
        }

      
    }
}