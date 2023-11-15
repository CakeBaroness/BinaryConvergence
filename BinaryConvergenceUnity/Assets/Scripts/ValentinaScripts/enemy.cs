using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour

{
    public Health playerHealth;
    public int damage = 1;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
        }
    }

}
