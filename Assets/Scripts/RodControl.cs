using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodControl : MonoBehaviour
{
    public float scale = 1.0f;
    public float minScale = 1.0f;
    public float maxScale = 10.0f;
    public float growSpeed = 3.0f;
    public GameObject Anzuelo;
    public GameObject puntaHilo;

    public List<GameObject> line;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)){
            scale += Time.deltaTime * growSpeed;
        }else{
            scale -= Time.deltaTime * growSpeed;
        }
        scale = Mathf.Clamp(scale, minScale, maxScale);
        //scale = Mathf.Clamp(scale, minScale, maxScale);
        for (int i = 0; i < line.Count; i++)
        {
            line[i].transform.localScale = new Vector3(1, scale, 1);
        }
        Anzuelo.transform.position = puntaHilo.transform.position;
    }
}
