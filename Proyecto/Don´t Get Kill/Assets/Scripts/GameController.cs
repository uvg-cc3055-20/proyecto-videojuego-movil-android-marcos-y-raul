using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    /*Instancia de la case GameController*/
    public static GameController instance;

    public Text etiquetaT;
    public Text puntos;
    public float tiempo = 10;
    public bool turno = true;
    public bool dead = true;
    public float punto = 0;

    // Use this for initialization
    void Start()
    {
        instance = this;
        etiquetaT.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        /*Condiciones para el tiempo*/
        if (dead)
        {
            tiempo = tiempo - Time.deltaTime;
            if (tiempo <= 0)
            {
                tiempo = 10f;
                turno = !turno;
            }
            etiquetaT.text = "Tiempo Restante: " + tiempo.ToString("n2");
            if (punto <= 0)
            {
                punto = punto + 1;
                puntos.text = "Puntos" + punto.ToString("n2");
            }
        }
    }

}

