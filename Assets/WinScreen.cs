using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    // Set the duration the win screen should be displayed
    public float displayDuration = 5f;

    void Start()
    {
        // Invoke the method to go back to the main menu after the display duration
        Invoke("LoadMainMenu", displayDuration);
    }

    void LoadMainMenu()
    {
        // Load the main menu scene
        SceneManager.LoadScene("Main_Menu"); // Replace "MainMenu" with the name of your main menu scene
    }
}