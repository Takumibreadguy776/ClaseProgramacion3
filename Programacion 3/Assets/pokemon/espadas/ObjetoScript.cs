using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Espada", menuName = "ArmaMeele", order = 2)]
public class ObjetoScript : ScriptableObject
{
    public new string name;
    public string tipo;
    public int peso;
    public int DMG;
    public int durabilidad;
    public Sprite img;


}
