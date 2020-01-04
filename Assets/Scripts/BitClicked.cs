using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitClicked : MonoBehaviour
{
    private bool isClicked;

    public SpriteRenderer rend;
    public delegate void ClickAction();
    public static event ClickAction OnBitClicked;

    private void OnMouseDown()
    {
        if (!isClicked)
        {
            isClicked = true;
            rend.color = Color.black;
            OnBitClicked?.Invoke();
        }
    }
}
