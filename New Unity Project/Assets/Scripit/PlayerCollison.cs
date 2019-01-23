using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{

    public PlayerMovement movement;


    //Unity has special methods for collisons and how to make them work in the game
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstcale")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }

    }



    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
