using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //makes the script aware of the Rigidbody2D component attached to the bird game object
    public Rigidbody2D myRigidbody; 

    void Start()
    {
        
    }

    void Update()
    {
        //when space is pressed do:
        if (Input.GetKeyDown(KeyCode.Space) == true) //deprecated
        {
            //sets the vertical velocity of the bird to 10 units per second upwards
            myRigidbody.linearVelocity = Vector2.up * 10f;
        }


    }
}
