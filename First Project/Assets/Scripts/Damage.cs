using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 2;
    public EnemyHealth enemyHealth;

    void Start()
    { 
    
    
    
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            enemyHealth.TakeDamage(damage);

        }
    }



}
