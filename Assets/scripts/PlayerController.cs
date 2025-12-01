using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    public bool isGrounded;
    private Animator anim;
    private PlatformMove player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        player = GetComponent<PlatformMove>();
        player.transform.position = new Vector2(-1f, -2.7f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
    
    // коллизии
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Platform"))
        {
            this.transform.parent = collision.transform;
        }

        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
            anim.SetBool("jump", false);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            this.transform.parent = null;
        }

        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false;
        }

    }

    private void Move()
    {
        float horiz = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horiz * moveSpeed, rb.velocity.y);
        anim.SetBool("walk", horiz != 0);

        if (horiz > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (horiz < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    private void Jump()
    {
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            anim.SetBool("jump", true);
        }
    }
}
