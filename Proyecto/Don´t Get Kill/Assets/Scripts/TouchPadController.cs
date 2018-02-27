using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TouchPadController : MonoBehaviour {


    Rigidbody2D rb2d;
    private bool facingRight = true;

    public Transform balaSpawner;
    public GameObject balaPrefab;


    //public TouchPad leftpad;
    //public TouchPad rightpad;

    public float speed = 1.5f;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        float moveV = CrossPlatformInputManager.GetAxis("Vertical");
        float moveH = CrossPlatformInputManager.GetAxis("Horizontal");
       
        if (moveH != 0)
        {
            rb2d.transform.Translate(new Vector3(0, 1, 0) * moveH * speed * Time.deltaTime);
            facingRight = moveH > 0;
        }

        if (moveV != 0)
        {
            moveV = moveV * -1;
            rb2d.transform.Translate(new Vector3(1, 0, 0) * moveV * speed * Time.deltaTime);
            facingRight = moveV > 0;
        }

        //if (CrossPlatformInputManager.GetButtonDown("Shoot"))
        
            playerShooting();
        


    }

    public void playerShooting()
    {
        Instantiate(balaPrefab, balaSpawner.position, balaSpawner.rotation);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.instance.dead = false;
    }
}
