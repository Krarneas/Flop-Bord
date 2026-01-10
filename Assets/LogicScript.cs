using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    //logic for adding score
    [ContextMenu("Increase Score")] //comes in handy for testing in the editor
    void addScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();    
    }
}
