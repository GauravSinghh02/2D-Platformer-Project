using UnityEngine;
using UnityEngine.SceneManagement;

public class FallZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (SoundManager.Instance != null)
            {
                SoundManager.Instance.PlaySFX("HURT");
            }

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
