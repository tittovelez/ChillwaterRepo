using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Necesario para trabajar con escenas
using UnityEngine.UI;

public class PuntuacionTotal : MonoBehaviour
{
    public TextMeshProUGUI textoPuntuacion;
    public int puntuacionParaGanar = 20; // Establece el umbral de puntuación para ganar
    public string Victoria; // Nombre de la escena de victoria
    public int puntuacionactual = 0;
    private int puntuacionTotal = 0;
    public TextMeshProUGUI puntuacionActualtext;

    // Método para actualizar el texto de la puntuación
    public void sumar(int puntos)
    {
        puntuacionactual += puntos;
    }
    void ActualizarTextoPuntuacion()
    {
        if (textoPuntuacion != null)
        {
            textoPuntuacion.text = puntuacionTotal.ToString(); 
        }
    }

    // Método para sumar la puntuación
    public void SumarPuntuacion(int puntuacion)
    {
        puntuacionTotal += puntuacion;
        ActualizarTextoPuntuacion();

        // Verificar si la puntuación total alcanza el umbral para ganar
        if (puntuacionTotal >= puntuacionParaGanar)
        {
            Ganar();
        }
    }

    // Método para cargar la escena de victoria
    void Ganar()
    {
        // Cargar la escena de victoria
        if (!string.IsNullOrEmpty(Victoria))
        {
            SceneManager.LoadScene(Victoria);
        }
        else
        {
            Debug.LogWarning("Victoria.");
        }
    }
    private void Update()
    {
        puntuacionActualtext.text = puntuacionactual.ToString();
    }
}
