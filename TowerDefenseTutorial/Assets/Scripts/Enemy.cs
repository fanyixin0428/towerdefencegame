using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Attribute")]
    public float speed = 10f;
    public float health = 100f;
    public int worth = 50;


    public GameObject deathEffect;

    

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        PlayerStats.Money += worth;

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        
        Destroy(gameObject);
        
    }
  
}




