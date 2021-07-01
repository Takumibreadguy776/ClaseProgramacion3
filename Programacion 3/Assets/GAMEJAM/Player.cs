using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float movespeed = 5f;

    public Rigidbody2D rb;

    public Camera cam;

    Vector2 movement;
    Vector2 mousePOS;


    //movimiento
    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");

       mousePOS = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    //seguir Mouse
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePOS - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

}
