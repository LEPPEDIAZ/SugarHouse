using UnityEngine;
using System.Collections;

public class HoldItems : MonoBehaviour
{
    

    public AudioSource tickSource;
    public float speed = 10;
    public bool canHold = true;
    public GameObject ball;
    public Transform guide;

    void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!canHold)
                throw_drop();
            else
                Pickup();
        }//mause If

        if (!canHold && ball)
            ball.transform.position = guide.position;

    }//update

    //We can use trigger or Collision
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Item")
            if (!ball) // if we don't have anything holding
                ball = col.gameObject;
                tickSource.Play();
        if (col.gameObject.tag == "PickUp")
            if (!ball) // if we don't have anything holding
                ball = col.gameObject;
                tickSource.Play();
        if (col.gameObject.tag == "Limpiador")
            if (!ball) // if we don't have anything holding
                ball = col.gameObject;
                tickSource.Play();
        if (col.gameObject.tag == "Extinguidor")
            if (!ball) // if we don't have anything holding
                ball = col.gameObject;
                tickSource.Play();
        if (col.gameObject.tag == "Elote")
            if (!ball) // if we don't have anything holding
                ball = col.gameObject;
                tickSource.Play();
        if (col.gameObject.tag == "EloteDespues")
            if (!ball) // if we don't have anything holding
                ball = col.gameObject;
                tickSource.Play();
        if (col.gameObject.tag == "manzana")
            if (!ball) // if we don't have anything holding
                ball = col.gameObject;
                tickSource.Play();
        if (col.gameObject.tag == "Listo")
            if (!ball) // if we don't have anything holding
                ball = col.gameObject;
                tickSource.Play();
        if (col.gameObject.tag == "Plato")
            if (!ball) // if we don't have anything holding
                ball = col.gameObject;
        tickSource.Play();

    }


    //We can use trigger or Collision
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Item")
        {
            if (canHold)
                ball = null;
        }
        if (col.gameObject.tag == "PickUp")
        {
            if (canHold)
                ball = null;
        }
        if (col.gameObject.tag == "Limpiador")
        {
            if (canHold)
                ball = null;
        }
        if (col.gameObject.tag == "Extinguidor")
        {
            if (canHold)
                ball = null;
        }
        if (col.gameObject.tag == "Elote")
        {
            if (canHold)
                ball = null;
        }
        if (col.gameObject.tag == "EloteDespues")
        {
            if (canHold)
                ball = null;
        }
        if (col.gameObject.tag == "manzana")
        {
            if (canHold)
                ball = null;
        }
        if (col.gameObject.tag == "Listo")
        {
            if (canHold)
                ball = null;
        }
        if (col.gameObject.tag == "Plato")
        {
            if (canHold)
                ball = null;
        }

    }


    private void Pickup()
    {
        if (!ball)
            return;

        //We set the object parent to our guide empty object.
        ball.transform.SetParent(guide);

        //Set gravity to false while holding it
        ball.GetComponent<Rigidbody>().useGravity = false;

        //we apply the same rotation our main object (Camera) has.
        ball.transform.localRotation = transform.rotation;
        //We re-position the ball on our guide object 
        ball.transform.position = guide.position;

        canHold = false;
    }

    private void throw_drop()
    {
        if (!ball)
            return;

        //Set our Gravity to true again.
        ball.GetComponent<Rigidbody>().useGravity = true;
        // we don't have anything to do with our ball field anymore
        ball = null;
        //Apply velocity on throwing
        guide.GetChild(0).gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;

        //Unparent our ball
        guide.GetChild(0).parent = null;
        canHold = true;
    }
}//class

