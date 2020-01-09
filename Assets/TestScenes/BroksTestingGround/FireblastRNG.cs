using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireblastRNG : MonoBehaviour
{
    public Transform player;
    public GameObject prefab;
    public float bulletSpeed = 10.0f;
    public float bulletLifetime = 1.0f;
    public float shootDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //player.Position.x;
        //player.Position.y;
        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        Instantiate(prefab, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
        Vector2 shootDir = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        shootDir.Normalize();
        bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
        Destroy(bullet, bulletLifetime);
    } 
}
