
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_menu : MonoBehaviour {

	// Use this for initialization
	
    void OnMouseDown()
    {
        
      //  GetComponent<spawn_zombies>().play_s = true;
        SceneManager.LoadScene("main");
    }
    // Update is called once per frame
 //   void Update () {
		
	//}
}
