using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public LogicScript logic;

    void Start()
    {
        //find the logic script in the scene
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the object that entered the trigger is the bird
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
