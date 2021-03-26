using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    // Config params
    [Range(0.1f,10f)] [SerializeField] float gameSpeed=1f;
    [SerializeField] int pointsPerBlockDestoryed=83;

    //State Variables
    [SerializeField] int currentScore = 0;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestoryed;

    }

}
