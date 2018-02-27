using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController instance;

    public Text etiquetaT;
    public float tiempo = 10;
    public bool turno = true;
    public bool dead = true;

    // Use this for initialization
    void Start()
    {
        instance = this;
        etiquetaT.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == true)
        {
            tiempo = tiempo - Time.deltaTime;
            if (tiempo <= 0)
            {
                tiempo = 10f;
                turno = !turno;
            }
            etiquetaT.text = "Tiempo Restante: " + tiempo.ToString("n2");
        }
    }

}

