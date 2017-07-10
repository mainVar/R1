using UnityEngine;

public class KillSurvivor : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D teg)
    {

        if (teg.gameObject.tag == "Aim")
        {
            Destroy(gameObject);
        }
    }
}
