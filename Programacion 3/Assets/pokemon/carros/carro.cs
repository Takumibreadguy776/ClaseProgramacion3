using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Carro", menuName = "Autos", order = 3)]
public class carro : ScriptableObject
{
    public new string name;
    public string tipo;
    public int acelerecacion;
    public int velocidad;
    public Sprite img;

}
