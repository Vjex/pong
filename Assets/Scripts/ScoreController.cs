using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{

    //Scores od Both The Player.
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;


    //Max Score to iin The GAme .
    public int  scoreToWin;


    //Text Element of Scoree Of Both The Players.
    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;


    private void Update()
    {
        //Checking If Any Player Won The GAme 
        if(this.scorePlayer1 >= this.scoreToWin || this.scorePlayer2 >= this.scoreToWin)
        {
            Debug.Log("Game Won");

            //Now Redirect To Game Over Screen.
            SceneManager.LoadScene("GameOver");

        }
    }

    

    private void FixedUpdate()
    {
        //Updating UI /Score Text OF the Players.


        //Getting Assigned Text UI Element Of Player 1

        Text textViewScoreOfPlayer1 = this.scoreTextPlayer1.GetComponent<Text>();
        textViewScoreOfPlayer1.text = this.scorePlayer1.ToString();


        //Getting Assigned Text UI Element Of Player 2
        Text textViewScoreOfPlayer2 = this.scoreTextPlayer2.GetComponent<Text>();
        textViewScoreOfPlayer2.text = this.scorePlayer2.ToString();


    }


    //Increase scroe of Player 1;
    public void GoalPlayer1()
    {
        this.scorePlayer1++;
    } 

    //Increase scroe of Player 2;
    public void GoalPlayer2()
    {
        this.scorePlayer2++;
    }



    //Method To Check Who Won The Game

    public int WhoWon()
    {
        return scorePlayer1 > scorePlayer2 ? 1 : 2;
    }


}
