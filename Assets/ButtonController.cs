using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public BossController bossController; // Drag the boss GameObject with the BossController script here
    public GameObject animatedObject; // Drag the GameObject with the Animator component here
    private Animator objectAnimator;
    public GameObject portal;
    public GameObject power;

    void Start()
    {
        // Get the Animator component attached to the animated GameObject
        objectAnimator = animatedObject.GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the player presses the 'Z' key
        if (Input.GetKeyDown(KeyCode.Z))
        {
            animatedObject.SetActive(true);
            objectAnimator.SetTrigger("PressButton");
            // Call the KillBoss method
            bossController.KillBoss();
            power.SetActive(false);

            // Trigger the animation on the separate GameObject
            portal.SetActive(true);
        }
    }
}