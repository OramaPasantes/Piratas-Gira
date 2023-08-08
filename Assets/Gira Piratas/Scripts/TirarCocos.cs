using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarGravedadEnColision : MonoBehaviour
{
    public Rigidbody Coco1;
    public Rigidbody Coco2;
    public Rigidbody Coco3;

    private void OnCollisionEnter(Collision collision)
    {
        // Verificar si el objeto que colisionó tiene el mismo tag que deseas
        if (collision.gameObject.CompareTag("CocoCaer"))
        {
            // Activar la gravedad en los Rigidbody
            Coco1.useGravity = true;
            Coco2.useGravity = true;
            Coco3.useGravity = true;
        }
    }
}