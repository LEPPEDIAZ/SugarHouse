using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buses : MonoBehaviour {
    public float Speed = 1f;
    public float moveSpeed;
    Vector3 lookTo;
    Rigidbody rb;
    public GameObject Hands;
    public float sec = 14f;
    public Material Selected;
    //Animator munecacorriendosinnada;
    // Use this for initialization
    void Start()
    {
        moveSpeed = 1f;
        //rb = GetComponent<Rigidbody>();
        //munecacorriendosinnada = GetComponent<Animator>();
        lookTo = new Vector3(0, -1, 0);


    }



    // Update is called once per frame
    void Update()
    {

        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");
        lookTo = new Vector3(movVertical, 0);
        if (lookTo.magnitude > 0.1f)
        {
            Vector3 moveTo = lookTo * Speed * Time.deltaTime;
            transform.position = transform.position + moveTo;

        }
        ///munecacorriendosinnada.SetFloat("Speed", lookTo.magnitude);

    }

    void OnTriggerEnter(Collider other)
    {
        /*
        
        if (other.gameObject.CompareTag("mesa"))
        {
            other.gameObject.SetActive(false);
           
            Material[] materials = other.gameObject.GetComponent<Renderer>().materials;
            materials[0] = Selected;
            other.gameObject.GetComponent<Renderer>().materials = materials;
           

        }
        */

        if (other.gameObject.CompareTag("pot1"))
        {
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("pot1"))
        {
            other.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("mesa"))
        {
            other.gameObject.SetActive(false);
        }
    }
}


