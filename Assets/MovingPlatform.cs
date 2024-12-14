using UnityEngine;

public class MovingPlatformController : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float platformMovement = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPosition + new Vector3(platformMovement, 0f, 0f);
    }
}