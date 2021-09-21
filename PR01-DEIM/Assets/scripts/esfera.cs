using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera : MonoBehaviour
{
    [SerializeField]int n = 8;
    [SerializeField]float d = 8f;
    [SerializeField]string nombre;
    [SerializeField]bool up = false;
    [SerializeField]bool down = true;
    // Start is called before the first frame update
    void Start()
    {
        print(n);
        print(nombre);
        print(d);
        print(up);
        print(down);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
