using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController2 : MonoBehaviour
{
    public GameObject Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + new Vector3(10.0f, 5.0f, -10.0f);
    }
}
