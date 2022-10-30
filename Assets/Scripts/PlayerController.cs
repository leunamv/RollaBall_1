using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameOverScript GameOverScript;
    int maxPlattform = 0;

    public void GameOver()
    {
    GameOverScript.SetUp(maxPlattform);



    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Cuando pulse tecla  flecha izquierda mover a izquierda

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector2.left * 300 * Time.deltaTime);
        }
       // if (Input.GetKey(KeyCode.S))
      //  {
       //     GetComponent<Rigidbody>().AddForce(Vector2.left * 0 * Time.deltaTime);//HAY QUE BUSCAR EL STOP
      //  }
        //Cuando pulse tecla  flecha derecha  mover a derecha

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector2.right * 300 * Time.deltaTime);
        }
        //Cuando pulse tecla  flecha arriba  mover adelante

        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 300 * Time.deltaTime);
            // transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }
        //Cuando pulse tecla  flecha abajo  mover atras

        if (Input.GetKey(KeyCode.DownArrow))
        {

            GetComponent<Rigidbody>().AddForce(Vector3.forward * -300 * Time.deltaTime);

            // transform.Translate(Vector3.forward * -5 * Time.deltaTime);
            //AL PONER NUMERO NEGATIVO SE SUPONE EN SENTIDO CONTRARIO
        }
       
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.down * 10 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene(0);

        }


    }

}

