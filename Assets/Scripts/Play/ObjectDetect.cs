using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectDetect : MonoBehaviour
{
    public static float oddTime = 0f, endTime, tempTime, pauseTime1, pauseTime2, pauseTime3;
    public Text timer;
    private float checkTime;

    void Update ()
    {
        if (!MovePlayer.isActive && !Player.lose && !Player.pause)
        {
            tempTime = Time.time - oddTime;
            timer.text = Mathf.RoundToInt (tempTime).ToString ();
        }
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Player.instance.PlayerLose ();
        }else if (other.gameObject.tag == "Boost")
        {
            Player.instance.BuffBoost ();
        } else if (other.gameObject.tag == "Broken")
        {
            other.gameObject.GetComponent <Rigidbody2D> ().gravityScale = 0.2f;
        } else if (other.gameObject.tag == "EndItem" && !Player.lose)
        {
            switch (PlayerPrefs.GetString ("Level"))
            {
                case "11":
                    checkTime = 2.75f;
                    break;
                case "12":
                    checkTime = 4f;
                    break;
                case "13":
                    checkTime = 6f;
                    break;
                case "14":
                    checkTime = 7.5f;
                    break;
                case "21":
                    checkTime = 6f;
                    break;
                case "22":
                    checkTime = 10f;
                    break;
                case "23":
                    checkTime = 9f;
                    break;
                case "24":
                    checkTime = 12f;
                    break;
                case "31":
                    checkTime = 3f;
                    break;
                case "32":
                    checkTime = 5f;
                    break;
                case "33":
                    checkTime = 9f;
                    break;
                case "34":
                    checkTime = 12f;
                    break;
            }
            endTime = Time.time - oddTime;
            Debug.Log (endTime);
            if (endTime <= checkTime)
            {
                PlayerPrefs.SetInt (PlayerPrefs.GetString ("Level"), 3);
            } else if (endTime > checkTime && endTime <= checkTime + checkTime/2)
            {
                if (PlayerPrefs.GetInt (PlayerPrefs.GetString ("Level")) != 3)
                {
                    PlayerPrefs.SetInt (PlayerPrefs.GetString ("Level"), 2);
                }
            } else if (endTime > checkTime + checkTime)
            {
                if (PlayerPrefs.GetInt (PlayerPrefs.GetString ("Level")) != 2 && PlayerPrefs.GetInt (PlayerPrefs.GetString ("Level")) != 3)
                PlayerPrefs.SetInt (PlayerPrefs.GetString ("Level"), 1);
            }
            SceneManager.LoadScene ("EndLevel");
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Boost")
        {
            Player.instance.BuffBoost ();
        }
    }

    void OnTriggerExit2D (Collider2D other)
    {
        if (other.gameObject.tag == "Boost")
        {
            Player.instance.BuffEndBoost ();
            other.gameObject.tag = "Untagged";
        }
    }
}
