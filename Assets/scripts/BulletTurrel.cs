using UnityEngine;

public class BulletTurrel : MonoBehaviour
{
    public float speed = 3f;
    public float lifeTime = 3f;
    private Rigidbody2D rb;
    private Health playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-1,0) * speed;
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        playerHealth = GetComponent<Health>();
        if (collision.gameObject.CompareTag("Player"))
        {
            
        }
    }
}
