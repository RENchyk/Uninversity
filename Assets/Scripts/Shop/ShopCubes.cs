using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopCubes : MonoBehaviour
{
    public GameObject cubes;
    private Vector3 offset;
    private float _lockedYPos;

    void Update ()
    {
        if (cubes.transform.position.x > 0f) {
            cubes.transform.position = Vector3.MoveTowards (cubes.transform.position, new Vector3 (0f, cubes.transform.position.y, cubes.transform.position.z), Time.deltaTime * 13f);
        }else if (cubes.transform.position.x < -6f) {
            cubes.transform.position = Vector3.MoveTowards (cubes.transform.position, new Vector3 (-6f, cubes.transform.position.y, cubes.transform.position.z), Time.deltaTime * 13f);
        }
    }

    void OnMouseDown ()
    {
        _lockedYPos = 0;
        offset = cubes.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));
    }

    void OnMouseDrag ()
    {
        Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
        curPosition.y = _lockedYPos;
        cubes.transform.position = curPosition;
    }
}
