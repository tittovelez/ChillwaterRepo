using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.UI;
using TMPro;

public class Anzuelo : MonoBehaviour
{
    public int lvlc = 1;
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
            Debug.Log ("Cebo" +  lvlc);
            if (lvlc == 3)
            {

                Input.GetKey("c");
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Pez")
        {
            MovimientoAutomatico pe = collision.gameObject.GetComponent<MovimientoAutomatico>();
            if (pe != null)
            {
                if(pe.nivelPez <= lvlc)
                {
                    pe.followobject = this.gameObject;
                }
               
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
