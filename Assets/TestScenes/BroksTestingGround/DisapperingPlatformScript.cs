using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapperingPlatformScript : MonoBehaviour {

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D> ();
    }
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.name.Equals("player"))
        {
            {
                Destroy(gameObject, 2f);
            }
        }
    }
}
