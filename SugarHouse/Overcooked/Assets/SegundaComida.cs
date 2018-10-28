using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class SegundaComida : MonoBehaviour
{



    public GameObject jumpscareObject;
    public GameObject warning;
    public GameObject ready;



    void Start()
    {



        jumpscareObject.SetActive(false);
        warning.SetActive(false);
        ready.SetActive(false);


    }



    void OnTriggerEnter(Collider player)
    {

        if (player.tag == "Item")

        {

            jumpscareObject.SetActive(true);

            StartCoroutine(DestroyObject());
            StartCoroutine(DestroyObject1());
            StartCoroutine(DestroyObject2());

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
