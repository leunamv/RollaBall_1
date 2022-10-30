using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Trigger : MonoBehaviour
{
    public int puntos;
    public GameObject ObjPuntuacion;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        ObjPuntuacion.GetComponent<Puntuacion>().puntos += 10;
        Destroy(gameObject);
    }
}
