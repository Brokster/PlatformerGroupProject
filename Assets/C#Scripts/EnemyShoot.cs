using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform player;
    public GameObject prefab;
    public float bulletSpeed = 10.0f;
    public float bulletLifetime = 1.0f;
    public float shootDelay = 1.0f;
    float timer = 0;
    var numShots = 5;            // Number of shots fired (should be odd); 
    var spreadAngle = 2.0;       // Angle between shots
    var timeBetweenShots = 0.5;  // Minimum time between shots

    // Start is called before the first frame update
    void Start()
    {
        //player.Position.x;
        //player.Position.y;
        if (numShots / 2 * 2 == numShots) numShots++; // Need an odd number of shots
        if (numShots < 3) numShots = 3;  // At least 3 shots for a fan
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > shootDelay)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector2 shootDir = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
            Destroy(bullet, bulletLifetime);
            var qAngle = Quaternion.AngleAxis(-numShots / 2.0 * spreadAngle, transform.up) * transform.rotation;
            var qDelta = Quaternion.AngleAxis(spreadAngle, transform.up);

            for (var i = 0; i < numShots; i++)
            {
                var go; GameObject = Instantiate(playerProjectile, transform.position, qAngle);
                go.rigidbody.AddForce(go.transform.forward * 1000.0);
                qAngle = qDelta * qAngle;
            }

        }
    }
}
