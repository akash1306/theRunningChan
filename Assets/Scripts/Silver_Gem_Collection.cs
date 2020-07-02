using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Silver_Gem_Collection : MonoBehaviour
{
    public GameObject ScoreBox;
    public AudioSource collectSound;
    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 1000;
        collectSound.Play();
        Destroy(gameObject);
    }
}
