using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;
    Vector3 offset;
    Quaternion initialRotation;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
        initialRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        // Actualizar la posición de la cámara según la posición del objetivo
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);

        // Restaurar la rotación inicial de la cámara
        transform.rotation = initialRotation;
    }
}

