using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion2 : MonoBehaviour
{
    private PuntuacionTotal puntuacionTotalScript;
    private int puntuacion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Encuentra el componente PuntuacionTotal en la escena
        puntuacionTotalScript = FindObjectOfType<PuntuacionTotal>();

        // Si no se encuentra, muestra un mensaje de error
        if (puntuacionTotalScript == null)
        {
            Debug.LogError("No se encontró el objeto PuntuacionTotal en la escena.");
        }

        // Aquí puedes establecer diferentes puntuaciones para diferentes objetos
        switch (gameObject.name)
        {
            case "Fish1":
                puntuacion = 10;
                break;
            case "Fish2":
                puntuacion = 10;
                break;
            case "Fish3":
                puntuacion = 20;
                break;
            case "Fish4":
                puntuacion = 40;
                break;
            case "Fish5":
                puntuacion = 50;
                break;
            case "Fish6":
                puntuacion = 40;
                break;
            case "Fish7":
                puntuacion = 60;
                break;
            case "Fish8":
                puntuacion = 80;
                break;

            case "Fish9":
                puntuacion = 100;
                break;
            case "Fish10":
                puntuacion = 100;
                break;
            // Agrega más casos según sea necesario para cada objeto
            default:
                puntuacion = 0;
                break;
        }
    }
}
