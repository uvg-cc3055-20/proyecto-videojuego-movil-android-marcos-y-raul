using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1_controls : MonoBehaviour {
    float movimiento = 3f;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += new Vector3(-1 * Time.deltaTime * movimiento, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += new Vector3(Time.deltaTime * movimiento, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
        this.transform.position += new Vector3(0, 1.5f * Time.deltaTime * movimiento,  0);
        }

    }
}
