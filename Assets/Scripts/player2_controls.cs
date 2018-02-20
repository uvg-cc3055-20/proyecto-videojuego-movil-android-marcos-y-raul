using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2_controls : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 5f;

    public Transform balaSpawner;
    public GameObject balaPrefab;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.turno==false && GameController.instance.dead == true)
        {
            playermove();
            playerShooting();
        }
    }

    public void playermove()
    {
        float movX = Input.acceleration.x;
        rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
    }

    public void playerShooting()
    {
        //if (Input.GetKey("Fire1"))
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Instantiate(balaPrefab, balaSpawner.position, balaSpawner.rotation);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.instance.dead = false;
    }


}
