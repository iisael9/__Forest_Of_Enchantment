using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    public float floatHeight = 1.0f;  // Height of the floating object above the ground
    public float bounceSpeed = 1.0f;   // Speed of the floating/bouncing motion
    public Vector3 rotationSpeed = new Vector3(0.0f, 0.0f, 30.0f);  // Rotation speed in degrees per second

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // Floating motion
        float newY = initialPosition.y + Mathf.Sin(Time.time * bounceSpeed) * floatHeight;
        transform.position = new Vector3(initialPosition.x, newY, initialPosition.z);

        // Rotation motion
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}