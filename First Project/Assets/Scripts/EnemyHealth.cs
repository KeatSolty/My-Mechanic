using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int EHealth;
    public int maxHealth = 100;

    void Start()
    {
        EHealth = maxHealth;
    }

    void Update()
    {

    }

    public void TakeDamage(int amount)
    {
        EHealth -= amount;

        if (EHealth <= 0)
        {
            Destroy(this.gameObject);
        
        }
    }
}

