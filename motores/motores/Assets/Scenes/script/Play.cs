using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalImput;
    private Rigidbody2D rb;

    public class andando : MonoBehaviour:
    [SerializeField]    private int velocidade = 5;
    private void awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

     void Update()
    {
        horizontalImput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalImput * velocidade, rb.linearVelocity.y);
    }
}