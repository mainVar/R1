using UnityEngine;

public class move : MonoBehaviour
{
    public Transform player;
    [SerializeField]
  //  private float speed=2f ;
 

    // Update is called once per frame
    private void OnMouseDrag()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // get Global coordinates player
        // set game plane 
        //if (mousePos.x > 2.8f) ;

        //    mousePos.x = 2.8f;
        //else
        //    mousePos;
        mousePos.x = mousePos.x > 2.8f ? 2.8f : mousePos.x;
        mousePos.x = mousePos.x < -2.8f ? -2.8f : mousePos.x;
        mousePos.y = mousePos.y > 4.8f ? 4.8f : mousePos.y;
        mousePos.y = mousePos.y < -4.9f ? -4.9f : mousePos.y;
        //end seting game plane
        //player.position = Vector2.MoveTowards(player.position,
        //    new Vector2(mousePos.x, mousePos.y),
         //   speed * Time.deltaTime);
        player.position = new Vector2(mousePos.x, mousePos.y);


    }
    void Update()
        // if player using onli tach 
    //  void OnMauseDrag()
    {
        //global point player (controller)
     //   Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // set game plane 
        //if (mousePos.x > 2.8f) ;

        //    mousePos.x = 2.8f;
        //else
        //    mousePos;
     //   mousePos.x = mousePos.x > 2.8f ? 2.8f : mousePos.x;
    //    mousePos.x = mousePos.x < -2.8f ? -2.8f : mousePos.x;
     //   mousePos.y = mousePos.y > 4.8f ? 4.8f : mousePos.y;
     //   mousePos.y = mousePos.y < -4.9f ? -4.9f : mousePos.y;

     //   player.position = Vector2.MoveTowards(player.position,
     //       new Vector2(mousePos.x, mousePos.y),
     //       speed * Time.deltaTime );
    } 
    
}
