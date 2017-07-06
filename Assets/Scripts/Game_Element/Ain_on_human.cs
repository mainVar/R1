using UnityEngine;

public class Ain_on_human : MonoBehaviour
{
    public GameObject restart;
    private void Awake()
    {
        
    }
    void OnTriggerEnter2D(Collider2D trig)
    {
        // Update is called once per frame
        if (trig.gameObject.tag == "human")
        {

            player.lose = true;
            restart.SetActive(true);
        }

      
    }
}