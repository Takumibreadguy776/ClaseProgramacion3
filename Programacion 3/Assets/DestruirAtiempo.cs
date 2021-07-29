using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirAtiempo: MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
       if(other.gameObject.tag == "Edge")
        {
            Destroy(gameObject);
        }
            
    }
}
