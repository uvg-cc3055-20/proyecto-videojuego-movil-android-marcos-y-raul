
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    /*Movimiento para la clase*/
    private Rigidbody2D r;
    public GameObject jugador;
    private Transform jugadorTrans;
    public float velocidad;
    public float vida_bala;

    private void Awake()
    {
        /*Inicializa cada uno de los atributos*/
        r = GetComponent<Rigidbody2D>();
        jugador = GameObject.FindGameObjectWithTag("Jugador1");
        jugadorTrans = jugador.transform;
        
    }

    // Use this for initialization
    void Start()
    {
        /*da valor al transform*/
        transform.localScale = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        /*transform de la bala  */
        r.transform.Translate(new Vector3(1, 0, 0) * velocidad* Time.deltaTime);
        Destroy(gameObject, vida_bala);
    }   
}
