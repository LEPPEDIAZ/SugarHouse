using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoquePersonajes : MonoBehaviour
{

    public GameObject jumpscareObject;
   



    void Start()
    {



        jumpscareObject.SetActive(false);



    }



    void OnTriggerEnter(Collider player)
    {

        if (player.tag == "Player")

        {

            jumpscareObject.SetActive(true);



        }

    }

}