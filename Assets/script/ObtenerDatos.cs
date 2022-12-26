using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObtenerDatos : MonoBehaviour
{
    public Text txtPuntos;
    // Start is called before the first frame update
    void Start()
    {
        txtPuntos.text= GameController.puntos.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
