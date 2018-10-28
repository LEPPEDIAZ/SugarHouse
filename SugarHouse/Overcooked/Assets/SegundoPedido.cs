using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoPedido : MonoBehaviour {

    public GameObject jumpscareObject;
    // Use this for initialization
    void Start () {
        jumpscareObject.SetActive(false);
        StartCoroutine(DestroyObject());
    }
	
	// Update is called once per frame
    IEnumerator DestroyObject()

    {
        jumpscareObject.SetActive(false);
        yield return new WaitForSeconds(4f);
        jumpscareObject.SetActive(true);
      




    }
}
