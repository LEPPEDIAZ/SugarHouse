using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SegundoCounter : MonoBehaviour {

    public Text countText;
    public Text winText;
    public GameObject Plato;
    public GameObject Listo;
    public GameObject eliminar;
    public GameObject eliminardos;
    private int count;
    private int countwo;

    // Use this for initialization
    void Start()
    {
        count = 1;
        countwo = 3;
        SetCountText();
        Plato.SetActive(false);
        Listo.SetActive(false);


        winText.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        if (count <= 0)
        {
            //Destroy(countText);
            Plato.SetActive(true);
            Listo.SetActive(true);
            Destroy(eliminar);
            Destroy(eliminardos);

        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            count = count - 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "" + count.ToString();
    }
}

