using System.Collections;
using UnityEngine;

public class Fall_Down : MonoBehaviour 
{
	
    [SerializeField]
    private float fall_speed = 3f;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        if (transform.position.y < -5.1f)
        {
            Destroy(gameObject);
        }
        transform.position -= new Vector3(0, fall_speed * Time.deltaTime, 0);
    }

}
