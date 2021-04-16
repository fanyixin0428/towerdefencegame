using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Attribute")]
    public float health = 100f;
    public int worth = 50;
    public float startSpeed = 10f;

    [HideInInspector]
    public float speed = 10f;

    public GameObject deathEffect;

    void Start()
    {
        speed = startSpeed;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }

    }

    public void Slow(float percent)

    {
        speed = Mathf.Max(startSpeed*(1f - percent), .3f);

    }

    void Die()
    {
        PlayerStats.Money += worth;

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        
        Destroy(gameObject);
        
    }
  
}




