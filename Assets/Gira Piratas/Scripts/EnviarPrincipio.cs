using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoverAlInicio : MonoBehaviour
{
    public Vector3 MoverA = new Vector3(-4.513f, 0.65f, -3.89f);
    public GameObject player; 

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = MoverA;
    }
}