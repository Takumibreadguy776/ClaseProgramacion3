using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public GameObject hitEffect;
    //instansear efecto y destruirlo poco despues
    void OnCollisionEnter2D(Collision2D collision)
    {
       GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 3f);
        Destroy(gameObject);
    }

}
