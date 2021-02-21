using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float movementSpeed;
    public float extraSppedPerHit;
    public float maxExtraSpeed;


    int hitCounter = 0;


    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine(this.StartBall());
    }



    //change Ball Position and its valocity/Speed  ON Every Goal.
    void PositionBall(bool isStartingPlayer1)
    {

        //This Will Reset The Velocity Of BAll BAck To Zero.
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);


        //Change Ball Postion
        if (isStartingPlayer1)
        {
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 12);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 12);

        }


    }


    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {

        //Now Initially First Setting Initial Postion Of Ball Before Starting The Game.
        this.PositionBall(isStartingPlayer1);

        this.hitCounter = 0;

        yield return new WaitForSeconds(2);

        if (isStartingPlayer1)
        {
            this.MoveBall(new Vector2(-1, 0));
        }
        else
        {
            this.MoveBall(new Vector2(1, 0));

        }
    }


    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;


        float speed = this.movementSpeed + this.hitCounter * this.extraSppedPerHit;

        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();


        //rigidbody2D.velocity = dir * speed * Time.deltaTime;
        rigidbody2D.velocity = dir * speed ;

    }


    public void IncreaeHitCounter()
    {
        if(this.hitCounter * this.extraSppedPerHit <= this.maxExtraSpeed)
        {
            this.hitCounter++;
        }
    }

  
}
