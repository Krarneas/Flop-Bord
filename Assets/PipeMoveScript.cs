using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadzone = -45; //x position where pipe gets destroyed
    void Start()
    {
        
    }
    void Update()
    {
        //moves the pipe to the left every frame
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        //destroy the pipe if it goes off screen
        if (transform.position.x < deadzone)
        {
            Debug.Log("Pipe Destroyed");
            Destroy(gameObject); //destroy built in function
        }
    }
}
