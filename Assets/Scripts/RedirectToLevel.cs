using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    public static int redtolvl;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (redtolvl == 3)
            SceneManager.LoadScene(redtolvl);
    }
}
