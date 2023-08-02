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
            Debug.LogError("Target obje atanmad�!");  //Inspector de hedef atanmam��sa hata verir
            return;
        }

        initialPosition = transform.position;  //ba�lang�� konumu kaydedilir

        Vector3 directionToTarget = (target.position - initialPosition).normalized; //hedefe olan uzakl�k kaydedilir

    }

    void Update()
    {

        Vector3 centerToTarget = target.position - initialPosition;

        centerToTarget.y = 0f;

        Quaternion desiredRotation = Quaternion.LookRotation(centerToTarget, Vector3.up);  //gezegenin g�ne�e bakarak d�nmesini sa�lar (kendi etraf�nda da d�nm�� olur)

        transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);  // Gezegenin G�ne� etraf�nda d�nmesi

        Vector3 desiredPosition = Quaternion.Euler(0, rotationSpeed * Time.time, 0) * centerToTarget;
        desiredPosition += target.position;

        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime); // Gezegenin G�ne� etraf�nda d�nmesi

    }
}
