using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
        int Score = 0;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Hit")
        {
            Score--;
            Puntaje();
        }
        if(other.gameObject.tag == "Coin")
        {
            Score++;
            Puntaje();
        }
        
        if(Score > 9)
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
        }

        if(Score < -9)
        {
            Debug.Log("Perdiste");
        }


    }
    void Puntaje()
    {
        Debug.Log(Score + " puntos");
    }


}
