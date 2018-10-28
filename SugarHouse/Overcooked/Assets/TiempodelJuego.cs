using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TiempodelJuego : MonoBehaviour {
    public AudioSource tickSource;
    public int timeLeft = 500;
    public Text countdownText;
    [SerializeField] private string loadLevel;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
        tickSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("" + timeLeft);

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Ready";
            SceneManager.LoadScene(loadLevel);
            tickSource.Play();
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

