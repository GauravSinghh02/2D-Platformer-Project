using UnityEngine;

public class EnemyStomp : MonoBehaviour
{
    [Header("Settings")]
    public float bounceForce = 10f;
    public GameObject enemyParent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();

            if (playerRb != null)
            {
                playerRb.linearVelocity = new Vector2(playerRb.linearVelocity.x, bounceForce);

                SoundManager.Instance.PlaySFX("SQUASH");

                Destroy(enemyParent);
            }
        }
    }
}
