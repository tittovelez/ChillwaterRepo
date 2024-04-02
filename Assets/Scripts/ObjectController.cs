using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public GameObject obj;
    public int cant = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ObjectController")
        {
            GameObject[] inventario = GameObject.FindGameObjectWithTag("general-events").GetComponent<InventoryController>().getSlot();

            for (int i = 0; i < inventario.Length; i++)
            {
                if (!inventario[i])
                {
                    GameObject.FindGameObjectWithTag("general-events").setSlot(obj, cant);
                    break;
                }
            }
        }
    }
}