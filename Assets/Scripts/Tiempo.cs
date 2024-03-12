using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Tiempo : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public float Tiemp = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tiemp -= Time.deltaTime;
        texto.text = "" + Tiemp.ToString("f2");

        if  (Tiemp < 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
