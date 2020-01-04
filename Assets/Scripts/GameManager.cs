using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int playerScore = 0;
    private int bitsClicked = 0;
    private List<GameObject> bits = new List<GameObject>();

    public GameObject bitPrefab;
    public Text scoreText;

    private void OnEnable()
    {
        BitClicked.OnBitClicked += CheckLevelClear;
    }

    private void OnDisable()
    {
        BitClicked.OnBitClicked -= CheckLevelClear;
    }

    private void Start()
    {
        ResetAndGenerate();
    }

    /// <summary>
    /// Whenever a bit is clicked, add one to an internal counter, and 
    /// generate a new one if greater than 4, the max number of bits.
    /// Update score whenever a new level is generated
    /// </summary>
    private void CheckLevelClear()
    {
        bitsClicked++;

        if (bitsClicked >= 4)
        {
            bitsClicked = 0;
            UpdateScore();
            ResetAndGenerate();
        }
    }

    /// <summary>
    /// Removes all the bits and adds new ones
    /// </summary>
    private void ResetAndGenerate()
    {
        while (bits.Count >= 1)
        {
            GameObject bitToDestroy = bits[0];
            bits.RemoveAt(0);
            Destroy(bitToDestroy);
        }

        for (int i = 0; i < 4; i++)
        {
            GameObject newBit = Instantiate
                (
                bitPrefab,
                new Vector3(Random.Range(-6f, 6f), Random.Range(-4.5f, 4.5f)),
                Quaternion.identity
                );
            bits.Add(newBit);
        }
    }

    /// <summary>
    /// Add one to the player's score, internally and externally via the UI
    /// </summary>
    private void UpdateScore()
    {
        playerScore++;
        scoreText.text = "Score: " + playerScore;
    }
}
