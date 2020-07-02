using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashtoMenu : MonoBehaviour
{
    public GameObject theLogo;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(runsplash());  
    }
    IEnumerator runsplash()
    {
        yield return new WaitForSeconds(0.5f);
        theLogo.SetActive(true);
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(1);
    }
}
