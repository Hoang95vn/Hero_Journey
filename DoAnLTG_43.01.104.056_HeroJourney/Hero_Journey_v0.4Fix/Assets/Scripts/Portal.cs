using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public int levelLoad;
    public GameMaster gm;
    public string text = "Press E to Enter";
    private bool isStay;

    // Start is called before the first frame update
    void Start()
    {
        isStay = false;
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
    }

    void Update()
    {
        if (isStay)
        {
            if (Input.GetKey(KeyCode.E))
            {
                SaveScore();
                SceneManager.LoadScene(levelLoad);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if(SceneManager.GetActiveScene().name == "Scene5")
            {
                gm.inputText.text = ("Thank you for playing this game \n Press E to return to Title");
            }
            else
            {
                gm.inputText.text = (text);
            }
            
           
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            isStay = true;
            /*if (Input.GetKey(KeyCode.E))
            {
                SaveScore();
                SceneManager.LoadScene(levelLoad);
            }*/
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        gm.inputText.text = ("");
        isStay = false;
    }

    void SaveScore()
    {
        PlayerPrefs.SetInt("points", gm.points);
        if (SceneManager.GetActiveScene().name == "Scene5")
        {
            if (PlayerPrefs.GetInt("highscore") < gm.points)
            {
                PlayerPrefs.SetInt("highscore", gm.points);
            }
        }
    }
}
