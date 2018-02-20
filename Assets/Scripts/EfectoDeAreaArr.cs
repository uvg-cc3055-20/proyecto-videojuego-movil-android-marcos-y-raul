using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoDeAreaArr : MonoBehaviour
{

    public GameObject child;
    public bool activated;
    public float time = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        if (time >= 3)
        {
            activated = !activated;
            child.SetActive(activated);
            time = 0;
        }

    }
}
