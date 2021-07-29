using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemys : MonoBehaviour
{

    //private int[] spawnrate;
    public GameObject[] enemigos;
    public int totalrate;
    public int randomnum;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject n in enemigos)
        {
            totalrate += n.GetComponent<LootManager>().rateDragon;
        }
        //SUMAR EL TOTAL DE EL SPAWNRATE 


        //random num de 0 a spawnrate
        randomnum = Random.Range(0, totalrate);


        //comparar tu spawnrate vs el random num;
        for (int i = 0; i < enemigos.Length; i++)
        {
            if (enemigos[i].GetComponent<LootManager>().rateDragon <= randomnum)
            {
                randomnum -= enemigos[i].GetComponent<LootManager>().rateDragon;
            }
            else
            {
                Instantiate(enemigos[i]);
                Debug.Log(randomnum);
            }
            //si es menor o igaul a spawnrate paramos y ese es el spawn que se instancia 
            //35 > 50 gana el primero.
            //85 > 50 si entonces tenemos que restar randomnum - spawnrate[i] =  35 > 30  = ---- = 5 >20 no entonces que el tercero gana.

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}