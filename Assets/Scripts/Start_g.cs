using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_g : MonoBehaviour {

    public GameObject start;
    public GameObject Game_menu;
    public volatile static bool start_game = false;
    
    // Use this for initialization

    void OnMouseDown()
    {
        
        start.SetActive(false);
        Game_menu.SetActive(true);
        start_game = true;
       
       // SceneManager.LoadScene("main");
    }
}
