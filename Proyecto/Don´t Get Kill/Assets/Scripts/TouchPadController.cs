using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TouchPadController : MonoBehaviour {

    /*Atributo para de los componentes de Unity*/
    public Transform balaSpawner;
    public GameObject balaPrefab;
    Rigidbody2D rb2d;

    /*Atributo para las clases*/
    private bool facingRight = true;
    int contbala = 0;
    public Sprite deadTank;
    public float speed = 1.5f;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        /*Llama al los componentes de CrossfromInput*/
        float moveV = CrossPlatformInputManager.GetAxis("Vertical");
        float moveH = CrossPlatformInputManager.GetAxis("Horizontal");

        if ((GameController.instance.turno))
        {
            /*Condiciones para el movimiento horizontal*/
            if (moveH != 0)
            {
                rb2d.transform.Translate(new Vector3(1, 0, 0) * moveH * speed * Time.deltaTime);
                facingRight = moveH > 0;
            }
            /*Condiciones para el movimiento horizontal*/
            if (moveV != 0)
            {
                //moveV = moveV * -1;
                rb2d.transform.Translate(new Vector3(0, 1, 0) * moveV * speed * Time.deltaTime);
                facingRight = moveV > 0;
            }
            /*Condicion para disparar la bala*/
            if (CrossPlatformInputManager.GetButtonDown("Shoot"))
            {
                /*Llama al metodo disparar*/
                playerShooting();
            }
        }

    }
    /*Metodo para disparar*/
    public void playerShooting()
    {
        Instantiate(balaPrefab, balaSpawner.position, balaSpawner.rotation);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        this.GetComponent<SpriteRenderer>().sprite = deadTank;
        
        if (collision.gameObject.tag == "bala")
        {
            //GameController.instance.punto;
            GameController.instance.dead = false;
        }
    }
}
