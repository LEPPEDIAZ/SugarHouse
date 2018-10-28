using UnityEngine;

using System.Collections;



// attach this script to your player gameobject

// player needs RigidBody2D and some 2D collider

// your collectible objects need: 2D Collider with [x] Trigger and gameobject tag: "Item"



public class DejarObjetos : MonoBehaviour

{


    public Transform carryLocation; // this is empty gameobject as a child of player, object will be carried on this position

    Transform currentItem = null;



    void Start()

    {



    }



    void Update()

    {




        // press fire to drop item, if carrying something

        if (Input.GetKeyDown(KeyCode.Space))

        {

            if (currentItem != null)

            {

                // remove as child

                currentItem.parent = null;



                //set position near player

                currentItem.position = transform.GetComponent<SpriteRenderer>().bounds.max;



                // release reference

                currentItem = null;

            }

        }

    }



    void OnTriggerEnter(Collider other)

    {

        // pickup if it has tag "Item" and we are not carrying anything

        if (other.CompareTag("Item") && currentItem == null)

        {

            // take reference to that collided object

            currentItem = other.transform;



            // move it to carrying point

            currentItem.position = carryLocation.position;



            // make it as a child of player, so it moves along with player

            currentItem.parent = transform;
           

        }

    }

}