using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coloring : MonoBehaviour
{
    // Variable für Material. Kann im Unity editor ausgewählt werden
    public Material material1;

    // Variable für Material. Kann im Unity editor ausgewählt werden
    public Material material2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Wenn Y gedrückt wird
        if (Input.GetKeyDown(KeyCode.Y))
        {
            //Setze objekt auf material 1
            GetComponent<MeshRenderer>().material = material1;
        }

        //Wenn Y wieder losgelassen wrid
        if (Input.GetKeyUp(KeyCode.Y))
        {
            //Setze objekt auf material 2
            GetComponent<MeshRenderer>().material = material2;
        }
    }
}