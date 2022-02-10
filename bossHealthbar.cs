using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossHealthbar : MonoBehaviour
{
    private Image HealthBar;
    public float MaxHealth = 100f;
    private float currentHealth = 0f;
    
    void Start()
    {
        HealthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = FindObjectOfType<bossscr>().healtBar;
        HealthBar.fillAmount = currentHealth / MaxHealth;
    }
}
