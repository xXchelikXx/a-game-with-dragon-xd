using UnityEngine;

public class TurrelWeapon : MonoBehaviour
{
    [Header("Стрельба")]
    public Transform shotPos;
    public GameObject bullet;
    public float fireRate = 3f;
    public Vector2 shootDirection = Vector2.left;

    private float nextFireTime;
    // Start is called before the first frame update
    void Start()
    {
        shootDirection = shootDirection.normalized;

        float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextFireTime) 
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        Instantiate(bullet, shotPos.position, shotPos.rotation);
    }
}
