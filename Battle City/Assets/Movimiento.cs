using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTanque : MonoBehaviour
{
    public float velocidad = 10f; // Velocidad de movimiento
    public float velocidadRotacion = 10f; // Velocidad de rotaci�n
    

    void Update()
    {
        // Obtener la entrada de teclado
        float movimientoVertical = Input.GetAxis("Vertical");
        float rotacionHorizontal = Input.GetAxis("Horizontal");

        // Calcular la velocidad y la rotaci�n
        float movimiento = movimientoVertical * velocidad * Time.deltaTime;
        float rotacion = rotacionHorizontal * velocidadRotacion * Time.deltaTime;

        // Aplicar movimiento y rotaci�n al tanque
        transform.Translate(Vector3.forward * movimiento);
        transform.Rotate(Vector3.up * rotacion);

       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }*/ 
    }


}