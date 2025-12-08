using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 1. Check if the object that touched us is the Player
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController playerScript = collision.gameObject.GetComponent<PlayerController>();

            if (playerScript != null)
            {
                playerScript.coin += 1;

                // 5. Destroy this coin object so it disappears
                Destroy(gameObject);
            }
        }
    }
}
