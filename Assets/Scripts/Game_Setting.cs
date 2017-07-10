using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Setting : MonoBehaviour {
    spawn_zombies time_spawn_zombi_0;
    spawn_zombies time_spawn_zombi_1;
    spawn_zombies time_spawn_survivor;
    spawn_zombies start;
    LTimer time;
    public GameObject spawn;
    public GameObject timer;
    public GameObject offButton;
    public GameObject offReset;
    public float level;

    // Use this for initialization
    void Start ()
    {
        time_spawn_zombi_0 = spawn.GetComponent<spawn_zombies>();
        time_spawn_zombi_1 = spawn.GetComponent<spawn_zombies>();
        time_spawn_survivor = spawn.GetComponent<spawn_zombies>();
        time = timer.GetComponent<LTimer>();
        start = spawn.GetComponent<spawn_zombies>();
        level = level + 1;
	}
    void OnMouseDown()
    {
        //---start game (spawn zombi+ timer)------------------------------
        SceneManager.LoadScene("game");
        player.lose = false;
        start.play_s = true;
        spawn.GetComponent<spawn_zombies>().enabled = false;
        time.timer = 60f;
        //---------------------------------------------------
        offButton.SetActive(false);
        offReset.SetActive(false);
        //---set new seting level----------------------------
        time_spawn_zombi_0.time_zombe_0 -= 0.1f;
        time_spawn_zombi_1.time_zombe_1 -= 0.1f;
        time_spawn_survivor.time_survivor -= 0.2f;
        
    }

}
