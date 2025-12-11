using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject startMainMenu;
    public GameObject levelSelect;

    private void Start()
    {
        // PlayerPrefs.DeleteAll();
        // Debug.Log("Data has been reset!");
    }

    public void StartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void GoToLevelSelect()
    {
        startMainMenu.SetActive(false);
        levelSelect.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
