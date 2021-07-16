using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // nach vorne
        var richtung = transform.forward;
        // ein meter pro sekunde
        var speed = 1;
        
        //Bewegt objekt nach vorne mit 1 m/s (*Time.deltaTime ist hier sehr wichtig!)
        transform.Translate(richtung * speed * Time.deltaTime);

    }
}
