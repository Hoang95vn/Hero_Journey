using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public int points;
    public int highscore;
    public Text pointText;
    public Text highScoreText;
    public Text inputText;

    private void Start()
    {
        highScoreText.text = ("HighScore: " + PlayerPrefs.GetInt("highscore"));
        highscore = PlayerPrefs.GetInt("highscore", 0);
        if (PlayerPrefs.HasKey("points"))
        {
            Scene activeScreen = SceneManager.GetActiveScene();
            if (activeScreen.buildIndex == 1)
            {
                PlayerPrefs.DeleteKey("points");
                points = 0;
            }
            else
            {
                points = PlayerPrefs.GetInt("points");
            }
        }
    }

    private void Update()
    {
        pointText.text = ("Points: " + points);
    }

}

