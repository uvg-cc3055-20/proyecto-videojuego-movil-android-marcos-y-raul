using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala2 : MonoBehaviour {
    /*Atributos para la clase*/
    private Rigidbody2D r;
    public GameObject jugador;
    private Transform jugadorTrans;
    public float velocidad;
    public float vida_bala;

    private void Awake()
    {
        r = GetComponent<Rigidbody2D>();
        jugador = GameObject.FindGameObjectWithTag("Jugador2");
        jugadorTrans = jugador.transform;

    }

    // Use this for initialization
    void Start()
    {
        /*Muestra un valor en transform*/
        transform.localScale = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        /*muestra la bala*/
        r.transform.Translate(new Vector3(1, 0, 0) * velocidad * Time.deltaTime);
        Destroy(gameObject, vida_bala);
    }
}
