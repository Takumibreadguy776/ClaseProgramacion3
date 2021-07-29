using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootManager : MonoBehaviour
{
    public int[] itemsrate = { 400, 300, 200, 100 };
    public GameObject[] gems;
    public int total;
    public int randomnum;

    public void randomLoot()
    {
        Debug.Log("ejecutamos el random loot");
        total = 0;

        //generar un numero random del tamaño total de el porcentaje de itemsrate. 820
        foreach(int item in itemsrate)
        {
            total += item;
        }

        randomnum = Random.Range(0, total);
        Debug.Log("random num:" + randomnum);

        //evaluar vs el itemsrate vs el numeor random
        //820 <= 400,820 - 400 = 420
        //420 <= 300,420 - 300 = 120
        //120 <= 200. winer
        for (int i = 0; i < itemsrate.Length; i++)
        {
            if (randomnum <= itemsrate[i])
            {
                Debug.Log("loot item" + i);
                Instantiate(gems[i], transform.position, Quaternion.identity);
                return;
            }
            else
            {
                randomnum -= itemsrate[i];
            }
        }
    }
}
