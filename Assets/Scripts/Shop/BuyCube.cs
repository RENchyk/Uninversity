using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyCube : MonoBehaviour
{
    public GameObject selectBtn, whichCube, mainCube, price;

    void OnMouseUpAsButton ()
    {
        if (PlayerPrefs.GetInt ("GScore") >= 0) {
            PlayerPrefs.SetString (whichCube.GetComponent <CubeDetect> ().nowCube, "Open");
            PlayerPrefs.SetString ("Now Cube", whichCube.GetComponent <CubeDetect> ().nowCube);
            //PlayerPrefs.SetInt ("GScore", PlayerPrefs.GetInt ("GScore") - 50);
            mainCube.GetComponent <SpriteRenderer> ().sprite = GameObject.Find (whichCube.GetComponent <CubeDetect> ().nowCube).GetComponent <SpriteRenderer> ().sprite;
            selectBtn.SetActive (true);
            gameObject.SetActive (false);
            price.SetActive (false);
        } else {
            selectBtn.SetActive (false);
        }
    }
}