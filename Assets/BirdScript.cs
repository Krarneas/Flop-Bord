using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //makes the script aware of the Rigidbody2D component attached to the bird game object
    public Rigidbody2D rb;
    public LogicScript logic;
    public float flapStrength;
    public float outOfBoundsY;
    public bool birdIsAlive = true;

    //SFX
    public AudioSource flapSFX;
    public AudioSource dieSFX;

    void Start()
    {
        //find the logic script in the scene
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        //when space is pressed do:
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) //deprecated but much easier to use
        {
            //sets the vertical velocity of the bird to 10 units per second upwards
            rb.linearVelocity = Vector2.up * flapStrength;
            flapSFX.Play();
        }

        //bird goes offscreen, trigger game over
        if (transform.position.y > outOfBoundsY || transform.position.y < -(outOfBoundsY)) //position y limits
        {
            logic.gameOver();
            birdIsAlive = false;
            dieSFX.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //when the bird collides with anything, trigger game over in the logic script
        logic.gameOver();
        //stop controls
        birdIsAlive = false;
        dieSFX.Play();
    }
}


