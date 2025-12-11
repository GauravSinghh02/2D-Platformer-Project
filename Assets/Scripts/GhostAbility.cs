using System.Collections;
using UnityEngine;

public class GhostAbility : MonoBehaviour
{
    [Header("Settings")]
    public float duration = 2f;
    public float cooldown = 5f;

    [Header("Visuals")]
    public float ghostAlpha = 0.5f;

    private bool isGhost = false;
    private float nextUseTime = 0f;
    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Time.time > nextUseTime)
        {
            StartCoroutine(ActivateGhost());
        }
    }

    IEnumerator ActivateGhost()
    {
        isGhost = true;
        nextUseTime = Time.time + cooldown + duration;

        spriteRenderer.color = new Color(
            originalColor.r,
            originalColor.g,
            originalColor.b,
            ghostAlpha
        );

        int playerLayer = LayerMask.NameToLayer("Player");
        int enemyLayer = LayerMask.NameToLayer("Enemy");
        Physics2D.IgnoreLayerCollision(playerLayer, enemyLayer, true);

        SoundManager.Instance.PlaySFX("JUMP");

        yield return new WaitForSeconds(duration);

        spriteRenderer.color = originalColor;
        Physics2D.IgnoreLayerCollision(playerLayer, enemyLayer, false);
        isGhost = false;
    }
}
