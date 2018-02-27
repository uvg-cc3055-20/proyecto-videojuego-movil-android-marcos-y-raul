
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{

    private Rigidbody2D r;
    public GameObject jugador;
    private Transform jugadorTrans;
    public float velocidad;
    public float vida_bala;

    private void Awake()
    {
        r = GetComponent<Rigidbody2D>();
        jugador = GameObject.FindGameObjectWithTag("Jugador1");
        jugadorTrans = jugador.transform;
    }

    // Use this for initialization
    void Start()
    {
        if (jugadorTrans.localScale.x > 0)
        {
            //r.velocity = new Vector2(velocidad, r.velocity.y);
            //transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            //r.velocity = new Vector2(-velocidad, r.velocity.y);
            //transform.localScale = new Vector3(-1, 1, 1);
        }

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, vida_bala);
    }
}
