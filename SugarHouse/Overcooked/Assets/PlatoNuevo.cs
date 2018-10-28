using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatoNuevo : MonoBehaviour {

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

            StartCoroutine(DestroyObject());
      
        }
        if (player.tag == "warning")

        {

            //warning.SetActive(true);



        }


    }

    IEnumerator DestroyObject()

    {

        yield return new WaitForSeconds(12f);
        jumpscareObject.SetActive(true);
        Destroy(jumpscareObject);




    }

}
