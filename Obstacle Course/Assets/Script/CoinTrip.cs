using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrip : MonoBehaviour
{
    public GameObject Moneda;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Nati")
        {
            Moneda.SetActive(false);
        }
    }
}
