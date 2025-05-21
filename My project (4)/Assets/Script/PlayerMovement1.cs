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
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(moveX, moveY).normalized;

        // Alleen draaien als er input is
        if (direction != Vector2.zero)
        {
            if (moveX > 0) // Rechts
                transform.rotation = Quaternion.Euler(0, 0, -90f);
            else if (moveX < 0) // Links
                transform.rotation = Quaternion.Euler(0, 0, 90f);
            else if (moveY > 0) // Omhoog
                transform.rotation = Quaternion.Euler(0, 0, 0f);
            else if (moveY < 0) // Omlaag
                transform.rotation = Quaternion.Euler(0, 0, 180f);
        }

        // Verplaatsen
        transform.position += (Vector3)direction * moveSpeed * Time.deltaTime;
    }



    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
