using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGravityOnCollision : MonoBehaviour
{
    // Referencias a los Rigidbody que queremos modificar
    public Rigidbody Coco1;
    public Rigidbody Coco2;
    public Rigidbody Coco3;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Se colisiono con algo");
        // Verificar si el objeto que colisionó tiene el mismo tag que deseas
        if (collision.gameObject.CompareTag("CaerCoco"))
        {
            Debug.Log("Se colisiono con algo con el tag CaerCoco");
            // Activar la gravedad en los Rigidbody
            Coco1.useGravity = true;
            Coco2.useGravity = true;
            Coco3.useGravity = true;
        }
    }
}