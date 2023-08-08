using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseCannon : MonoBehaviour
{
 public Rigidbody rb;
 public void OnTriggerEnter(Collider other){
  if (other.CompareTag("ManitosOculus")){
    Debug.Log("Se activo el cañon");
    rb.AddForce(0, 0, -1000f);
    Debug.Log(rb.position);
  }
   
 }
}
