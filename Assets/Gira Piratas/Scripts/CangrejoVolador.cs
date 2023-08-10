using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CangrejoVolador : MonoBehaviour
{   
    public Rigidbody rb;
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("ManitosOculus")){
        rb.AddForce(-100f, 500f, 0);
        } 
    }
    }
