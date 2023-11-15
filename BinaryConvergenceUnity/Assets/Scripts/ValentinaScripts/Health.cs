using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject respawnPoint;
    public GameObject player;
    public int currentHealth;
    public int maxPlayerHealth = 50;
    public FillStatusBar healthBar;

    private void Start()
    {
        currentHealth = maxPlayerHealth;
        healthBar.SetMaxHealth(maxPlayerHealth);
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Death();
        }

         void Death()
        {
            player.transform.position = respawnPoint.transform.position;
        }
    }

    

   
    
    // Update is called once per frame
   // void Update()
    
}
