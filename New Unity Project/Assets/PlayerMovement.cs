using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rB;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    rB.AddForce(0, 200, 500);//Adds force to the x, y, z axis of the player
    //}

    // Update is called once per frame
    //FixUpdate is used when you are messing with the physics on Unity
    void FixUpdate()
    {
        //Time.deltaTime fixes the frame rates on the computer
        rB.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
