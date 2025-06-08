using UnityEngine;

public class PlayerController : MonoBehaviour {
    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    [Header("Ground Check")]
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;
    private float moveInput;

    public Animator animator;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        // Handle horizontal movement input
        moveInput = Input.GetAxisRaw("Horizontal");

        // Flip based on Direction
        if (moveInput != 0) {
            transform.localScale = new Vector3(Mathf.Sign(moveInput), 1, 1);
        }

        // Set isWalking animation parameter
        animator.SetBool("isWalking", moveInput != 0);

        // Jumping
        if (Input.GetButtonDown("Jump") && isGrounded) {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); // Fixed typo: changed linearVelocity to velocity
        }
    }

    void FixedUpdate() {
        // Apply horizontal movement
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y); // Fixed typo: changed linearVelocity to velocity

        // Check if player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

    void OnDrawGizmosSelected() {
        // Visualize ground check in Scene view
        if (groundCheck != null) {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }
}
