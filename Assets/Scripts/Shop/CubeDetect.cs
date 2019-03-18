using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDetect : MonoBehaviour
{
    public GameObject selectCube, buyCube, price;
    public string nowCube;

    void Awake ()
    {
        if (PlayerPrefs.GetString ("cube1") != "Open") {
            PlayerPrefs.SetString ("cube1", "Open");
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        nowCube = other.gameObject.name;
        other.transform.localScale += new Vector3 (0.5f, 0.5f, 1f);
        if (PlayerPrefs.GetString (other.gameObject.name) == "Open") {
            selectCube.SetActive (true);
            buyCube.SetActive (false);
            price.SetActive (false);
        } else {
            selectCube.SetActive (false);
            buyCube.SetActive (true);
            //price.SetActive (true);
        }
    }

    void OnTriggerExit2D (Collider2D other)
    {
        other.transform.localScale -= new Vector3 (0.5f, 0.5f, 1f);
    }
}
