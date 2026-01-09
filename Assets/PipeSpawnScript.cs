using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject pipePrefab;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        //increment timer every frame
        if (timer < spawnRate)
        {
            timer += Time.deltaTime; //increment timer by the time since last frame
        }
        //spawn a new pipe if timer exceeds spawn rate
        else
        {
            spawnPipe(); //spawn a new pipe
            timer = 0; //reset the timer
        }


    }

    void spawnPipe()
    {

        //create a random height offset for the pipe
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
