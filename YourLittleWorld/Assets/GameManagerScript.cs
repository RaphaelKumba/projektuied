using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverUi;

    public void restartGame()
    {
        Destroy (GameObject.FindWithTag("Ducky"));
        gameOverUi.SetActive(false);
    }

    public void gameOver()
    {
        gameOverUi.SetActive(true);
    }
}
