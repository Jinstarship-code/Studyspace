using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max= 1000;
        int min = 1;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number, don't tell me what is...");
        Debug.Log("The Highest number you can pick is : "+max);
        Debug.Log("The Lowest number you pick is : "+min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = higer, Push Down = lower, Push Enter = Correct");
    
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
            Debug.Log("Up Arrow key was pressed.");
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            Debug.Log("Down Arrow key was pressed.");
        else if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("Enter(Return) key was pressed.");
    }
}
