using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carroMANAGER : MonoBehaviour
{
    public carro autos;


    void Update()
    {
        Debug.Log("Nombre:" + autos.name);
        Debug.Log("Nombre:" + autos.tipo);
        Debug.Log("Nombre:" + autos.acelerecacion.ToString());
        Debug.Log("Nombre:" + autos.velocidad.ToString());
    }
}
