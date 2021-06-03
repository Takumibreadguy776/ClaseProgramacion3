using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arreglo1 : MonoBehaviour
{

    public GameObject[] Array;


    [SerializeField]
    private GameObject[] enemyPrefab;
    private int spawnIndex;
    private Transform[] spawnpoints;
    private Vector3 spawnPos;
    private int count;

    void Start()
    {
        count = transform.childCount;
        spawnpoints = new Transform[count];
        for (int i = 0; i < count; i++)
        {
            spawnpoints[i] = transform.GetChild(i);
        }

        
    }

    void spawnEnemys()
    {
        spawnIndex = Random.Range(0, count);

        Instantiate(enemyPrefab[Random.Range(0, 4)], spawnpoints[spawnIndex].position, enemyPrefab[Random.Range(0, 4)].transform.rotation);
    }

     
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            spawnEnemys();
        }
    }
    
}
