using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;
    
    public HealthBar healthBar;

    [SerializeField]
    private GameObject
        deathChunkParticle,
        deathBloodParticle;

    [SerializeField]
    private float currentHealth;

    private GameManager GM;
    private GameMaster gm;


    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        GM= GameObject.Find("GameManager").GetComponent<GameManager>();
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
    }

    public void DecreaseHealth(float amount)
    {
        currentHealth -= amount;

        gameObject.GetComponent<Animation>().Play("RedFlash");

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0.0f)
        {
            Die();
        }
    }

    private void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Destroy(gameObject);

        if(PlayerPrefs.GetInt("highscore") < gm.points)
        {
            PlayerPrefs.SetInt("highscore", gm.points);
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Coins"))
        {
            FindObjectOfType<SoundManager>().Play("Coin");
            Destroy(col.gameObject);
            gm.points += 1;
        }
    }
}
