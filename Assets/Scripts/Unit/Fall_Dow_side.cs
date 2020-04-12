using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fall_Dow_side : MonoBehaviour
{
    private float fall_speed = 3f;
    private float side = 0f;
    //fall_speed= UnityEngine.Random.Range(2f, 2.5f)
    //public  int stars = 0;

    void Start()
    {
        StartCoroutine(Side());
    }
    IEnumerator Side()
    {
        while (true)//false to start , true to stop
        {
            // parametrs spawn x=-2.8 2.8 y=7.1 turn=0

            //  Instantiate(zombie_1, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 7.1f), Quaternion.identity); // parametrs spawn x=-2.8 2.8 y=7.1 turn=0
            // yield return new WaitForSeconds(1f);
            side = Random.Range(0f, 1f);
            yield return new WaitForSeconds(1.5f);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.1f)
        {
            Destroy(gameObject);
        }
        // for(side=1; iter<=10;iter++)
        // {
        // side= Random.Range(-2.7f, 2.7f);

        //   side = side + 0.1f;
        // }
        if (side >= 0.5f)
        {
            transform.position -= new Vector3(-0.5f * Time.deltaTime, fall_speed * Time.deltaTime, 0);
        }
        if (side <= 0.5)
        {
            transform.position -= new Vector3(0.5f * Time.deltaTime, fall_speed * Time.deltaTime, 0);
        }
        //side =side*Random.Range(-3f,3f);
        //transform.position -= new Vector3 (-1*Time.deltaTime , fall_speed * Time.deltaTime, 0);
    }
}

