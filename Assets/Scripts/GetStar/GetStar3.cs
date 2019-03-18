using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GetStar3 : MonoBehaviour
{
    public Image [] stars1, stars2, stars3;

    void Awake ()
    {
        for (byte i = 31; i < stars1.Length + 31; i++)
        {
            if (PlayerPrefs.GetInt ("" + i) == 1)
            {
                stars1 [i - 31].color = new Color (255f, 255f, 255f, 255f);
            } else if (PlayerPrefs.GetInt ("" + i) == 0)
            {
                stars1 [i - 31].color = new Color (0f, 0f, 0f, 255f);
            }
        }
        for (byte j = 31; j < stars2.Length + 31; j++)
        {
            if (PlayerPrefs.GetInt ("" + j) == 2)
            {
                stars1 [j - 31].color = new Color (255f, 255f, 255f, 255f);
                stars2 [j - 31].color = new Color (255f, 255f, 255f, 255f);
            } else if (PlayerPrefs.GetInt ("" + j) == 0)
            {
                stars1 [j - 31].color = new Color (0f, 0f, 0f, 255f);
                stars2 [j - 31].color = new Color (0f, 0f, 0f, 255f);
            }
        }
        for (byte t = 31; t < stars3.Length + 31; t++)
        {
            if (PlayerPrefs.GetInt ("" + t) == 3)
            {
                stars1 [t - 31].color = new Color (255f, 255f, 255f, 255f);
                stars2 [t - 31].color = new Color (255f, 255f, 255f, 255f);
                stars3 [t - 31].color = new Color (255f, 255f, 255f, 255f);
            } else if (PlayerPrefs.GetInt ("" + t) == 0)
            {
                stars1 [t - 31].color = new Color (0f, 0f, 0f, 255f);
                stars2 [t - 31].color = new Color (0f, 0f, 0f, 255f);
                stars3 [t - 31].color = new Color (0f, 0f, 0f, 255f);
            }
        }
    }
}
