using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float TimeFall = 5f;
    Rigidbody bodier;
    MeshRenderer renderer;
    void Start()
    {
        bodier = GetComponent<Rigidbody>();
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        bodier.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TimeFall)
        {
            Caida();
        }
    }

    void Caida()
    {
        renderer.enabled = true;
        bodier.useGravity = true;
    }
}
