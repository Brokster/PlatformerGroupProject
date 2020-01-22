using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    bool damage = false;
    bool Death = false;
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

    void ApplyDamage(int Enemy)
    {
        currentHP--;
        damage = true;
    }

    void KillPlayer()
    {
        {
            SceneManager.LoadScene("death");
             Death = true;
        }
    }

}
