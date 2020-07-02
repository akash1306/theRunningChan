using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishScript : MonoBehaviour
{
    public GameObject levelaudio;
    public AudioSource lvlcomp;
    public GameObject lvltimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public GameObject totalScores;
    public int timeCalc;
    public int totalScored;
    public GameObject lvlLocker;
    void OnTriggerEnter()
    {
        timeCalc = GlobalTimer.extendScore * 30;
        timeLeft.GetComponent<Text>().text = "Time left: " + GlobalTimer.extendScore + " x 30";
        theScore.GetComponent<Text>().text = "Gem Score: " + GlobalScore.currentScore;
        totalScored = timeCalc + GlobalScore.currentScore;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        totalScores.GetComponent<Text>().text = "Total Score: " + totalScored;
        levelaudio.SetActive(false);
        lvltimer.SetActive(false);
        lvlcomp.Play();
        lvlLocker.SetActive(true);
        lvlLocker.transform.parent = null;
        StartCoroutine (calculatescore());

    }

    IEnumerator calculatescore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(1);
        theScore.SetActive(true);
        yield return new WaitForSeconds(1);
        totalScore.SetActive(true);
        totalScores.SetActive(true);
        yield return new WaitForSeconds(1);
    }

}
