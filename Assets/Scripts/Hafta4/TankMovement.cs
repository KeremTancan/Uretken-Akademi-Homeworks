using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float speed = 10f;          
    public float rotationSpeed = 100f;  

    private Rigidbody carRigidbody;    

    private void Start()
    {
        carRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
       
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * verticalInput * speed * Time.deltaTime;
        Quaternion rotation = Quaternion.Euler(0f, horizontalInput * rotationSpeed * Time.deltaTime, 0f);
             
        
        carRigidbody.MoveRotation(carRigidbody.rotation * rotation);

        
        carRigidbody.MovePosition(carRigidbody.position + movement);
    }
}
