using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraDown : MonoBehaviour
{
    public GameObject followobject;
    public float velocidadfollow = 10.0f;
    void FixedUpdate()
    {
        if (followobject != null)
        {
            Transform t = transform;
            t.position = Vector3.Lerp(t.position,followobject.transform.position, velocidadfollow * Time.fixedDeltaTime);
            transform.SetPositionAndRotation(t.position,t.rotation);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "collision")
        {
            
        }
    }
}
