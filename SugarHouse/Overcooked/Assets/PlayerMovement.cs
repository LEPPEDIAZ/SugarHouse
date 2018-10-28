using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour {
    public float Speed = 1f;
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
   
    //Animator munecacorriendosinnada;

    // Use this for initialization
    void Start () {
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
    void Update () {
     

        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        lookTo = new Vector3(movHorizontal, 0, movVertical);
        if (lookTo.magnitude > 0.1f)
        {
            Vector3 moveTo = lookTo * Speed * Time.deltaTime;
            transform.position = transform.position + moveTo;
            RotateCharacter();
        }
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
 
        else {
            Debug.Log("Tiene el item " + currentItem.name);
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
       
    }

}
