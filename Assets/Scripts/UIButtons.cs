using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    public void Play ()
    {
        SceneManager.LoadScene ("Seasons");
    }

    public void Shop ()
    {
        SceneManager.LoadScene ("Shop");
    }

    public void Authors ()
    {
        SceneManager.LoadScene ("Authors");
    }

    public void Season1 ()
    {
        SceneManager.LoadScene ("Season1");
    }

    public void Season2 ()
    {
        SceneManager.LoadScene ("Season2");
    }

    public void Season3 ()
    {
        SceneManager.LoadScene ("Season3");
    }
}
