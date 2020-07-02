using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl001 : MonoBehaviour
{
    public GameObject fadeIn;
    void Start()
    {
        RedirectToLevel.redtolvl = 3;
        StartCoroutine(fadeInof());
    }
    IEnumerator fadeInof()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
