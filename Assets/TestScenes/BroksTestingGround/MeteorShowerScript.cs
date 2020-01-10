using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorShowerScript : MonoBehaviour
{
   public Transform player;
    public GameObject prefab;
    public float bulletSpeed = 10.0f;
    public float bulletLifetime = 1.0f;
    public float shootDelay = 1.0f;
    public float numShots = 5;            // Number of shots fired (should be odd); 
    public float spreadAngle = 2.0f;       // Angle between shots
    public float timeBetweenShots = 0.5f;  // Minimum time between shots

    // Start is called before the first frame update
    void Start()
    {
        //player.Position.x;
        //player.Position.y;
        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        Instantiate(prefab, position, Quaternion.identity);
        if (numShots / 2 * 2 == numShots) numShots++; // Need an odd number of shots
        if (numShots < 3) numShots = 3;  // At least 3 shots for a fan
    }

    // Update is called once per frame
    void Update()
    {
        GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
        Vector2 shootDir = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
        Destroy(bullet, bulletLifetime);
    } 
}
