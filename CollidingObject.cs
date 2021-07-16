using UnityEngine;

//Stellt sicher, dass das Objekt einen Collider hat
[RequireComponent(typeof(Collider))]
public class CollidingObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log($"{gameObject.name} kollidiert mit {other.gameObject.name}");
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log($"{gameObject.name} kollidiert nicht mehr mit {other.gameObject.name}");
    }
}