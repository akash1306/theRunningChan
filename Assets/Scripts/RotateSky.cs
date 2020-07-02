using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * speed);
    }
}
