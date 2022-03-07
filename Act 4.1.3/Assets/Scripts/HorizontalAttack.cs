using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalAttack : MonoBehaviour
{    
    [SerializeField] Vector3 move;
    void Update()
    {
        transform.Translate(move * Time.deltaTime);  
    }
    // The object changes direction when it hits the wall. 
    void OnTriggerEnter2D(Collider2D collision) {
           move = -move;  
        }
            
}