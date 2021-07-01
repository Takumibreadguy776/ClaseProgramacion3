using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;

    private Transform Target;
    //find player
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    //enemigo sigue jugador a cierta velocidad
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
    }
}
