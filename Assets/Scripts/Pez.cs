using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAutomatico : MonoBehaviour
{
    public GameObject ObjetoAmover;
    public float velocidad;
    public Transform StartPont;
    public Transform EndPoint;
    public Vector3 MoverHacia;
    private int puntuacion; // Puntuación individual para cada objeto
    public string tagRecoger = "Recoger"; // Tag del objeto para recoger

    private SpriteRenderer spriteRenderer;
    private PuntuacionTotal puntuacionTotalScript;

    private void Start()
    {
        MoverHacia = EndPoint.position;
        spriteRenderer = GetComponent<SpriteRenderer>();

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

    void Update()
    {
        ObjetoAmover.transform.position = Vector3.MoveTowards(ObjetoAmover.transform.position, MoverHacia, velocidad * Time.deltaTime);

        if (ObjetoAmover.transform.position == EndPoint.position)
        {
            MoverHacia = StartPont.position;
        }
        if (ObjetoAmover.transform.position == StartPont.position)
        {
            MoverHacia = EndPoint.position;
        }
        if (MoverHacia.x > transform.position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Anzuelo"))
        {
            if (puntuacionTotalScript != null)
            {
                // Llama al método SumarPuntuacion() del objeto PuntuacionTotal y pasa su propia puntuación
                puntuacionTotalScript.SumarPuntuacion(puntuacion);
            }
        }
    }
}



