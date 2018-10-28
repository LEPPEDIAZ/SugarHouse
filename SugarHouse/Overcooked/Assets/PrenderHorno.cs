using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrenderHorno : MonoBehaviour {

    public GameObject jumpscareObject;
    public GameObject warning;
    public GameObject ready;



    void Start()
    {



        jumpscareObject.SetActive(false);
        warning.SetActive(false);
        ready.SetActive(false);


    }



    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "mesa")

        {

            jumpscareObject.SetActive(true);

            StartCoroutine(DestroyObject());
            StartCoroutine(DestroyObject1());
            StartCoroutine(DestroyObject2());

        }
        if (col.gameObject.tag == "Item")

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
    IEnumerator DestroyObject1()

    {

        yield return new WaitForSeconds(8f);
        warning.SetActive(true);



    }
    IEnumerator DestroyObject2()

    {

        yield return new WaitForSeconds(4f);
        ready.SetActive(true);



    }

}

