using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{

    public int HP;
    public void DamageToEnemy(int dmg)
    {
        HP -= dmg;
        if (HP <= 0)
        {
            //KILL enemy;
        }
    }
     public class bullet : MonoBehaviour
    {
        public int DamageToEnemy;

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Enemy")
            {
                other.GetComponent<EnemyHP>().DamageToEnemy(DamageToEnemy);
                Destroy(gameObject);
            }
        }
    }
}

