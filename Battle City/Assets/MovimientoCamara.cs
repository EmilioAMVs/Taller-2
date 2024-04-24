using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Transform objetivo; // Referencia al transform del tanque
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Posici�n relativa a seguir

    void Update()
    {
        // Asegurarse de que hay un objetivo asignado
        if (objetivo != null)
        {
            // Calcular la posici�n deseada de la c�mara
            Vector3 posicionDeseada = objetivo.position + offset;
            // Interpolar suavemente la posici�n de la c�mara
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, Time.deltaTime * 5f);
        }
    }
}
