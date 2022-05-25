using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Contador3 : MonoBehaviour

{
    public Text contador;
    public Text fin;
    public Text inicio;
    private float tiempo = 500f;

    // Use this for initialization
    void Start()
    {
        contador.text = " " + tiempo;
        fin.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        contador.text = " " + tiempo.ToString("f0");

        if (tiempo <= 0)
        {
            contador.text = "0";
            SceneManager.LoadScene("GameOver");
        }
        if (tiempo <= 497)
        {
            inicio.enabled = false;
        }
    }
}
