using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform t;
    private Vector3 offset;

    public GameObject player;
    public float turnSpeed = 5.0f;

    void Start()
    {
        t = GetComponent<Transform>();
        offset = t.position - player.transform.position;
    }

    void Update()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed, Vector3.left) * offset;
        t.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);
    }
}
