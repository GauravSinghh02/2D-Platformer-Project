using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void LoadCurrentScene()
    {
        SceneManager.LoadScene("MainScene");

        Time.timeScale = 1;
    }
}
