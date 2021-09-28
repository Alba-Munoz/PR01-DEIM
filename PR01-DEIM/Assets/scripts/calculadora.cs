using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculadora : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Calcular(125.6f, 587f, "dividir");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Calcular(float num1, float num2, string op)
    {
        float resultado = 0f;
        if (op == "dividir")
        {
            resultado = num1 / num2;
        }
        else if (op == "restar")
        {
            resultado = num1 - num2;
        }
        else if (op == "sumar")
        {
            resultado = num1 + num2;
        }
        else if (op == "multiplicar")
        {
            resultado = num1 * num2;
        }
        print (resultado);
    }
}
