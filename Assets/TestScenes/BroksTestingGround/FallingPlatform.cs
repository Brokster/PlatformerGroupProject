﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.name.Equals ("player"))
        {
            Invoke("DropPlatform", 0.5f);
            Destroy(gameObject, 2f);
        }
    }
       void DropPlatform()
    {
        rb.isKinematic = false;
    }
}
