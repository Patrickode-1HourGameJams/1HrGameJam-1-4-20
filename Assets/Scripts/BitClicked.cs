using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitClicked : MonoBehaviour
{
    private bool isClicked;

    private void OnMouseDown()
    {
        if (!isClicked)
        {
            isClicked = true;

        }
    }
}
