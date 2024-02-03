using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float SpinSpeed = 0f;
    [SerializeField] float CoinSpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yRotation = SpinSpeed * Time.deltaTime;
        float zRotation = CoinSpeed * Time.deltaTime;
        transform.Rotate(0f, yRotation, zRotation);
    }
}
