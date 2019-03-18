using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public GameObject BGMusic;
    private bool playOnce = false;

    void Awake ()
    {
        if (GameObject.FindGameObjectsWithTag ("Music").Length == 1) {
            DontDestroyOnLoad (BGMusic);
        } else {
            Destroy (BGMusic);
        }
    }

    void Update ()
    {
        if (PlayerPrefs.GetString ("Sound") == "no") {
            GameObject.FindGameObjectWithTag ("Music").GetComponent <AudioSource> ().volume = 0f;
            playOnce = false;
        } else if (PlayerPrefs.GetString ("Sound") != "no" && !playOnce) {
            GameObject.FindGameObjectWithTag ("Music").GetComponent <AudioSource> ().volume = 0.1f;
            playOnce = true;
        }
    }
}
