using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Explode : MonoBehaviour
{
    private bool isDead = false;
    private BoxCollider2D playerCollider;

    void Start()
    {
        playerCollider = GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.CompareTag("Deadly"))
        {
            Die();
        }
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.CompareTag("Deadly"))
        {
            Die();
        }
    }

    void Die()
    {
        if (isDead) return;
        isDead = true;

        if (playerCollider != null)
            playerCollider.enabled = false;

        // Wait 1 second then reload current scene
        StartCoroutine(Respawn());
    }

    private IEnumerator Respawn()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
