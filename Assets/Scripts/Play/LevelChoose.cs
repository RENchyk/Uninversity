using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChoose : MonoBehaviour
{
    public void ChooseLevel (string level)
    {
        PlayerPrefs.SetString ("Level", level);
        SceneManager.LoadScene (level);
    }
}
