using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;

    private Rigidbody2D rb;
    private bool isGrounded;

    public Transform groundCheck;
    public float checkRadius = 0.2f;
    public LayerMask groundLayer;

    private float moveInput;
    private bool facingRight = true;
    public float rotationSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        
        // Movimento horizontal
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        // Verifica se está no chão
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // Girar suavemente
        RotateCharacter(moveInput);
    }

    void RotateCharacter(float direction)
    {
        if (direction == 0) return;

        // Define direção alvo de rotação
        float targetYRotation = direction > 0 ? 0f : 180f;

        Quaternion targetRotation = Quaternion.Euler(0, targetYRotation, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }
}