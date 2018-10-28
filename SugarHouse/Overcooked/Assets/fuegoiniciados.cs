using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuegoiniciados : MonoBehaviour {


    public GameObject jumpscareObject;



    void Start()
    {



        jumpscareObject.SetActive(false);


    }



    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "estufa2")

        {

            StartCoroutine(DestroyObject());


        }


    }
    IEnumerator DestroyObject()

    {

        yield return new WaitForSeconds(8f);

        jumpscareObject.SetActive(true);



    }

}
