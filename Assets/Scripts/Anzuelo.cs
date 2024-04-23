using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.UI;
using TMPro;

public class Anzuelo : MonoBehaviour
{
    public int lvlc = 0;
    private bool isCKeyDisabled = false;
    public int nivelpez;
    private void Start()
    {
        
    }
    void Update()
    {
        if (lvlc == 0)
        {

        }
        else if (Input.GetKey("c"))
        {
            lvlc = lvlc + 1;
            if (lvlc == 3)
            {

                Input.GetKey("c");
            }
        }
        if (lvlc == 1)
        {

        }
        if (lvlc == 2)
        {

        }
        if (lvlc == 3)
        {

        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pez" && nivelpez == 1 && lvlc == 1)
        {
            MovimientoAutomatico pe = collision.gameObject.GetComponent<MovimientoAutomatico>();
            if (pe != null)
            {
                pe.followobject = this.gameObject;
            }
        }

        if (collision.gameObject.tag == "Pez" && nivelpez == 2 && lvlc == 2)
        {
            MovimientoAutomatico pe = collision.gameObject.GetComponent<MovimientoAutomatico>();
            if (pe != null)
            {
                pe.followobject = this.gameObject;
            }
        }

        if (collision.gameObject.tag == "Pez" && nivelpez == 3 && lvlc == 3)
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
