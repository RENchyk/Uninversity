using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EndStar : MonoBehaviour
{
    public GameObject star1, star2, star3;

    void Awake ()
    {
        StartCoroutine (StarScale ());
    }

    IEnumerator StarScale ()
    {
        if (PlayerPrefs.GetInt (PlayerPrefs.GetString ("Level")) == 1)
        {
            StarMacros (star1);
            yield return new WaitForSeconds (0.5f);
            star1.transform.localScale = new Vector3 (1f, 1f, 1f);
            } else if (PlayerPrefs.GetInt (PlayerPrefs.GetString ("Level")) == 0)
            {
                star1.GetComponent <SpriteRenderer> ().color = new Color (0f, 0f, 0f, 255f);
            }
        if (PlayerPrefs.GetInt (PlayerPrefs.GetString ("Level")) == 2)
        {
            StarMacros (star1);
            yield return new WaitForSeconds (0.5f);
            star1.transform.localScale = new Vector3 (1f, 1f, 1f);
            StarMacros (star2);
            yield return new WaitForSeconds (0.5f);
            star2.transform.localScale = new Vector3 (1f, 1f, 1f);
            } else if (PlayerPrefs.GetInt (PlayerPrefs.GetString ("Level")) == 0)
            {
                star1.GetComponent <SpriteRenderer> ().color = new Color (0f, 0f, 0f, 255f);
                star2.GetComponent <SpriteRenderer> ().color = new Color (0f, 0f, 0f, 255f);
            }
        if (PlayerPrefs.GetInt (PlayerPrefs.GetString ("Level")) == 3)
        {
            StarMacros (star1);
            yield return new WaitForSeconds (0.5f);
            star1.transform.localScale = new Vector3 (1f, 1f, 1f);
            StarMacros (star2);
            yield return new WaitForSeconds (0.5f);
            star2.transform.localScale = new Vector3 (1f, 1f, 1f);
            StarMacros (star3);
            yield return new WaitForSeconds (0.5f);
            star3.transform.localScale = new Vector3 (1f, 1f, 1f);
        } else if (PlayerPrefs.GetInt (PlayerPrefs.GetString ("Level")) == 0)
        {
            star1.GetComponent <SpriteRenderer> ().color = new Color (0f, 0f, 0f, 255f);
            star2.GetComponent <SpriteRenderer> ().color = new Color (0f, 0f, 0f, 255f);
            star3.GetComponent <SpriteRenderer> ().color = new Color (0f, 0f, 0f, 255f);
        }
    }

    void StarMacros (GameObject star)
    {
        star.GetComponent <SpriteRenderer> ().color = new Color (255f, 255f, 255f, 255f);
        star.transform.localScale = new Vector3 (1.5f, 1.5f, 1f);
    }
}
