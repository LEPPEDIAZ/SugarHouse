using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Mantener : MonoBehaviour
{



    public GameObject jumpscareObject;



    void Start()
    {



        jumpscareObject.SetActive(false);


    }



    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Item")

        {

            StartCoroutine(DestroyObject());


        }


    }
    IEnumerator DestroyObject()

    {

        yield return new WaitForSeconds(3f);

        jumpscareObject.SetActive(true);



    }

}