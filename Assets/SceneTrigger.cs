using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public string nextSceneName = "NextScene";

    private void OnMouseDown()
    {
        // Load the next scene
        SceneManager.LoadScene(nextSceneName);
    }
}