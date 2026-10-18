using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rd;
    private Keyboard keyboard;

    public float moveSpeed = 5f;
    public float jumpForce = 7f;

    private bool isGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        keyboard = Keyboard.current;

        if (keyboard == null) return;

        // Movimiento horizontal
        float move = 0f;

        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            move = -1f;
        }

        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            move = 1f;
        }

        rd.linearVelocity = new Vector2(move * moveSpeed, rd.linearVelocity.y);


        if (keyboard.spaceKey.wasPressedThisFrame && isGrounded)
        {
            rd.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    // Detectar cuando toca el suelo
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // Detectar cuando deja el suelo
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

}
