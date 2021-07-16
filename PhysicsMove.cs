using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Stellt sicher dass Objekt Rigidbody hat
[RequireComponent(typeof(Rigidbody))]
public class PhysicsMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody lässt uns die Physikalischen eigenschaften des Objektes verändern
        var rigidbody = GetComponent<Rigidbody>();

        var speed = 1;
        var richtung = transform.forward;

        //Ab jetzt bewegt sich das objekt mit 1 m/s nach vorne
        rigidbody.velocity = speed * richtung;

        var rotation = new Vector3(0, 0, 10);
        //Ab jetzt dreht sich das Objekt um 10 grad pro sekunde
        rigidbody.angularVelocity = rotation * Mathf.Deg2Rad;
    }
}