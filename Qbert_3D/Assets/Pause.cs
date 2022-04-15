using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
        public static bool GamePause = false;
    public GameObject pausemenu;
    public GameObject losing;
    public GameObject winning;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("p"))
        {
            if(GamePause)
            {
                Resume();
            }
            else
            {
                Pauses();
            }
        }
        
    }
    public void Resume()
    {
        
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }
    void Pauses()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        winning.SetActive(false);
        losing.SetActive(false);
        GameSys.lives = 2;
        SceneManager.LoadScene(0);
        
    }
    public void Restart()
    {
        losing.SetActive(false);
        Time.timeScale = 1f;
        GameSys.lives = 2;
    }
}
