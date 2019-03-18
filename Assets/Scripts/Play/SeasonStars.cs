using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeasonStars : MonoBehaviour
{
    public Text [] starText1, starText3;
    public int [] starCount1;
    public string [] starCount3;

    void Awake ()
    {
        for (byte j = 0; j < starCount1.Length; j++)
        {
            starCount1 [j] = PlayerPrefs.GetInt (j + 1 + "1") + PlayerPrefs.GetInt (j + 1 + "2") + PlayerPrefs.GetInt (j + 1 + "3") + PlayerPrefs.GetInt (j + 1 + "4");
        }
        for (byte i = 0; i < starText1.Length; i++)
        {
            starText1 [i].text = starCount1 [i].ToString ();
            starText3 [i].text = starCount3 [i];
        }
    }
}
