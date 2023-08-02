using UnityEngine;

public class PlanetMovement : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 5f;

    private Vector3 initialPosition;

    void Start()
    {
        if (target == null)
        {
            Debug.LogError("Target obje atanmadý!");  //Inspector de hedef atanmamýþsa hata verir
            return;
        }

        initialPosition = transform.position;  //baþlangýç konumu kaydedilir

        Vector3 directionToTarget = (target.position - initialPosition).normalized; //hedefe olan uzaklýk kaydedilir

    }

    void Update()
    {

        Vector3 centerToTarget = target.position - initialPosition;

        centerToTarget.y = 0f;

        Quaternion desiredRotation = Quaternion.LookRotation(centerToTarget, Vector3.up);  //gezegenin güneþe bakarak dönmesini saðlar (kendi etrafýnda da dönmüþ olur)

        transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);  // Gezegenin Güneþ etrafýnda dönmesi

        Vector3 desiredPosition = Quaternion.Euler(0, rotationSpeed * Time.time, 0) * centerToTarget;
        desiredPosition += target.position;

        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime); // Gezegenin Güneþ etrafýnda dönmesi

    }
}
