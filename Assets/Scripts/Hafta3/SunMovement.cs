using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovement : MonoBehaviour
{
    
    public float movementSpeed = 5f;
  
  
    void Update()
    { 
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime); //güneþin evrende düz ilerlemesi
    }
}

