using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    //Loads Game
    public void LoadLevel1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Forest Level");
    }
    public void LoadLevel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Snowy Level");
    }
    public void LoadLevel3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Fire Level");
    }
    //Quits Game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Quit the game");
    }


}
