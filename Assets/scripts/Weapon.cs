using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform shotPos;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        Bullet bulletScript = GetComponent<Bullet>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject newBullet = Instantiate(bullet, shotPos.transform.position, transform.rotation);
            Bullet bulletScript = newBullet.GetComponent<Bullet>();

            if (transform.localScale.x > 0)
            {
                bulletScript.direction = 1;
            }
            else
            {
                bulletScript.direction = -1;
            }
        }
    }
}
