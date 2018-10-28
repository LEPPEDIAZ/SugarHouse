using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class comidacocida : MonoBehaviour
{


    public AudioSource tickSource;
    public GameObject jumpscareObject;
    public GameObject warning;
    public GameObject ready;



    void Start()
    {



        jumpscareObject.SetActive(false);
        warning.SetActive(false);
        ready.SetActive(false);
        tickSource = GetComponent<AudioSource>();


    }



    void OnTriggerEnter(Collider player)
    {

        if (player.tag == "Player")

        {

            jumpscareObject.SetActive(true);

            StartCoroutine(DestroyObject());
            StartCoroutine(DestroyObject1());
            StartCoroutine(DestroyObject2());
            tickSource.Play();

        }
        if (player.tag == "estufa-segundacomida")

        {

            jumpscareObject.SetActive(true);

            StartCoroutine(DestroyObject());
            StartCoroutine(DestroyObject1());
            StartCoroutine(DestroyObject2());
            tickSource.Play();

        }
        if (player.tag == "warning")

        {

            //warning.SetActive(true);

           

        }


    }

    IEnumerator DestroyObject()

    {

        yield return new WaitForSeconds(2f);
        jumpscareObject.SetActive(true);
        Destroy(jumpscareObject);




    }
    IEnumerator DestroyObject1()

    {

        yield return new WaitForSeconds(2f);
        warning.SetActive(true);



    }
    IEnumerator DestroyObject2()

    {

        yield return new WaitForSeconds(2f);
        ready.SetActive(true);



    }

}
