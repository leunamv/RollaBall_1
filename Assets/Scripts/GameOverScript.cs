using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverScript : MonoBehaviour { 

    public Text textoPuntos;

    public void SetUp(int puntos)
    {
        gameObject.SetActive(true);
        textoPuntos.text = "Puntos " + puntos.ToString();


    }


  
}
