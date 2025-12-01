using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int damage = 20;
    public PlayerHealth playerHealth;

    void Start()
    {



    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            playerHealth.TakeDamage(damage);

        }
    }



}
