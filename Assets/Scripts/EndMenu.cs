using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndMenu : MonoBehaviour
{
    public TMP_Text _highScoreText;

    void Start()
    {
        _highScoreText.text = PlayerPrefs.GetInt("_highScore").ToString();
    }

    public void Restart()
    {
        SceneManager.LoadSceneAsync(1);
        Time.timeScale = 1;
    }

    public void MainM()
    {
        SceneManager.LoadSceneAsync(0);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
