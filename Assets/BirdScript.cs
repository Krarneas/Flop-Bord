using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //makes the script aware of the Rigidbody2D component attached to the bird game object
    public Rigidbody2D rb;

    public float flapStrength;

    void Start()
    {

    }

    void Update()
    {
        //when space is pressed do:
        if (Input.GetKeyDown(KeyCode.Space) == true) //deprecated
        {
            //sets the vertical velocity of the bird to 10 units per second upwards
            rb.linearVelocity = Vector2.up * flapStrength;
        }
    }

}
