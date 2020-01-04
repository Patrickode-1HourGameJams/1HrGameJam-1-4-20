using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        BitClicked.OnBitClicked += CheckLevelClear;
    }

    private void OnDisable()
    {
        BitClicked.OnBitClicked -= CheckLevelClear;
    }

    private void CheckLevelClear()
    {

    }
}
