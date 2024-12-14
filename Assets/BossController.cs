using UnityEngine;

public class BossController : MonoBehaviour
{
    public void KillBoss()
    {
        // Implement logic to make the boss disappear
        // For example, deactivate the boss GameObject
        gameObject.SetActive(false);
    }
}