using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool pause = false;
    public GameObject pauseMenu;
    public GameObject optionPauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (optionPauseMenu.activeSelf)
            {
                optionPauseMenu.SetActive(false);
                pauseMenu.SetActive(true);
            }
            else 
                pause = !pause;

        }

        if (pause)
        {
            if (optionPauseMenu.activeSelf)
                pauseMenu.SetActive(false);
            else pauseMenu.SetActive(true);

            Time.timeScale = 0;
        }

        if (pause == false)
        {
            if(optionPauseMenu.activeSelf)
            {
                optionPauseMenu.SetActive(false);
            }
            pauseMenu.SetActive(false);
            
            Time.timeScale = 1;
        }


    }
    public void resume()
    {
        pause = false;
    }

    public void restart()
    {
        pause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void title()
    {
        pause = false;
        SceneManager.LoadScene(0);
    }

    public void quit()
    {
        Application.Quit();
    }
}
