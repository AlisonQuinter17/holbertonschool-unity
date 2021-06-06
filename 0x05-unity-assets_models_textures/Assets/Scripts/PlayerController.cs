using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 moveDirection;
    private Transform falling;
    public CharacterController player;
    public float speed = .1f;
    private float jump_force = 6.0f;
    public float gravity = 6.0f;
    

    private void Start()
    {
        player = GetComponent<CharacterController>();
        falling = GetComponent<Transform>();
    }
    
    private void Update()
    {
        float x_direction = Input.GetAxis("Horizontal");
        float z_direction = Input.GetAxis("Vertical");

        if (player.isGrounded)
        {
            moveDirection = new Vector3(x_direction, 0.0f, z_direction);
            moveDirection =  (transform.TransformDirection(moveDirection) * speed);

            if (Input.GetKeyDown(KeyCode.Space))
                moveDirection.y = jump_force;
        }
        else
        {
            moveDirection = new Vector3(x_direction, moveDirection.y, z_direction);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection.x *= speed; moveDirection.z *= speed;
        }
        moveDirection.y -= (gravity * Time.deltaTime);
        player.Move(moveDirection * Time.deltaTime);

        if (falling.position.y < -25f)
            falling.position = new Vector3(0, 40, 0);
    }    
}
