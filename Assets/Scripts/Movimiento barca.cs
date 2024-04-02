using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientobarca : MonoBehaviour
{
    public float movimientofuerza = 2f;
    // Update is called once per frame
    GameObject inventario_com;
    private bool inventoryVisible = false;
    
    private void Start()
    {
        inventario_com = GameObject.FindGameObjectWithTag("inventario-com");
        inventario_com.SetActive(false);
    }
    void Update()
    {
        float MovementX = Input.GetAxisRaw("Horizontal");
        Vector2 posicionBarca = transform.position;

        posicionBarca = posicionBarca + new Vector2(MovementX, 0f) * movimientofuerza * Time.deltaTime;

        transform.position = posicionBarca;
        if (Input.GetKey(KeyCode.I))
        {
            inventoryVisible = true;
            inventario_com.SetActive(inventoryVisible);
        }
        else
        {
            inventoryVisible = false;
            inventario_com.SetActive(inventoryVisible);
        }
    }
    
}