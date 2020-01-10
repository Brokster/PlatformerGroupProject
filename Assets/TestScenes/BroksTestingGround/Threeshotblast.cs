using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Threeshotblast : MonoBehaviour
{
    public Transform player;
    public GameObject prefab;
    public float numShots = 5;            // Number of shots fired (should be odd); 
    public float spreadAngle = 2.0f;       // Angle between shots
    public float timeBetweenShots = 0.5f;  // Minimum time between shots
    public float nextShot = 0.0f;
    public float bulletSpeed = 10.0f;
    public float bulletLifetime = 1.0f;
    public float shootDelay = 1.0f;
    void Start()
    {
        if (numShots / 2 * 2 == numShots) numShots++; // Need an odd number of shots
        if (numShots < 3) numShots = 3;  // At least 3 shots for a fan
        //player.Position.x;
        //player.Position.y;
    }

    void Update()
    {
        {

            nextShot = Time.time + timeBetweenShots;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector2 shootDir = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
            Destroy(bullet, bulletLifetime);
            for (var i = 0; i < numShots; i++) ;
        }
    }
}
