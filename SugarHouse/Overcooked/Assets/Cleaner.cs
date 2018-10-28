using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour {
    public GameObject mesa;
    public GameObject comida;
    public GameObject mesados;
    public GameObject bananobasura;
    

	// Use this for initialization
	void Start () {
        mesa.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("cleaner"))
        {
            other.gameObject.SetActive(false);
            mesa.SetActive(true);
            Destroy(comida);
        }
       
        if (other.gameObject.CompareTag("Item"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("cleanertwo"))
        {

            other.gameObject.SetActive(false);
        }


    }
}
