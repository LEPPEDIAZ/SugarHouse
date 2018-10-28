using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDePlatano : MonoBehaviour {


    public AudioSource tickSource;
    public GameObject jumpscareObject;



    void Start()
    {



        jumpscareObject.SetActive(false);
        tickSource = GetComponent<AudioSource>();


    }



    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Item")

        {

            jumpscareObject.SetActive(true);

            StartCoroutine(DestroyObject());
            tickSource.Play();

        }


    }

    IEnumerator DestroyObject()

    {

        yield return new WaitForSeconds(3f);

        Destroy(jumpscareObject);



    }

}
