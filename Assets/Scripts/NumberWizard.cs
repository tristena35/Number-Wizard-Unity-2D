using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    [SerializeField] TextMeshProUGUI triesText;

    int guess;
    int triesRemaining = 10;

    // Use this for initialization
    void Start ()
    {
        StartGame();
    }

    // Change Guess
    void takeGuess(){
        guess = (min + max) / 2;
        // GuessingText is on the GUI
        guessText.text = guess.ToString();
    }
	
    // Decrease number of tries
    void tryToGuess(){
        triesRemaining -= 1;
        triesText.text = triesRemaining.ToString();
    }

    // Main Function 
    void StartGame()
    {
        takeGuess();
        tryToGuess();
        max += 1;
    }

    public void OnPressHigher(){
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower(){
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        tryToGuess();
        takeGuess();
    }

}