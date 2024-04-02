using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start(){
        print("Hola Mundo!");

        for (int i = 0; i < nombresEstudiantes.Length; i++) 
        {
            nombresEstudiantes[i] = "Mauricio Muñoz " + i;  
        }

    }

    // Update is called once per frame
    void Update()
    {
        print("Hola Mundo Repetido porque me dijo el Alex que era así");
        if (edad > 50)
        {
            print("El profe es Viejito");
        }
        else
        {
            print("el profe es taquillero");
        }

        Movement();
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
}
