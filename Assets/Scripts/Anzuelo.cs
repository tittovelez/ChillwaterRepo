using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.UI;
using TMPro;

public class Anzuelo : MonoBehaviour
{
    

    private void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pez")
        {
            MovimientoAutomatico pe = collision.gameObject.GetComponent<MovimientoAutomatico>();
            if (pe != null)
            {
                pe.followobject = this.gameObject;
            }
        }
          if (collision.gameObject.tag == "Bomba")
        {
            Debug.Log("patata");
            Destroy(collision.gameObject);

        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pez")
        {
            
        }
    }
}
