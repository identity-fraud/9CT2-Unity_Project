using UnityEngine;

public class Dash : MonoBehaviour
{
    public float speed = 20f;
    public float duration = 0.2f;

    private bool isDashing = false;
    private float timer;
    private Vector2 direction;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        if (isDashing)
        {
            rb.linearVelocity = direction * speed;

            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                isDashing = false;
                rb.linearVelocity = Vector2.zero;
            }

            return; 
        }

        // Dash Left (Q)
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartDash(Vector2.left);
        }

        // Dash Right (E)
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartDash(Vector2.right);
        }
    }

    void StartDash(Vector2 dir)
    {
        isDashing = true;
        direction = dir;
        timer = duration;
    }
}
