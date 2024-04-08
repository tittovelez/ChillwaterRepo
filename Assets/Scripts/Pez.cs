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
    public string tagRecoger = "Recoger"; // Tag del objeto para recoger

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        MoverHacia = EndPoint.position;
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Si no se encuentra, muestra un mensaje de error
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
    private void OnTriggerEnter2D(Collider2D collision)
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



