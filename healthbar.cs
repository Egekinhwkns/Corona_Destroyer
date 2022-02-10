using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    private Image HealthBar;

    public float currentHealth;

    private float MaxHealth = 50f;
  
    void Start()
    {
        HealthBar = GetComponent<Image>();
    }
    
    void Update()
    {
        currentHealth = FindObjectOfType<ballMovement>().health;
        HealthBar.fillAmount = currentHealth / MaxHealth;
    }
}
