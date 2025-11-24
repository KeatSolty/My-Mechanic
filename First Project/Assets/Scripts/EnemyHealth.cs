using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 100;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {

    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Destroy(this.gameObject);
        
        }
    }
}

