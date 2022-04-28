using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Camera : MonoBehaviour
{
    
    public Camera gameCamera;       //Objeto c�mara
    public float horizontalSpeed;   //Velocidad horizontal de la c�mara
    public float verticalSpeed;     //Velocidad vertical de la c�mara
    public float horizontalRotationSpeed;   //Velocidad horizontal de rotaci�n
    public float verticalRotationSpeed;     //Velocidad vertical de rotaci�n
    float hor;      //Movimiento horizontal
    float ver;      //Movimiento vertical

    void Update()   //En cada frame
    {
        //Movimiento de la c�mara
        //Guardar el movimiento de las flechas en las variables hor y ver
        hor = horizontalSpeed * Input.GetAxis("Mouse X") * horizontalRotationSpeed;
        ver = verticalSpeed * Input.GetAxis("Mouse Y") * verticalRotationSpeed;

        //transform.Rotate(0, hor, 0);             //Mover horizontalmente
        gameCamera.transform.Rotate(-ver, hor, 0);  //Mover verticalmente horizontalmente

        //Movimiento del jugador
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0.1f);                 //Mover hacia adelante
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.1f);            //Mover hacia atr�s
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0, 0);        //Mover hacia la izquierda
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0, 0);     //Mover hacia la derecha
        }
    }
}
