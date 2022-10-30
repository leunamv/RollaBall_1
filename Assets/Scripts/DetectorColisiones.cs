using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColisiones : MonoBehaviour
{
    public int puntos;
    public GameObject ObjPuntuacion;
    private void OnTriggerEnter(Collider other)
    {
        ObjPuntuacion.GetComponent<Puntuacion>().puntos += 10;
        Destroy(gameObject);
    }
}
