using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FstRotateSky : MonoBehaviour
{
    public float speed = 1000.0f;

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * speed);
    }
}
