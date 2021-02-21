using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2 : MonoBehaviour
{
    public float movementSpeed;

    //this anothe Update Method on Unity Which Will Be Called Automatically but for a fixed no of Times in a minute for Eg (60 times ina minute).
    private void FixedUpdate()
    {
        //To Get And Change Setting of Axis Raws 
        // First Go to Edit ==> project Settings ==> Input Manager ==>  Axis ==> There Will Be All Diffrent Axis (18 By Default ).

        //Note * : We Can Add Our Own Axis Destials By Just Changing  Total Number and then change the new added Axis at last ("Cancel" Name By Defalt) according to your requirement.
        //Note 2 : No Axis Name Should be Same.
        float v = Input.GetAxisRaw("Vertical2");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;



    }
}
