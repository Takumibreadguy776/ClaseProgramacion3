using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arreglo1 : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefab;
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

    void spawnPrefab()
    {
        spawnIndex = Random.Range(0, count);

        Instantiate(prefab[Random.Range(0, 4)], spawnpoints[spawnIndex].position, prefab[Random.Range(0, 4)].transform.rotation);
    }

     
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            spawnPrefab();
        }
    }
    
}
