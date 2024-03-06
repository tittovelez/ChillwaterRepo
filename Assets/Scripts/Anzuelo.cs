using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.UI;
using TMPro;

public class Anzuelo : MonoBehaviour
{
    private int puntuacion;
    public TextMeshProUGUI puntuacionText;
    public GameObject followobject;

    private void Start()
    {
        puntuacion = 0;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Recoger")
        {
            Destroy(collision.gameObject);
            puntuacion++;
            puntuacionText.text = puntuacion.ToString();
        }
        if (collision.gameObject.tag == "collision")
        {
            followobject.SetActive(true);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "collision")
        {
            followobject.SetActive(false);
        }
    }
}
