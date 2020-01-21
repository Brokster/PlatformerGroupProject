﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMap : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.tag == "Death")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //lives--;
        }
    }
}
