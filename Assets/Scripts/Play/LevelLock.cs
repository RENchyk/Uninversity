using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLock : MonoBehaviour
{
    public GameObject [] stars, locks, numbers,
                         stars2, locks2, numbers2,
                         stars3, locks3, numbers3;

    void Awake ()
    {
        for (int i = 11; i < stars.Length + 11; i ++)
        {
            if (PlayerPrefs.GetInt ("" + i) == 0)
            {
                stars [i - 11].SetActive (false);
                numbers [i - 11].SetActive (false);
                locks [i - 11].SetActive (true);
            } else if (PlayerPrefs.GetInt ("" + i) != 0)
            {
                stars [i - 11].SetActive (true);
                numbers [i - 11].SetActive (true);
                locks [i - 11].SetActive (false);
            }
        }
        for (int i = 21; i < stars2.Length + 21; i ++)
        {
            if (PlayerPrefs.GetInt ("" + i) == 0)
            {
                stars2 [i - 21].SetActive (false);
                numbers2 [i - 21].SetActive (false);
                locks2 [i - 21].SetActive (true);
            } else if (PlayerPrefs.GetInt ("" + i) != 0)
            {
                stars2 [i - 21].SetActive (true);
                numbers2 [i - 21].SetActive (true);
                locks2 [i - 21].SetActive (false);
            }
        }
        for (int i = 31; i < stars3.Length + 31; i ++)
        {
            if (PlayerPrefs.GetInt ("" + i) == 0)
            {
                stars3 [i - 31].SetActive (false);
                numbers3 [i - 31].SetActive (false);
                locks3 [i - 31].SetActive (true);
            } else if (PlayerPrefs.GetInt ("" + i) != 0)
            {
                stars3 [i - 31].SetActive (true);
                numbers3 [i - 31].SetActive (true);
                locks3 [i - 31].SetActive (false);
            }
        }
    }
}
