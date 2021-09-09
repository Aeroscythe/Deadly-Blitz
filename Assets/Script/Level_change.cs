using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_change : MonoBehaviour
{
    public Animator transition;
    public float transitiontime;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "GuyWeMove")
        {
            LoadNextLvl();
        }
    }

    public void LoadNextLvl()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Continue");
        transition.SetTrigger("Flashing");

        yield return new WaitForSeconds(transitiontime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
