using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ContadordeElotes : MonoBehaviour {

    public Text countText;
    public Text winText;
    //public GameObject Plato;
    private int count;
    private int countwo;

    // Use this for initialization
    void Start()
    {
        count = 0;
        countwo = 3;
        SetCountText();
        //Plato.SetActive(false);


        winText.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        if (count <= 1)
        {
            //Destroy(countText);
            //Plato.SetActive(true);

        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EloteDespues"))
        {
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "" + count.ToString();
    }
}

