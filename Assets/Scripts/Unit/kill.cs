using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D teg)
    {

        if (teg.gameObject.tag == "Aim")
        {
            Destroy(gameObject);
        }

        if (teg.gameObject.tag == "bomb")
        {
            Destroy(gameObject,1f);
        }

    }
	
	// Update is called once per frame
	
			//Destroy (gameObject);
		
}
