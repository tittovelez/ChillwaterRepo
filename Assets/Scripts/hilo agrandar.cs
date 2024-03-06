using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiloagrandar : MonoBehaviour
{
    public float followspeed = 10.0f;
    public float currentTime = 0.0f;
    public float maxTime = 5.0f;

    public float scale = 1.0f;
    public float minScale = 1.0f;
    public float maxScale = 5.0f;
    public float growSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            scale += Time.deltaTime * growSpeed;
        } else
        {
            scale -= Time.deltaTime * growSpeed;
        }
        scale = Mathf.Clamp(scale, minScale, maxScale);
        Debug.Log(scale);
    }
}
