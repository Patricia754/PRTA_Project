using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb.freezeRotation = true;

    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Reset flips
        spriteRenderer.flipX = false;
        spriteRenderer.flipY = false;

        if (moveX > 0) // Rechts
        {
            spriteRenderer.flipX = false;
        }
        else if (moveX < 0) // Links
        {
            spriteRenderer.flipX = true; // Spiegel horizontaal
        }
        else if (moveY > 0) // Omhoog
        {
            // geen flip
        }
        else if (moveY < 0) // Omlaag
        {
            spriteRenderer.flipX = true; // Spiegel verticaal
        }

        // Beweging toepassen (optioneel)
        Vector2 direction = new Vector2(moveX, moveY).normalized;
        transform.position += (Vector3)direction * moveSpeed * Time.deltaTime;
    }



    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
