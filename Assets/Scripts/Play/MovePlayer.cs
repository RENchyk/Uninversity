using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    public Animator move;
    public Rigidbody2D play;
    public Camera cam;
    public GameObject tapToPlay, bg;
    public static bool isActive;

    void Awake ()
    {
        move = move.GetComponent <Animator> ();
        play = GetComponent <Rigidbody2D> ();
        tapToPlay.SetActive (true);
        isActive = true;
    }

    void Update ()
    {
        if (Player.lose) {
            move.SetInteger("state", 2);
        }
        if (player.transform.position.x > 0)
        {
            cam.transform.position = new Vector3 (player.transform.position.x, cam.transform.position.y, cam.transform.position.z);
            bg.transform.position = new Vector3 (6.5f + player.transform.position.x - player.transform.position.x / 3f, bg.transform.position.y, bg.transform.position.z);
        }
        if (player.transform.position.y < -5)
        {
            Player.instance.PlayerLose ();
        }
        if (!Player.lose && !Player.pause && !isActive && !Player.isBoosting)
        {
            Vector3 acceleration = Input.acceleration;
            Vector2 minPos = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));
            Vector2 maxPos = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));
            if (player.transform.position.x < maxPos.x - 0.35f && player.transform.position.x > minPos.x + 0.35f)
            {
                player.transform.Translate (Input.acceleration.x/7f, 0, 0);
            } else
            {
                if (player.transform.position.x > maxPos.x - 0.35f)
                {
                    if (acceleration.x < 0)
                    {
                        player.transform.Translate (Input.acceleration.x/7f, 0, 0);
                    }
                } else if (player.transform.position.x < minPos.x + 0.35f)
                {
                    if (acceleration.x > 0)
                    {
                        player.transform.Translate (Input.acceleration.x/7f, 0, 0);
                    }
                }
            }
        }
    }

    void OnMouseDown ()
    {
        if (isActive == true)
        {
            tapToPlay.SetActive (false);
            isActive = false;
            ObjectDetect.oddTime = Time.time;
        }
    }
}
