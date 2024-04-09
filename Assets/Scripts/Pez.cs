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
    public GameObject followobject;
    public int puntuacion = 0;


    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        MoverHacia = EndPoint.position;
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Si no se encuentra, muestra un mensaje de error
    }

    void Update()
    {
        if (followobject == null) {
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
        else
        {
            Vector3 position = transform.position;
            Vector3 targetposition = followobject.transform.position;
            position = Vector3.Lerp(position, targetposition, 10*Time.deltaTime); 
            transform.position = position;
        }
        
    }
}



