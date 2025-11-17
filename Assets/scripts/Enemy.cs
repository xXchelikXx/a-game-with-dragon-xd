using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f; // Скорость движения объекта 
    public float distance = 3f; // Расстояние, на которое объект будет двигаться влево и вправо 

    private Vector3 startPos;
    private bool movingRight = true;
    public float startingHealth;
    public float currentHealth;
    private Animator anim;
    public bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
        }

        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }


        if (transform.position.x >= startPos.x + distance)
        {
            movingRight = false;
        }
        else if (transform.position.x <= startPos.x - distance)
        {
            movingRight = true;
        }
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            
        }
        if (currentHealth <= 0)
        {
            dead = true;
            
        }
    }
}


