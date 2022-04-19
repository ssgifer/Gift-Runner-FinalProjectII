using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public int maxHealth = 50000;
    public int currentHealth;
    public int damage;
    public HealthBar healthBar;
    public GameObject gameDeath; 

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        TakeDamage(10);

        if (currentHealth <= 0)
        {
            gameDeath.SetActive(true);
        }
}

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

}

