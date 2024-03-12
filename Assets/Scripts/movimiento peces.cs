using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHorizontalAutomatico : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento
    public bool moverHaciaDerecha = true; // Indica si el objeto se mueve hacia la derecha o hacia la izquierda

    // Update is called once per frame
    void Update()
    {
        // Calcular el desplazamiento
        float desplazamiento = velocidad * Time.deltaTime;

        // Determinar la dirección del movimiento
        if (moverHaciaDerecha)
        {
            // Mover hacia la derecha
            transform.Translate(Vector2.right * desplazamiento);
        }
        else
        {
            // Mover hacia la izquierda
            transform.Translate(Vector2.left * desplazamiento);
        }
    }
}

