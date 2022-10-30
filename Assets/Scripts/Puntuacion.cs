using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public int puntos;
    public Text textoPuntos;




    private void Update()
    {
        textoPuntos.text = "Puntos "+ puntos.ToString();
    }

}
