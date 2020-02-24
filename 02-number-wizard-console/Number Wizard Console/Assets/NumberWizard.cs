using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log(guess);
    }

    void StartGame()
    {

        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number, between " + min);
        Debug.Log("and a maximum of " + max);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Arrow UP = Higher, Arrow DOWN = Lower, Enter = Correct");

        max++;
        min--;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("You selected higher");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("You selected lower");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Correct, yay!");
            StartGame();
        }
    }
}
