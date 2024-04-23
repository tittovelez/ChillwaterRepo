using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hilo : MonoBehaviour
{
    float velocidad = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey ("space")) 
        {
            transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y + velocidad);
        }
        else
        {
            transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y - velocidad);
        }    
    }
}
