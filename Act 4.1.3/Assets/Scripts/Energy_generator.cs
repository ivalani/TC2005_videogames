using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy_generator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject energyPrefab; 
    [SerializeField] Vector2 limits; 
    [SerializeField] float delay; 
    public float amount_Energy = 0f; 
    //public float Radius = 1; 
    Vector3 position;
    void Start()
    {
        InvokeRepeating("MakeEnergy",1,delay); 
    }

    // Update is called once per frame
    void MakeEnergy(){
        position = new Vector3(Random.Range(-limits.x, limits.x), limits.y, 0);
        //Vector3 randomPos = Random.insideUnitCircle * Radius; 
        Instantiate(energyPrefab, Vector3.zero,Quaternion.identity);
        amount_Energy ++; 
    }
}
