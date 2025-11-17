using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private PlatformMove player;

    private void Start()
    {
        player = GetComponent<PlatformMove>();
        player.transform.position = new Vector2(-1f, -2.7f);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
        }
    }
}
