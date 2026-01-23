using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{

    public float PHealth, MaxHealth = 100;

    [SerializeField]
    private PlayerHealthBarUI healthbar;

    void Start()
    {
        PHealth = MaxHealth;
        healthbar.SetMaxHealth(MaxHealth);
    }

    void Update()
    {
        healthbar.SetHealth(PHealth);
    }

    public void TakeDamage(int amount)
    {
        PHealth -= amount;
        SetHealth(amount);
        if (PHealth <= 0)
        {
            SceneManager.LoadScene("DeathScene");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }

    public void SetHealth(float healthChange)
    {
        PHealth -= healthChange;
        PHealth = Mathf.Clamp(PHealth, 0, MaxHealth);

        healthbar.SetHealth(PHealth);
    
    
    }
}

