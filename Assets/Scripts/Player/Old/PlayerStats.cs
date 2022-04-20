using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerStats : MonoBehaviour
{
    private RectTransform heartUI;

    [SerializeField]
    private float maxHealth;

    [SerializeField]
    private GameObject
        deathChunkParticle,
        deathBloodParticle;

    private float currentHealth;
    private float _heartSize = 16f;
    private GameManager GM;
   
    private void Start()
    {
        currentHealth = maxHealth;
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        heartUI = GameObject.Find("HeartsUI").GetComponent<RectTransform>();
        heartUI.sizeDelta = new Vector2(_heartSize * 5, _heartSize);
    }

    public void DecreaseHealth(float amount)
    {

            currentHealth = currentHealth - amount;
            heartUI.sizeDelta = new Vector2(_heartSize * currentHealth, _heartSize);
        if (currentHealth <= 0.0f)
            {
                Die();
            }
            
        
        
    }

    public void AddHealth(float amount)
    {
        if (currentHealth == maxHealth)
        {

        }
        else
        {
            currentHealth = currentHealth + amount;

            if (currentHealth >= maxHealth)
            {
                currentHealth = maxHealth;
            }
            else
            {
                heartUI.sizeDelta = new Vector2(_heartSize * currentHealth, _heartSize);
            }
        }
        
        

    }

    private void Die()
    {
        Instantiate(deathChunkParticle, transform.position, deathChunkParticle.transform.rotation);
        Instantiate(deathBloodParticle, transform.position, deathBloodParticle.transform.rotation);
        GM.Respawn();
        Destroy(gameObject);
    }
}
