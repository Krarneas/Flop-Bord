using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;

    void Start()
    {
        
    }
    void Update()
    {
        //moves the pipe to the left every frame
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
