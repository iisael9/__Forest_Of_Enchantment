using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Pause_Menu : MonoBehaviour
{
    public GameObject Pause;

    public static bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        Pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame();
            }
                
            else
            {
                PauseGame();
            }
                
        }
    }

    void PauseGame()
    {
        Pause.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        Pause.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main_Menu");
    }

}
