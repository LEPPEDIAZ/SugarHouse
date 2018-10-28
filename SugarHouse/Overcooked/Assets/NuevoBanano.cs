using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoBanano : MonoBehaviour {

    public GameObject jumpscareObject;



    void Start()
    {



        jumpscareObject.SetActive(false);


    }



    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Banano")

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

