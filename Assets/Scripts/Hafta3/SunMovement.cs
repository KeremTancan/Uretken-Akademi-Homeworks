using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovement : MonoBehaviour
{
    
    public float movementSpeed = 5f;
    public float rotationSpeed = 50f;
  
  
    void Update()
    {
        
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        

    }
}

