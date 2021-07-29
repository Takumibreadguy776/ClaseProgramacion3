using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonManager : MonoBehaviour
{

    public pokemon poke;
    public string tipo;
    public int hp;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Nombre:" + poke.name);
        Debug.Log("Nombre:" + poke.tipo);
        tipo = poke.tipo;
        if (hp == 0)
            hp = poke.hp;
        Debug.Log("Nombre:" + poke.hp.ToString());
        Debug.Log("Nombre:" + poke.atk.ToString());
        Debug.Log("Nombre:" + poke.def.ToString());
        Debug.Log("Nombre:" + poke.vel.ToString());

    }
}
