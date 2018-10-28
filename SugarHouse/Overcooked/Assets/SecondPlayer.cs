using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondPlayer : MonoBehaviour {

    public float Speed = 1f;
    public float speed = 0.5f;
    public Text countText;
    public Text winText;
    private int count;
    public Transform carryLocation;
    Transform currentItem = null;
    //public float moveSpeed;
    Vector3 lookTo;
    Rigidbody rb;
    public GameObject Hands;
    public float sec = 14f;
    public Material Selected;
    public float clockwise = 1000.0f;
    public float counterClockwise = -5.0f;

    //Animator munecacorriendosinnada;

    // Use this for initialization
    void Start()
    {
        //moveSpeed = 1f;
        rb = GetComponent<Rigidbody>();
        //munecacorriendosinnada = GetComponent<Animator>();
        lookTo = new Vector3(0, 0, -1);
        RotateCharacter();
        count = 3;
        SetCountText();

        winText.text = "";

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
   
            transform.position += Vector3.left * Speed * Time.deltaTime ;
            //transform.rotation = Quaternion.LookRotation(transform.position);


        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;
            //transform.rotation = Quaternion.LookRotation(transform.position);


        }
        if (Input.GetKey(KeyCode.I))
        {
            transform.position += Vector3.forward * Speed * Time.deltaTime;
            //transform.rotation = Quaternion.LookRotation(transform.position);


        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.position += Vector3.back * Speed * Time.deltaTime;
            //transform.rotation = Quaternion.LookRotation(transform.position);
        }
        if (Input.GetKey(KeyCode.U))
        {
            transform.Rotate(0, Time.deltaTime * clockwise, 0);
        }
        else if (Input.GetKey(KeyCode.P))
        {
            transform.Rotate(0, Time.deltaTime * counterClockwise, 0);
        }
        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

        ///munecacorriendosinnada.SetFloat("Speed", lookTo.magnitude);


        if (Input.GetKeyDown(KeyCode.Space))

        {

            if (currentItem != null)

            {

                // remove as child

                currentItem.parent = null;



                //set position near player

                currentItem.position = transform.GetComponent<Renderer>().bounds.max;



                // release reference

                currentItem = null;


            }

        }
    }
    void RotateCharacter()
    {
        transform.forward = lookTo;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            count = count - 1;
            SetCountText();
            if (currentItem == null)

            {
                Debug.Log("No tiene item en mano");

                // take reference to that collided object

                currentItem = other.transform;



                // move it to carrying point

                currentItem.position = carryLocation.position;



                // make it as a child of player, so it moves along with player

                currentItem.parent = transform;
                count = count + 1;

            }
        }

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

        else
        {
            Debug.Log("Tiene el item " + currentItem.name);
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

    }

}

