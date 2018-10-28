using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class EncenderyApagar : MonoBehaviour
{



    public GameObject jumpscareObject;
  


    void Start()
    {



        jumpscareObject.SetActive(false);
      

    }



    void OnTriggerEnter(Collider player)
    {

        if (player.tag == "mesa")

        {

            jumpscareObject.SetActive(true);

            StartCoroutine(DestroyObject());

        }
     

    }

    IEnumerator DestroyObject()

    {

        yield return new WaitForSeconds(3f);

        Destroy(jumpscareObject);

        

    }

}