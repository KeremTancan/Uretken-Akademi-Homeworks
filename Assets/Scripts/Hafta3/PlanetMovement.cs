using UnityEngine;

public class PlanetMovement : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 5f;

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    void Start()
    {
        if (target == null)
        {
            Debug.LogError("Target object not assigned! Please assign the target object in the Inspector.");
            return;
        }

        initialPosition = transform.position;

        
        Vector3 directionToTarget = (target.position - initialPosition).normalized;
        //initialRotation = Quaternion.LookRotation(directionToTarget, Vector3.up);
    }

    void Update()
    {
        if (target == null)
            return;

        Vector3 centerToTarget = target.position - initialPosition;
      
        centerToTarget.y = 0f;

        Quaternion desiredRotation = Quaternion.LookRotation(centerToTarget, Vector3.up);

        transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);

        Vector3 desiredPosition = Quaternion.Euler(0, rotationSpeed * Time.time, 0) * centerToTarget;
        desiredPosition += target.position;

        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime);

    }
}
