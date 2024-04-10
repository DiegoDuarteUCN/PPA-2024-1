using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Libreria de TextMeshPro
using TMPro;

public class HelloWorld : MonoBehaviour
{
    // PARA DECLARAR VARIABLE
    // VISIBILIDAD + TIPO DE DATO + NOMBRE (= VALOR(OPCIONAL)) + ;
    [SerializeField] private string nombre = "Diego";

    [SerializeField][Range(0,100)] private int edad;

    [SerializeField] private float decimales;

    [SerializeField] private bool booleano;

    [SerializeField] private string[] nombresEstudiantes;

    [SerializeField] private List<string> nombresProfesores;


    [SerializeField] private ByeByeWorld elOtroScript;

    public int fuerzaSalto = 1000;

    public int monedas = 0;

    public Rigidbody rb;

    public bool saltando = false;

    // Una variable para referenciar el texto
    public TextMeshProUGUI textoMonedas;

    // Ejecuta codigo al iniciar el proyecto
    void Start(){
        print("Hola Mundo!");

        for (int i = 0; i < nombresEstudiantes.Length; i++) 
        {
            nombresEstudiantes[i] = "Mauricio Muñoz " + i;  
        }

        print(nombre + elOtroScript.GetApellido());

    }

    // Es el ciclo del proyecto
    void Update()
    {
        elOtroScript.IsIllegal(edad);

        print("Hola Mundo Repetido porque me dijo el Alex que era así");
        /*if (edad > 50)
        {
            print("El profe es Viejito");
        }
        else
        {
            print("el profe es taquillero");
        }*/

        Movement();

        // Si presiono la barra espaciadora voy a hacer que el personaje salte
        if (Input.GetKeyDown(KeyCode.Space) && saltando == false) 
        {
            rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
            saltando = true;
        }
    }

    // Es un metodo que se ejecuta cuando apago un GameObjet
    private void OnDisable()
    {
        print("Me apagué");
    }
    // Es un metodo que se ejecuta cuando enciendo un GameObjet
    private void OnEnable()
    {
        print("Me encendí :* ");
    }

    // Metodo que se ejecuta para las físicas
    private void FixedUpdate()
    {
        // USAMOS FISICAS TORQUE, FUERZA, GRAVEDAD
    }

    // Metodo que se ejecuta cuandop hay algún cambio en el Inspector
    private void OnValidate()
    {
        print("Hubo un cambio en el Inspector");
    }


    /// <summary>
    /// Este metodo hará un movimiento
    /// </summary>
    public void Movement() 
    {
        // SI MANTENGO PRESIONADO LA TECLA D
        if (Input.GetKey(KeyCode.D)) 
        {
            // MUEVO EL CUBO
            transform.Translate(decimales, 0, 0);
        }
        // SI MANTENGO PRESIONADO LA TECLA A
        if (Input.GetKey(KeyCode.A))
        {
            // MUEVO EL CUBO
            transform.Translate(-decimales, 0, 0);
        }
        // SI MANTENGO PRESIONADO LA TECLA A
        if (Input.GetKey(KeyCode.W))
        {
            // MUEVO EL CUBO
            transform.Translate(0,decimales,0);
        }
        // SI MANTENGO PRESIONADO LA TECLA A
        if (Input.GetKey(KeyCode.S))
        {
            // MUEVO EL CUBO
            transform.Translate(0, -decimales, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Colisione 2D PIXEL ART con: " + collision.gameObject.name);
    }


    // Valida cuando un objeto comienza a colisionar con algo
    private void OnCollisionEnter(Collision collision)
    {
        print("Colisione con: " + collision.gameObject.name);

        // Si mi personaje colisiona con una moneda ocurre algo
        if (collision.gameObject.CompareTag("Moneda")) 
        {
            // Elimino la moneda
            Destroy(collision.gameObject);

            // Agregamos una moneda a un contador
            monedas++;
            textoMonedas.text = "Pelotitas" + monedas;

        }

        if (collision.gameObject.CompareTag("Suelo")) 
        {
            saltando = false;
        }
    }

    // Validar cuando dejo de colisionar con algo
    private void OnCollisionExit(Collision collision)
    {
        print("Deje de colisionar con: " + collision.gameObject.name);
    }

    // Valido si es que se mantiene una colisión
    private void OnCollisionStay(Collision collision)
    {
        print("Estoy sintiendo el choque con: " + collision.gameObject.name);
    }

    // Valido si intersecté con un objeto
    private void OnTriggerEnter(Collider other)
    {
        print("intersecté con: " + other.gameObject.name);

    }

    // Valido si dejé de intersectar con un objeto
    private void OnTriggerExit(Collider other)
    {
        print("Deje de intersectar con: " + other.gameObject.name);

    }

    // Valido si estoy intersectando con un objeto
    private void OnTriggerStay(Collider other)
    {
        print("Estoy intersectando con: " + other.gameObject.name);

    }
}
