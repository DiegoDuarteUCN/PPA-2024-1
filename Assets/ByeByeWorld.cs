using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByeByeWorld : MonoBehaviour
{

    [SerializeField] private string apellido;
    private int edad;
    [SerializeField] private bool illegal;

    public string GetApellido() { return this.apellido; }

    public void SetApellido(string apellido) { this.apellido = apellido; }

    public bool IsIllegal( int edadcita) 
    {
        if (edad < edadcita)
        {
            illegal = true;
            print("La edad que menciona no es ilegal");

            return true;

        }
        else
        {
            illegal = false;
            print("La edad que menciona es ilegal");

            return false;

        }
    }

}
