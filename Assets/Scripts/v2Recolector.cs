using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class v2Recolector : MonoBehaviour
{
    public int puntuacion = 0;
    public PuntuacionTotal puntuacionTotal;
    public TextMeshProUGUI puntuacionActualtext;
    public int puntuacionactual = 0;
    // Start is called before the first frame update
    void Start()
    {
        puntuacionTotal= GetComponent<PuntuacionTotal>();
    }

    // Update is called once per frame
    void Update()
    {
        puntuacionActualtext.text = puntuacionactual.ToString();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pez")
        {
            MovimientoAutomatico pe = collision.gameObject.GetComponent<MovimientoAutomatico>();
            if (pe != null)
            {
               
                Debug.Log(pe.puntuacion);
                puntuacionTotal.sumar(puntuacion);
            }
            Destroy(collision.gameObject);
            
        }
    }
}
