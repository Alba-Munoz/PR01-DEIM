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
        while (aleatorio != numElegido)
        {
            aleatorio = Random.Range(0 , 55);
            print(aleatorio);
        }


        for (int aleatorio2 = 0; aleatorio2 != numElegido; aleatorio2 = Random.Range(0, 55))
        {
            print("Aleatorio FOR" + aleatorio2);
        }
    }

    // Update is called once per frame
    void Update()
    {


       

    }
}
