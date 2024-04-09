using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class v2Recolector : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pez")
        {
            MovimientoAutomatico pe = collision.gameObject.GetComponent<MovimientoAutomatico>();
            if (pe != null)
            {
                Debug.Log(pe.puntuacion);
            }
            Destroy(collision.gameObject);
        }
    }
}
