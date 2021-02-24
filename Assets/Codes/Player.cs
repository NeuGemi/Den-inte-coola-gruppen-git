using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Healthpoints healthBar;

    // Start is called before the first frame update
    void Start()
    {
        // Gör att man börjar med 100% hälsa -Henry
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // Gör att man tar skada när man klickar på pilen nedåt -Henry
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            TakeDamage(20); 
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
