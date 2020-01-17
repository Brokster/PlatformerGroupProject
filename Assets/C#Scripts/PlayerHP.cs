﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    bool dead = false;
    int maxHP;
    int currentHP;
    GameObject deathModel;

    void Start()
    {
        currentHP = 20;
    }

    void Update()
    {

    }

    void ApplyDamage(int enemy)
    {
        currentHP--;
    }

    void KillPlayer()
    {
        {
            SceneManager.LoadScene("death");
             dead = true;
        }
    }

}