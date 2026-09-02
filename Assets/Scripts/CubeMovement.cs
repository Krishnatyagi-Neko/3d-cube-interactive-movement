using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class CubeMovement : MonoBehaviour
{
    InputAction jumpAction;
    PlayerInput playerInput;
    InputAction moveAction;
    Rigidbody rb;

    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpForce = 5f;


    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
        jumpAction = playerInput.actions.FindAction("Jump");
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
        JumpPlayer();
    }

    void MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x , 0 , direction.y)* Time.deltaTime * moveSpeed;
    }

    void JumpPlayer()
{
    if (jumpAction.WasPressedThisFrame())
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z); // reset vertical velocity first
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}

}
