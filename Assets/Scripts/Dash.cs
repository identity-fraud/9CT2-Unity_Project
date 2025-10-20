using UnityEngine;

public class Dash : MonoBehaviour
{
    public GameObject PlayerPrefab;
    private Vector3 facing = Vector3.right;
    private PlayerController controller;
    private bool isDashing = false;
    private float dashTimer;
    private float afterImageTimer;

    private int ran;
    private Rigidbody2D rb;

    void Start()
    {
        controller = GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ran = Random.Range(1,6);

        if (isDashing)
        {
            transform.Translate(facing * 40 * Time.deltaTime);
            dashTimer -= Time.deltaTime;
            afterImageTimer -= Time.deltaTime;

            if (afterImageTimer <= 0f)

            {
                AfterImage();
                afterImageTimer = 0.02f; // clone frequency
            }

            if (dashTimer <= 0f)
            {
                isDashing = false;
                rb.gravityScale = 5f;
            }
        }

        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.E))
        {
            StartDash();
        }

        if (controller.moving.x == 1)
        {
            facing = Vector3.right;
        }
        else if (controller.moving.x == -1)
        {
            facing = Vector3.left;
        }
    }

    void StartDash()
    {
        isDashing = true;
        dashTimer = 0.25f;
        rb.gravityScale = 0f;
        afterImageTimer = 0f;
        rb.linearVelocity = Vector2.zero;

    }
    void AfterImage()
    {
        GameObject clone = Instantiate(PlayerPrefab, transform.position, transform.rotation);
        SpriteRenderer sr = clone.GetComponent<SpriteRenderer>();
        sr.color = new Color(1, 1, 1, 0.5f);

        
        
        if (ran == 1)
        {
            sr.material.color = Color.red;

        }

        if (ran == 2)
        {
            sr.material.color = Color.blue;
        }

        if (ran == 3)
        {
            sr.material.color = Color.green;
        }

        if (ran == 4)
        {
            sr.material.color = Color.red;
        }

        if (ran == 5)
        {
            sr.material.color = Color.yellow;
        }

        if (ran == 6)
        {
            sr.material.color = Color.red;
        }
        
        Destroy(clone, 0.5f);
    }
}
