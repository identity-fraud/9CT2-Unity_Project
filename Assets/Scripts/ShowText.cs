using UnityEngine;

public class ShowText : MonoBehaviour
{
    public GameObject Player;

    void Update()
    {
        if (Player == null) return;

        CanvasGroup cg = GetComponent<CanvasGroup>();
        cg ??= gameObject.AddComponent<CanvasGroup>();

        float distance = Vector3.Distance(Player.transform.position, transform.position);
        float targetAlpha = distance <= 10f ? 1f : 0f;
        cg.alpha = Mathf.MoveTowards(cg.alpha, targetAlpha, 3f * Time.deltaTime);
    }
}
