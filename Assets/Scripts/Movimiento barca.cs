using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientobarca : MonoBehaviour
{
    public float movimientofuerza = 2f;
    // Update is called once per frame
    void Update()
    {
        float MovementX = Input.GetAxisRaw("Horizontal");
        Vector2 posicionBarca = transform.position;

        posicionBarca = posicionBarca + new Vector2(MovementX, 0f) * movimientofuerza * Time.deltaTime;

        transform.position = posicionBarca;
    }
}