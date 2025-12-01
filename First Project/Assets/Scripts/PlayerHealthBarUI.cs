using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerHealthBarUI : MonoBehaviour
{
    public float Health, MaxHealth, Width, Height = 30;

    [SerializeField]
    private RectTransform healthBar;

    private void Start()
    {
        Width = healthBar.sizeDelta.x;
    }
    public void SetMaxHealth(float maxHealth)
    { 
    MaxHealth = maxHealth;
   
    }
    private void Update()
    {
        float newWidth = Health / MaxHealth;
        healthBar.sizeDelta = new Vector2(newWidth, Height);
    }
    public void SetHealth(float health)
    { 
        Health = health;
        float newWidth = (health / MaxHealth) * Width;

        healthBar.sizeDelta = new Vector2(newWidth, Height);
    
    
    }
}
