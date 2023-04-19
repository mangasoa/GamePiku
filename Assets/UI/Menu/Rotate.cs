using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] int vitesse = 10;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * vitesse * Time.deltaTime); 
    }
}
