using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyutec : MonoBehaviour
{
    public bool mouseOver = true;
    float x;
    float y;
    float bx;
    float by;
    void Start()
    {
        bx = gameObject.transform.localScale.x;
        by = gameObject.transform.localScale.y;
    }
    void Update()
    {
        x = gameObject.transform.localScale.x;
        y = gameObject.transform.localScale.y;
    }
    void OnMouseOver()
    {
        mouseOver = true;
        if (gameObject.name == "sehpa" && x < 1 && y < 1)
        {
            gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 1);
        }
        Debug.Log("Mouse is over GameObject.");
    }
    void OnMouseExit()
    {
        mouseOver = false;
        if (gameObject.name == "kafa")
        {
            gameObject.transform.localScale = new Vector3(bx, by, 1);
        }
        Debug.Log("Mouse is exit GameObject.");

    }
}
