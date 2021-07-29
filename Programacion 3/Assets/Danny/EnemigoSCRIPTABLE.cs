using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemigo", menuName = "MiMenu/Enemigo", order = 1)]
public class EnemigoSCRIPTABLE : ScriptableObject
{



    public new string name;
    public int spawnrate;
    public int[] lootrate;
    public Sprite img;



}