using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem_Rotate : MonoBehaviour
{
    public int rotateSpeed=2;

    // Rotation Command
    void Update()
    {
        transform.Rotate(0, rotateSpeed* Time.timeScale, 0, Space.World);
    }
}
