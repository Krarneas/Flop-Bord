using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    //SFX
    public AudioSource dingSFX;
    public AudioSource dieSFX;
    private bool gameOverSFXPlayed = false;

    //logic for adding score
    [ContextMenu("Increase Score")] //comes in handy for testing in the editor
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();   
        dingSFX.Play();
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //reloads the current scene
    }

    public void gameOver()
    {

        if (gameOverSFXPlayed) return; //prevent multiple plays

        gameOverSFXPlayed = true;
        gameOverScreen.SetActive(true);

        dieSFX.Play();
    }
}
