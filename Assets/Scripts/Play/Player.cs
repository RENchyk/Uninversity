using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public static bool lose, pause, isBoosting;
    private bool isJumping, noVibro;
    public GameObject player, but_restart, but_menu, whiter;
    private float force = 310f;
    public Transform groundCheck;
    public LayerMask whatIsGround;

    private void Awake ()
    {
        if (instance != null) {
            instance = null;
            instance = this;
        } else {
            instance = this;
        }
        but_restart.SetActive (false);
        but_menu.SetActive (false);
        lose = false;
        pause = false;
        noVibro = false;
        isBoosting = false;
    }

    void FixedUpdate ()
    {
        if (!isBoosting)
        {
            isJumping = !Physics2D.OverlapCircle (groundCheck.position, 0.235f, whatIsGround);
        } else
        {
            player.GetComponent<Rigidbody2D> ().velocity = new Vector2 (5f, 0f);
        }
    }

    public void PlayerLose ()
    {
        lose = true;
        but_restart.SetActive (true);
        but_menu.SetActive (true);
        if (PlayerPrefs.GetString ("Vibro") != "no" && !noVibro)
        {
            Handheld.Vibrate ();
            noVibro = true;
        }
    }

    public void PlayerPause ()
    {
        pause = true;
        player.GetComponent<Rigidbody2D> ().gravityScale = 0f;
        player.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezePosition | RigidbodyConstraints2D.FreezeRotation;
        but_restart.SetActive (true);
        but_menu.SetActive (true);
        whiter.SetActive (true);
    }

    public void PlayerUnpause ()
    {
        pause = false;
        player.GetComponent<Rigidbody2D> ().gravityScale = 1f;
        player.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;
        but_restart.SetActive (false);
        but_menu.SetActive (false);
        whiter.SetActive (false);
    }

    public void BuffBoost ()
    {
        if (!lose)
        {
            isJumping = true;
            isBoosting = true;
        }
    }

    public void BuffEndBoost ()
    {
        if (!lose)
        {
            isBoosting = false;
            isJumping = false;
        }
    }

    void OnMouseDown ()
    {
        if (!lose)
        {
            if (!isJumping)
            {
                player.GetComponent <Rigidbody2D> ().AddRelativeForce (player.transform.up * force);
            }
        }
    }
}
