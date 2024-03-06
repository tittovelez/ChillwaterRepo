using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeAnzuelo : MonoBehaviour
{
    private Transform objetoRecoger; // Referencia al objeto con el tag "Recoger"

    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Recoger"))
        {
            // Guarda la referencia al objeto con el tag "Recoger"
            objetoRecoger = collision.gameObject.transform;
        }
    }

    void Update()
    {
        // Verifica si tenemos la referencia al objeto con el tag "Recoger"
        if (objetoRecoger != null)
        {
            // Actualiza la posición del objeto al que está adjunto
            transform.position = objetoRecoger.position;
        }
    }
}

