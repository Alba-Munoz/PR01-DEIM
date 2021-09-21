using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera : MonoBehaviour
{
    [SerializeField]int num1;
    [SerializeField]int num2 ;
    private float resultado;
   
    // Start is called before the first frame update
    void Start()
    {

        resultado = num1 * num2;
        print(resultado);
        Multiplicar(num1, num2);

        float Multiplicar(float num1, float num2)
        {
            resultado = num1 * num2;
            print("Resultado" + resultado);
            return resultado;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
