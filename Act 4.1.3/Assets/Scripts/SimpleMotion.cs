using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMotion : MonoBehaviour
{
    float speed = 0.02f; 
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
        //Apply the new data to the object transform
        transform.Translate(move * speed);
    }

}
