using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject sound_on, sound_off, vibro_on, vibro_off;
    public static float pauseTime1, pauseTime2;
    private bool pauseBlock;

    void Awake ()
    {
        if (PlayerPrefs.GetString ("Sound") == "no") {
            Sound (true);
        } else {
            Sound (false);
        }
        if (PlayerPrefs.GetString ("Vibro") == "no") {
            Vibro (true);
        } else {
            Vibro (false);
        }
        pauseBlock = false;
    }

    void OnMouseDown () {
        transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
    }

    void OnMouseUp () {
        transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
    }

    void OnMouseUpAsButton ()
    {
        switch (gameObject.name)
        {
            case "Play":
                SceneManager.LoadScene ("Seasons");
                break;
            case "Restart":
                SceneManager.LoadScene (PlayerPrefs.GetString ("Level"));
                break;
            case "Back":
                SceneManager.LoadScene ("Menu");
                break;
            case "Back To Seasons":
                SceneManager.LoadScene ("Seasons");
                break;
            case "Menu":
                SceneManager.LoadScene ("Menu");
                break;
            case "Pause":
                if (!Player.lose && !Player.pause && !MovePlayer.isActive)
                {
                    pauseTime1 = Time.time;
                    Player.instance.PlayerPause ();
                } else if (!Player.lose && !pauseBlock)
                {
                    pauseTime2 = Time.time;
                    ObjectDetect.oddTime += pauseTime2 - pauseTime1;
                    Player.instance.PlayerUnpause ();
                }
                break;
            case "Next":
                switch (PlayerPrefs.GetString ("Level"))
                {
                    case "11":
                        SceneManager.LoadScene ("12");
                        PlayerPrefs.SetString ("Level", "12");
                        break;
                    case "12":
                        SceneManager.LoadScene ("13");
                        PlayerPrefs.SetString ("Level", "13");
                        break;
                    case "13":
                        SceneManager.LoadScene ("14");
                        PlayerPrefs.SetString ("Level", "14");
                        break;
                    case "14":
                        SceneManager.LoadScene ("Season1");
                        break;
                    case "21":
                        SceneManager.LoadScene ("22");
                        PlayerPrefs.SetString ("Level", "22");
                        break;
                    case "22":
                        SceneManager.LoadScene ("23");
                        PlayerPrefs.SetString ("Level", "23");
                        break;
                    case "23":
                        SceneManager.LoadScene ("24");
                        PlayerPrefs.SetString ("Level", "24");
                        break;
                    case "24":
                        SceneManager.LoadScene ("Season2");
                        break;
                    case "31":
                        SceneManager.LoadScene ("32");
                        PlayerPrefs.SetString ("Level", "32");
                        break;
                    case "32":
                        SceneManager.LoadScene ("33");
                        PlayerPrefs.SetString ("Level", "33");
                        break;
                    case "33":
                        SceneManager.LoadScene ("34");
                        PlayerPrefs.SetString ("Level", "34");
                        break;
                    case "34":
                        SceneManager.LoadScene ("Season3");
                        break;
                }
                break;
            case "Setting":
                SceneManager.LoadScene ("Setting");
                break;
            case "Sound On":
                PlayerPrefs.SetString ("Sound", "yes");
                transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
                Sound (false);
                break;
            case "Sound Off":
                PlayerPrefs.SetString ("Sound", "no");
                transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
                Sound (true);
                break;
            case "Vibro On":
                PlayerPrefs.SetString ("Vibro", "yes");
                transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
                Vibro (false);
                break;
            case "Vibro Off":
                PlayerPrefs.SetString ("Vibro", "no");
                transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
                Vibro (true);
                break;
        }
    }

    void Sound (bool sound)
    {
        if (sound)
        {
            sound_on.SetActive (true);
            sound_off.SetActive (false);
        } else if (!sound)
        {
            sound_on.SetActive (false);
            sound_off.SetActive (true);
        }
    }

    void Vibro (bool vibration)
    {
        if (vibration)
        {
            vibro_on.SetActive (true);
            vibro_off.SetActive (false);
        } else if (!vibration)
        {
            vibro_on.SetActive (false);
            vibro_off.SetActive (true);
        }
    }
}