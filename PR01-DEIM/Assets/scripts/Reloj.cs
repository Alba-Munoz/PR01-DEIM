using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Encendidoreloj");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  

    IEnumerator Encendidoreloj()
    {
        int segundos = 0;
        int minutos = 0;
        int horas = 0;
        string textoReloj;


        for( int n = 0; ; n++)
        {
            segundos++;
            if(segundos > 59)
            {
                minutos++;
                segundos = 0;
            }
            else if (minutos > 59)
            {
                horas++;
                minutos = 0;
            }
           

            textoReloj = horas + ":" + minutos + ":" + segundos.ToString("D2");
            print(textoReloj);
            yield return new WaitForSeconds(1f);
        }
    }
}
