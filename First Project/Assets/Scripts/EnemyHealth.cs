using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float EHealth, MaxHealth = 100;

    [SerializeField]
    private EnemyHealthUI healthbar;

    void Start()
    {
        EHealth = MaxHealth;
        healthbar.SetMaxHealth(MaxHealth);
    }

    void Update()
    {
        healthbar.SetHealth(EHealth);
    }

    public void TakeDamage(int amount)
    {
        EHealth -= amount;
        SetHealth(amount);
        if (EHealth <= 0)
        {
            Destroy(this.gameObject);

        }
    }

    public void SetHealth(float healthChange)
    {

        EHealth = Mathf.Clamp(EHealth, 0, MaxHealth);

        healthbar.SetHealth(EHealth);


    }
}

