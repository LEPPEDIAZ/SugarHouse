using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguidor : MonoBehaviour {

    public GameObject mesa;
    public GameObject comida;
    public GameObject fuego;
    public AudioSource tickSource;

    // Use this for initialization
    void Start()
    {
        mesa.SetActive(false);
        tickSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("cocido"))
        {
            other.gameObject.SetActive(false);
            mesa.SetActive(true);
            Destroy(comida);
            Destroy(fuego);
            tickSource.Play();
        }
        if (other.gameObject.CompareTag("mesa"))
        {
            other.gameObject.SetActive(false);
            mesa.SetActive(true);
            Destroy(comida);
            Destroy(fuego);
            tickSource.Play();
        }
        if (other.gameObject.CompareTag("fuego"))
        {
            other.gameObject.SetActive(false);
            tickSource.Play();

        }


    }
}