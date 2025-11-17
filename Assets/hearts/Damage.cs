using UnityEngine;

public class Damage : MonoBehaviour
{
    public float damageEnemy;
    private Health player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GetComponent<Health>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<Health>().TakeDamage(damageEnemy);
        }
    }          
}
