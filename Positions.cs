using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positions : MonoBehaviour
{
    void Start()
    {
        // = Position des Objektes auf dem das Script ist
        var position1 = transform.position;

        // = Absolute position im Koordinatensystem (X=1, Y=2, Z=3)
        var position2 = new Vector3(1, 2, 3);

        // = Position 2 meter vor eigenem Objekt
        var position3 = transform.position + (2 * transform.forward);

        // = Position 2 meter über eigenem Objekt
        var position4 = transform.position + (2 * transform.up);

        // = Position 3 meter rechts neben eigenem Objekt
        var position5 = transform.position + (3 * transform.right);

        // = Position 1 meter links neben eigenem Objekt
        var position6 = transform.position - (1 * transform.right);

        // = Position wo Mauszeiger hinzeigt
        var position7 = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // = Position genau zwischen Kamera und objekt
        var position8 = (transform.position + Camera.main.transform.position) / 2;
    }
}