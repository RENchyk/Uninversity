using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressDestroy : MonoBehaviour
{
    private string sound, vibro, nowCube, cube2, cube3, cube4;

    public void DestroyProgress ()
    {
        sound = PlayerPrefs.GetString ("Sound");
        vibro = PlayerPrefs.GetString ("Vibro");
        nowCube = PlayerPrefs.GetString ("Now Cube");
        cube2 = PlayerPrefs.GetString ("cube2");
        cube3 = PlayerPrefs.GetString ("cube3");
        cube4 = PlayerPrefs.GetString ("cube4");
        PlayerPrefs.DeleteAll ();
        PlayerPrefs.SetString ("Sound", sound);
        PlayerPrefs.SetString ("Vibro", vibro);
        PlayerPrefs.SetString ("Now Cube", nowCube);
        PlayerPrefs.SetString ("cube2", cube2);
        PlayerPrefs.SetString ("cube3", cube3);
        PlayerPrefs.SetString ("cube4", cube4);
    }
}
