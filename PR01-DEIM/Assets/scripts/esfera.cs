using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera : MonoBehaviour
{
    int aleatorio = 0;
    [SerializeField] int numElegido;
     // Start is called before the first frame update
    void Start()
    {
        /*while (aleatorio != numElegido)
        {
            aleatorio = Random.Range(0 , 55);
            print(aleatorio);
        }*/


        for (int aleatorio2 = 0; aleatorio2 != numElegido; aleatorio2 = Random.Range(0, 55))
        {
            if(aleatorio2 < 15)
            {
                print("es menor que 15");
            }
            else if (aleatorio2 > 33)
            {
                print("es mayor que 33");
            }
        
           

        }
    }

    // Update is called once per frame
    void Update()
    {


       

    }
}
