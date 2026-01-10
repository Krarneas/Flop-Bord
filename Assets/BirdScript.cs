using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //makes the script aware of the Rigidbody2D component attached to the bird game object
    public Rigidbody2D rb;
    public LogicScript logic;
    public float flapStrength;
    public bool birdIsAlive = true;

    void Start()
    {
        //find the logic script in the scene
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        //when space is pressed do:
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) //deprecated
        {
            //sets the vertical velocity of the bird to 10 units per second upwards
            rb.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //when the bird collides with anything, trigger game over in the logic script
        logic.gameOver();

        //stop controls
        birdIsAlive = false;
    }
}


