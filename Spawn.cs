using UnityEngine;

public class Spawn : MonoBehaviour
{
    
    // Element kann im Unity Editor ausgewählt werden und ist über diese Variable für das Script Verfügbar
    public GameObject spawnObject;

    void Start()
    {
    }

    void Update()
    {
        // Bei Tastendruck auf "S"
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Wähle beliebige Position
            var position = transform.position;
            // Und rotation
            var rotation = Quaternion.identity;
            // Erzeuge Klon von Objekt welches in der Variable spawnObject gespeichert ist
            Instantiate(spawnObject, transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            //Zerstöre dich selbst
            Destroy(gameObject);
        }
    }
}