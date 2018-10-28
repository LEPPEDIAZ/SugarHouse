using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContadordeCorazones : MonoBehaviour {



    public Text countText;
    public Text winText;
    public GameObject destruir;
    public GameObject nuevaReceta;
    public GameObject Recetados;
    public GameObject destruir2;
    public GameObject destruir3;

    private int count;
    private int countwo;
    [SerializeField] private string loadLevel;

    // Use this for initialization
    void Start()
    {
        nuevaReceta.SetActive(false);
        Recetados.SetActive(false);
        count = 3;
        SetCountText();



        winText.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        if (count <= -3)
        {
            //Destroy(countText);
            SceneManager.LoadScene(loadLevel);


        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            count = count - 1;
            SetCountText();
            StartCoroutine(DestroyObject());
            StartCoroutine(Receta());
        }
        if (other.gameObject.CompareTag("EloteDespues"))
        {
            count = count - 1;
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
