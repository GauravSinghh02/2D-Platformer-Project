using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(door);
            SoundManager.Instance.PlaySFX("COIN");
            Destroy(gameObject);
        }
    }
}
