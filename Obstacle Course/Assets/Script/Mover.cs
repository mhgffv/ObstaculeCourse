using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubescript : MonoBehaviour {
     
    [SerializeField] float GroundSpeed = 10f;
    void Start()
    {
        Instructions();
    }

    void Update()
    {
        MuvmentPlayer();
    } 

    void Instructions()
    {
        Debug.Log("Hola Jugador, Te doy la bienvenida a mi juego, este es muy basico y solo es practico, estas aca solo para andar, te puedes mover con las teclas wasd las cuales te moveran para el frente atras y a los lados, espero te entretengas un rato.");
    }
    void MuvmentPlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * GroundSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * GroundSpeed * Time.deltaTime;

        transform.Translate(xValue, 0, zValue);   
    }

}
