using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int damage = 10;

    public Health_bar healthBar;

    public Animator transition;
    public float transitiontime;

    public Animator Death;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Enemy"){
            TakeDamage(damage);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void Update()
    {
        if (currentHealth == 0)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        Death.SetTrigger("Die");

        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene("x. GameOver");
    }

}
