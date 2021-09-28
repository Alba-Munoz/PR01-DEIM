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
        for(int aleatorio = 0; aleatorio != numElegido; aleatorio = Random.Range(0 , 20))
        {
            print(aleatorio);
        }
    }

    // Update is called once per frame
    void Update()
    {


       

    }
}
