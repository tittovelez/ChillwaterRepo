using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraDown : MonoBehaviour
{
    public Transform followobject;
    public float velocidadfollow = 10.0f;
    public Vector3 offset;
    public Vector3 scale = new Vector3(0, 1, 1);
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Vector3.Scale(followobject.position + offset, scale), Time.deltaTime * velocidadfollow);
    }
}
