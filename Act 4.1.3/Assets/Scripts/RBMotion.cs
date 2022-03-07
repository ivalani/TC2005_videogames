/*
Para mover el personaje verticalmente 

Iwalani Amador - A01732251
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RBMotion : MonoBehaviour
{
[SerializeField] float speed;
Rigidbody2D rb2D;
Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal")*speed;
        move.y = Input.GetAxis("Vertical") * speed*2;

        rb2D.AddForce(move);
    }
}
