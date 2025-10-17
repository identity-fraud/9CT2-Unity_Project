using UnityEngine;

public class Dash : MonoBehaviour
{
    public float speed = 20f;
    public float duration = 0.2f;
    public Transform spriteTransform; // the child that flips

    private Rigidbody2D rb;
    private bool isDashing = false;
    private float timer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (spriteTransform == null)
            Debug.LogWarning("Sprite Transform not assigned in Dash.cs!");
    }

    void Update()
    {
        if (isDashing)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                isDashing = false;
                rb.linearVelocity = Vector2.zero;
            }
            return;
        }

        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.E))
        {
            StartDash();
        }
    }

    void StartDash()
    {
        if (spriteTransform == null)
            return;

        isDashing = true;
        timer = duration;

        float facingDirection = Mathf.Sign(spriteTransform.localScale.x);
        rb.linearVelocity = new Vector2(facingDirection * speed, 0f);
    }
}
