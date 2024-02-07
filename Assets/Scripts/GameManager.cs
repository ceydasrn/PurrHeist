using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();

        // Eğer daha önce high score anahtarı oluşturulmamışsa sıfırla
        if (!PlayerPrefs.HasKey("_highScoreInitialized"))
        {
            PlayerPrefs.SetInt("_highScore", 0);
            PlayerPrefs.SetInt("_highScoreInitialized", 1); // Anahtarın var olduğunu işaretle
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();

        if(score > PlayerPrefs.GetInt("_highScore")){
            PlayerPrefs.SetInt("_highScore", score);
        }
    }
}
