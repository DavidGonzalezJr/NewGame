using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    //Stores 3 floats
    public Vector3 offest;


    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        //For the camera to follow the player's position
        transform.position = player.position + offest;
    }
}
