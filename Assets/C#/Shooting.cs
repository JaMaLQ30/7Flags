
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class Shooting : MonoBehaviour
{
    public Transform Gun;
    public GameObject bulletPrefab;
    public float bulletSpeed = 100f;



    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab, Gun.position, Gun.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
        }

    }
}