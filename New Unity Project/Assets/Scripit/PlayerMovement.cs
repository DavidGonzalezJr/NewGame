using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variable that is used to referance the Rigidbody component of the player behaviour
    public Rigidbody rB;

    public float fowardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    //void Start()
    //{
    //    rB.AddForce(0, 200, 500);
    //}

    // Update is called once per frame
    //It's marked FixedUpdate() because I'm using it to work with the physics of Unity
    void FixedUpdate()
    {
        //Add a foward force
        rB.AddForce(0, 0, fowardForce * Time.deltaTime); //AddForce() handles the x, y, and z axis of the player's movement

        if (Input.GetKey("d"))
        {
            rB.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rB.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rB.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

    }
}
