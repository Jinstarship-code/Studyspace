using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max=0;
    int min=0;
    int guess=0;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();  
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number, don't tell me what is...");
        Debug.Log("The Highest number you can pick is : " + max);
        Debug.Log("The Lowest number you pick is : " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = higer, Push Down = lower, Push Enter = Correct");
        max = max + 1; 
    }
    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
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
            Debug.Log("Your Number is " + guess);
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Tell me if your number is higer or lower than " + guess);
    }
}
