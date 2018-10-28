using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadordeEstrellas : MonoBehaviour {

    public AudioSource tickSource;
    public Text countText;
    public Text winText;
    public GameObject destruir;
    public GameObject nuevaReceta;
    public GameObject Recetados;
    public GameObject destruir2;
    public GameObject destruir3;
    
    private int count;
    private int countwo;

    // Use this for initialization
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
        nuevaReceta.SetActive(false);
        Recetados.SetActive(false);
        count = 0;
        SetCountText();
        


        winText.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        if (count <= 0)
        {
            //Destroy(countText);
            

        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Listo"))
        {
            tickSource.Play();
            count = count + 1;
            SetCountText();
            StartCoroutine(DestroyObject());
            StartCoroutine(Receta());
        }
    }
    void SetCountText()
    {
        countText.text = ": " + count.ToString();
    }
    IEnumerator DestroyObject()

    {

        yield return new WaitForSeconds(5f);
        destruir.SetActive(true);
        Destroy(destruir);
        
       




    }
    IEnumerator Receta()

    {

        yield return new WaitForSeconds(1f);
        nuevaReceta.SetActive(true);
        Recetados.SetActive(true);





    }
}
