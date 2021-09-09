using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button : MonoBehaviour
{
    public Animator transition;
    public float transitiontime;

    public AdMobBanner Advert;

    public void PlayGame()
    {
        Advert.BannerDelete();
        LoadNextLvl();
    }

    public void LoadNextLvl()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene("1. Level 1");
    }
}
