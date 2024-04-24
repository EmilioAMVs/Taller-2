using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Transform objetivo; // Referencia al transform del tanque
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Posición relativa a seguir

    void Update()
    {
        // Asegurarse de que hay un objetivo asignado
        if (objetivo != null)
        {
            // Calcular la posición deseada de la cámara
            Vector3 posicionDeseada = objetivo.position + offset;
            // Interpolar suavemente la posición de la cámara
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, Time.deltaTime * 5f);
        }
    }
}
