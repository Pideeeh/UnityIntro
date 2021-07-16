using UnityEngine;

// Löst explosion aus, wenn das objekt berührt wird
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class Explosion : MonoBehaviour
{
    //Visueller effekt, kann im editor konfiguriert werden
    public GameObject explosionEffect;
    private void OnCollisionEnter(Collision other)
    {
        //Erzeuge explosionskraft
        GetComponent<Rigidbody>().AddExplosionForce(1000, transform.position, 4);
        //Erzeuge explosions effekt
        Instantiate(explosionEffect, other.GetContact(0).point, Quaternion.identity);
    }
}