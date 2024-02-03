using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{   
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Nati")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit";
        }
    }
}
