using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    // configuration parameters, consider SO
    [SerializeField] Text guessText;
    [SerializeField] int max, min;

    // private instance variables for state
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = max + 1;
        guess = max / 2;
        guessText.text = guess.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius!");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
}