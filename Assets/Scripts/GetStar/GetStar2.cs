using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GetStar2 : MonoBehaviour
{
    public Image [] stars1, stars2, stars3;

    void Awake ()
    {
        for (byte i = 21; i < stars1.Length + 21; i++)
        {
            if (PlayerPrefs.GetInt ("" + i) == 1)
            {
                stars1 [i - 21].color = new Color (255f, 255f, 255f, 255f);
            } else if (PlayerPrefs.GetInt ("" + i) == 0)
            {
                stars1 [i - 21].color = new Color (0f, 0f, 0f, 255f);
            }
        }
        for (byte j = 21; j < stars2.Length + 21; j++)
        {
            if (PlayerPrefs.GetInt ("" + j) == 2)
            {
                stars1 [j - 21].color = new Color (255f, 255f, 255f, 255f);
                stars2 [j - 21].color = new Color (255f, 255f, 255f, 255f);
            } else if (PlayerPrefs.GetInt ("" + j) == 0)
            {
                stars1 [j - 21].color = new Color (0f, 0f, 0f, 255f);
                stars2 [j - 21].color = new Color (0f, 0f, 0f, 255f);
            }
        }
        for (byte t = 21; t < stars3.Length + 21; t++)
        {
            if (PlayerPrefs.GetInt ("" + t) == 3)
            {
                stars1 [t - 21].color = new Color (255f, 255f, 255f, 255f);
                stars2 [t - 21].color = new Color (255f, 255f, 255f, 255f);
                stars3 [t - 21].color = new Color (255f, 255f, 255f, 255f);
            } else if (PlayerPrefs.GetInt ("" + t) == 0)
            {
                stars1 [t - 21].color = new Color (0f, 0f, 0f, 255f);
                stars2 [t - 21].color = new Color (0f, 0f, 0f, 255f);
                stars3 [t - 21].color = new Color (0f, 0f, 0f, 255f);
            }
        }
    }
}
