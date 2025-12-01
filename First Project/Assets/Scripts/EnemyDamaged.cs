using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamaged : MonoBehaviour
{
    public int damage = 20;
    public EnemyHealth enemyHealth;
    public EnemyHealthUI healthUI;
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
