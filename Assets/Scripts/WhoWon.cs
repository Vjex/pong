using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhoWon : MonoBehaviour
{

    string player1Score;
    string player2Score;
    // Start is called before the first frame update
    void Start()
    {

        this.player1Score = GameObject.Find("ScorePlayer1").GetComponent<Text>().text;
        this.player1Score = GameObject.Find("ScorePlayer2").GetComponent<Text>().text;


        int player1ScoreInt = int.Parse(this.player1Score);
        int player2ScoreInt = int.Parse(this.player2Score);

        Debug.Log(player1ScoreInt.ToString()+ " Second :" + player2ScoreInt.ToString());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
