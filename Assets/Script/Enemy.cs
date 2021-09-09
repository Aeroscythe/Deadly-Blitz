using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;

    public Animator Killed;
    public float transitiontime = 0.5f;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        StartCoroutine(Kill());
    }

    IEnumerator Kill()
    {
        Killed.SetTrigger("Killed");

        yield return new WaitForSeconds(transitiontime);

        Destroy(gameObject);
    }
}
