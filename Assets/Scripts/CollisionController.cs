using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMoveMent;

    public ScoreController scoreController;
    

    void BounceFromaRacket(Collision2D c)
    {
        Vector3 ballPostion = this.transform.position;
        Vector3 racketPostion = c.gameObject.transform.position;


        float racketHeight = c.collider.bounds.size.y;

        float x;

        if(c.gameObject.name == "RacketPlayer1")
        {

            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPostion.y - racketPostion.y) / racketHeight;

        //Increaing Hit Counter  of Ball;
        this.ballMoveMent.IncreaeHitCounter();

        //Moving Ball On The new Hit Direction.
        this.ballMoveMent.MoveBall(new Vector2(x, y));
    }



    //Now Starting the Action on ANy Collision Of Ball

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            this.BounceFromaRacket(collision);

        }else if (collision.gameObject.name == "WallLeft")
        {
            Debug.Log("Wall LEft Hit");
             this.scoreController.GoalPlayer2();


            //Now Rest The Ball By Restating New CoRoutine.
            StartCoroutine(this.ballMoveMent.StartBall(true));


}else if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("Wall Right Hit");
            this.scoreController.GoalPlayer1();

            //Now Rest The Ball By Restating New CoRoutine.
            StartCoroutine(this.ballMoveMent.StartBall(false));
        }

    }
}
