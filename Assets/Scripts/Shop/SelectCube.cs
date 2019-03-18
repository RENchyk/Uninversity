using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCube : MonoBehaviour
{
    public GameObject whichCube, mainCube;

    void OnMouseDown ()
    {
        mainCube.GetComponent <SpriteRenderer> ().sprite = GameObject.Find (whichCube.GetComponent <CubeDetect> ().nowCube).GetComponent <SpriteRenderer> ().sprite;
        PlayerPrefs.SetString ("Now Cube", whichCube.GetComponent <CubeDetect> ().nowCube);
    }
}