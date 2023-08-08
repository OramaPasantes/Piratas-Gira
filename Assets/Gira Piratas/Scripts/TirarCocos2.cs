using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarGravedadEnColision2 : MonoBehaviour
{
    public Rigidbody Coco4;
    public Rigidbody Coco5;
    public Rigidbody Coco6;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CocoCaer2"))
        {
            Coco4.useGravity = true;
            Coco5.useGravity = true;
            Coco6.useGravity = true;
        }
    }
}