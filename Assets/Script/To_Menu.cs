using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To_Menu : MonoBehaviour
{
    public Animator transition;
    public float transitiontime;
    public GameObject Ad;

    public AdMobBanner2 Advert;

    public void LoadMenu()
    {
        Advert.BannerDelete();
        StartCoroutine(LoadLevel(2));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        Destroy(gameObject);

        SceneManager.LoadScene(levelIndex);
    }
}
