using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
    public int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);

        if (direction < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            Destroy(gameObject, 1f);
        }
    }
}
