using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiempodeReceta : MonoBehaviour
{
    public int timeLeft = 500;
    public Text countdownText;
    public GameObject Perdiste;
    public GameObject perdistedos;
    public GameObject Eliminar;
    public GameObject check;
    public GameObject Pedidos;
    public GameObject Plato;

    // Use this for initialization
    void Start()
    {
        Perdiste.SetActive(false);
        perdistedos.SetActive(false);
        Pedidos.SetActive(false);
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("" + timeLeft);

        if (timeLeft <= 0)
        {
            Perdiste.SetActive(true);
            perdistedos.SetActive(true);
            Pedidos.SetActive(true);
            StopCoroutine("LoseTime");
            Destroy(Eliminar);
            Destroy(check);
            Destroy(Plato);
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
