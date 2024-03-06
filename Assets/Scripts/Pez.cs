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

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        MoverHacia = EndPoint.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
        ObjetoAmover.transform.position = Vector3.MoveTowards(ObjetoAmover.transform.position, MoverHacia, velocidad * Time.deltaTime);

        if(ObjetoAmover.transform.position == EndPoint.position)
        {
            MoverHacia = StartPont.position;
        }
        if (ObjetoAmover.transform.position == StartPont.position)
        {
            MoverHacia = EndPoint.position;
        }
        if (MoverHacia.x> transform.position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}


