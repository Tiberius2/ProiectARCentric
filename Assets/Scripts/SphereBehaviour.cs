using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehaviour : MonoBehaviour
{
    /*    private void OnCollisionEnter(Collision collision)
        {
            //Debug.Log(collision.collider.name);
            if (collision.collider.name == "bullet 1")
            {
                Debug.Log("The bullet hit the deathsphere");
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }*/

    public int maxHealth = 3; 
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; 

        if (currentHealth <= 0)
        {
            DestroyTarget();
        }
    }

    void DestroyTarget()
    {
        
        Destroy(gameObject);
    }
}
