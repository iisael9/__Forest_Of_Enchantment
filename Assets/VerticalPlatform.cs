using UnityEngine;

public class VerticalMovingPlatform : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float upperLimit = 5f; // Maximum height
    public float lowerLimit = 1f; // Minimum height

    private int direction = 1; // 1 for up, -1 for down
    private float initialY;

    void Start()
    {
        initialY = transform.position.y;
    }

    void Update()
    {
        // Calculate the new position based on the direction and speed
        float newY = transform.position.y + direction * moveSpeed * Time.deltaTime;

        // Check if the platform has reached the upper or lower limit
        if (newY > upperLimit)
        {
            newY = upperLimit;
            direction = -1; // Change direction to go down
        }
        else if (newY < lowerLimit)
        {
            newY = lowerLimit;
            direction = 1; // Change direction to go up
        }

        // Update the platform's position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
