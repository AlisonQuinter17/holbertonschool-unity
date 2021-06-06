using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float directions_speed = 1.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
        yaw += directions_speed * Input.GetAxis("Mouse X");
        pitch += directions_speed * Input.GetAxis("Mouse Y");

        // Rotate the camera on their own by moving the mouse.
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        
        // The camera to follow the player.
        transform.position = target.position + offset;
    }
}
