using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LvlDeath : MonoBehaviour
{
    public GameObject youfell;
    public GameObject lvlaudio;
    public AudioSource deathsound;
    public GameObject fastrotate;


    void OnTriggerEnter()
        {
            StartCoroutine(youfelloff());
        }

    IEnumerator youfelloff ()
        {
            youfell.SetActive(true);
            lvlaudio.SetActive(false);
            fastrotate.SetActive(true);
            deathsound.Play();
            yield return new WaitForSeconds(7);
            SceneManager.LoadScene(2);
        }

}
