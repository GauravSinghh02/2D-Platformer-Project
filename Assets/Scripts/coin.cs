using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Coin : MonoBehaviour
{
    public AudioClip coinClip;
    public int coinsToGive = 1;
    private TextMeshProUGUI coinText;

    private void Start()
    {
        coinText = GameObject.FindWithTag("coinText").GetComponent<TextMeshProUGUI>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        // 1. Check if the object that touched us is the Player
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController playerScript = collision.gameObject.GetComponent<PlayerController>();
            SoundManager.Instance.PlaySFX("COIN", 0.4f);

            if (playerScript != null)
            {
                playerScript.coin += coinsToGive;
                coinText.text = playerScript.coin.ToString();

                // 5. Destroy this coin object so it disappears
                Destroy(gameObject);
            }
        }
    }
}
