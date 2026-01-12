using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float EHealth, MaxHealth = 100;
    public GameObject tpstaff;

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
            Instantiate(tpstaff, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);

        }
    }

    public void SetHealth(float healthChange)
    {

        EHealth = Mathf.Clamp(EHealth, 0, MaxHealth);

        healthbar.SetHealth(EHealth);


    }
}

