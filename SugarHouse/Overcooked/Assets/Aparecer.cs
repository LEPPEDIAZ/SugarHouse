using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Aparecer : MonoBehaviour
{



    public GameObject warning;



    void Start()
    {



        warning.SetActive(false);
        StartCoroutine(DestroyObject());


    }



    IEnumerator DestroyObject()

    {

        yield return new WaitForSeconds(5f);
        warning.SetActive(true);




    }

}
