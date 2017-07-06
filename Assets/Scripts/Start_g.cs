using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_g : MonoBehaviour {

    public GameObject start;
    public volatile static bool start_game = false;
    
    // Use this for initialization

    void OnMouseDown()
    {
        
        start.SetActive(false);
        start_game = true;
       
       // SceneManager.LoadScene("main");
    }
}
