using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espadaManager : MonoBehaviour
{
    public ObjetoScript espadita;


    void Update()
    {
        Debug.Log("Nombre:" + espadita.name);
        Debug.Log("Nombre:" + espadita.tipo);
        Debug.Log("Nombre:" + espadita.DMG.ToString());
        Debug.Log("Nombre:" + espadita.durabilidad.ToString());
    }
}
