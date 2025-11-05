using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 100f;
    public Vector2 maxVelocity = new Vector2(100, 100);
    public float jetSpeed = 30f;
    public float standingThreshold = 0.5f;   // lower = more reliable standing detection
    public float airSpeedMultiplier = 1; // smoother air movement

    private bool standing;
    private bool canJump = true;

    private Rigidbody2D body2D;
    private SpriteRenderer renderer2D;
    private Animator animator;
    private PlayerController controller;

    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        renderer2D = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        controller = GetComponent<PlayerController>();
    }

    void Update()
    {
        // Respawn if player falls off
        if (transform.position.y < -150f)
            SceneManager.LoadScene("SplashScreen");
    }

    void FixedUpdate()
    {
        float absVelX = Mathf.Abs(body2D.linearVelocity.x);
        float absVelY = Mathf.Abs(body2D.linearVelocity.y);

        // Consider standing if barely moving vertically
        standing = absVelY <= standingThreshold;

        // --- HORIZONTAL MOVEMENT ---
        float forceX = 0f;

        if (controller.moving.x != 0)
        {
            if (standing)
            {
                // Full ground control
                forceX = speed * controller.moving.x;
            }
            else
            {
                // Limited air control
                float targetX = controller.moving.x * maxVelocity.x;
                forceX = (targetX - body2D.linearVelocity.x) * airSpeedMultiplier;
            }

            renderer2D.flipX = forceX < 0;
            animator.SetInteger("AnimState", 1); // running
        }
        else if (standing)
        {
            animator.SetInteger("AnimState", 0); // idle
        }

        body2D.AddForce(new Vector2(forceX, 0f));

        // --- JUMP ---
        if (controller.moving.y > 0 && standing && canJump)
        {
            body2D.AddForce(Vector2.up * jetSpeed, ForceMode2D.Impulse);
            canJump = false;
            animator.SetInteger("AnimState", 2); // jump
        }

        // --- CLAMP VELOCITY ---
        body2D.linearVelocity = new Vector2(
            Mathf.Clamp(body2D.linearVelocity.x, -maxVelocity.x, maxVelocity.x),
            Mathf.Clamp(body2D.linearVelocity.y, -maxVelocity.y, maxVelocity.y)
        );

        // --- FALL ANIMATION ---
        if (!standing)
            animator.SetInteger("AnimState", 2);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
            canJump = true;
    }
}
