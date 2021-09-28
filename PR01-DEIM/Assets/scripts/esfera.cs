using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera : MonoBehaviour
{
    
    [SerializeField] int numElegido;
    [SerializeField] string nombre;
     // Start is called before the first frame update
    void Start()
    {
        Saludo(nombre);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void Saludo(string nombre)
    {
        print("hola " + nombre);
    }
}
