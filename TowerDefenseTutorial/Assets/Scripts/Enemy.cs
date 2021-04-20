using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [Header("Attribute")]
    public float startHealth = 100f;
    private float health;


    public int worth = 50;
    public float startSpeed = 10f;

    [HideInInspector]
    public float speed = 10f;

    public GameObject deathEffect;

    [Header("Unity Stuff")]
    public Image healthBar;




    void Start()
    {
        speed = startSpeed;
        health = startHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        healthBar.fillAmount = health /startHealth;

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

        WaveSpawner.EnemiesAlive--;
        
        Destroy(gameObject);
        
    }
  
}




