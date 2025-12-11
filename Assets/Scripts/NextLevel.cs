using System;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public string nextLevelName;
    public int nextlevelvalue;

    public void LoadNextLevel()
    {
        PlayerPrefs.SetInt("LevelReached", nextlevelvalue);
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevelName);
        Time.timeScale = 1;
    }
}
