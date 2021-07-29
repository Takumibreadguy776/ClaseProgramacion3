using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="pokemon", menuName = "MyCardGame/Pokemon", order = 1)]
public class pokemon : ScriptableObject

{

    public new string name;
    public string tipo;
    public int hp;
    public int atk;
    public int def;
    public int vel;
    public Sprite img;




}
