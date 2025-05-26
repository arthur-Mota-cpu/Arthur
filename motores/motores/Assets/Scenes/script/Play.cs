using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 12f;
    public float extraMoveSpeed = 0.7f; // para movimentação direta (WASD)
    public Transform groundCheck;
    public float groundCheckRadius = 0.1f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private Animator animator;
    private float moveInput;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Entrada de movimento horizontal (A/D ou setas)
        moveInput = Input.GetAxisRaw("Horizontal");

        // Flip do personagem
        if (moveInput != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(moveInput), 1f, 1f);
        }

        // Animação de corrida
        animator.SetFloat("Speed", Mathf.Abs(moveInput));

        // Verificação de chão
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        animator.SetBool("IsJumping", !isGrounded);

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            Debug.Log("cardique");
        }

        // Movimento adicional com W, A, S, D (movimentação direta sem física)
        if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3(-extraMoveSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(extraMoveSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0, extraMoveSpeed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(0, -extraMoveSpeed * Time.deltaTime, 0);
    }

    void FixedUpdate()
    {
        // Movimento com física
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }

    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }
}
