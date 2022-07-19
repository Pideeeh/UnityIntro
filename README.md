# UnityIntro
This is a collection of Unity focused C# snippets to introduce users with low or no experience in programming to basic scripting in Unity


# Hier findet ihr kleine Beispiele für Unity Scripts.
## Ihr könnt euch gerne teile rauskopieren und für eure eigenen Scripts wiederverwenden



# Hier sind die Objekttypen die ihr verwenden werdet:

### Material:
Beschreibt Farbe und Erscheinungsbild eines Objektes

### Script:
Beschreibt Verhalten eines Objektes (code)

### Physics Material:
Beschreibt physikalisches Verhalten eines Objektes (Bounciness, Reibung)

# Hier sind ein paar kleine Code Teile die ihr euch zusammenkopieren könnt:

## Ich möchte dass etwas bei Tastenklick passiert:
Welches Objekt betrifft das "etwas"? -> Gehe zum Unity Editor, füge neues Script auf das jeweilige Objekt

Tastendruck: In der Update Methode im neu erstellten Script:
```
        if (Input.GetKeyDown(KeyCode.Space))
        {
         // der code hier wird ausgeführt wenn die Leertaste gedrückt wird  
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // der code hier wird ausgeführt wenn die Leertaste losgelassen wird  
        }
        if (Input.GetKey(KeyCode.Space))
        {
            // der code hier wird ausgeführt solange die Leertaste gedrückt wird  
        }
```
Keycode kann natürlich auf die gewünschte Taste geändert werden: siehe: https://docs.unity3d.com/ScriptReference/KeyCode.html

## Ich möchte die Farbe eines Objektes ändern:
1. Unter Zeile mit "class" einfügen: (Dann wird das Material im Unity Editor konfigurierbar)
```
public Material mat1;
```
2. Zu dem Zeitpunkt im code an dem der Farbwechsel passieren soll:

```
        GetComponent<MeshRenderer>().material = mat1;
```

## Ich möchte das Spiel neu starten (Spieler hat verloren):
```
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
```

## Ich möchte ein Objekt (mit Rigidbody bewegen, z.B. springen lassen):
```
        GetComponent<Rigidbody>().velocity = Vector3.up * 3;
```

## Ich möchte ein Objekt klonen (spawnen):
1. Unter Zeile mit "class" einfügen: (Dann wird das Material im Unity Editor konfigurierbar)
```
public GameObject spawnObject;
```
2. Zu dem Zeitpunkt im code an dem der Spawn passieren soll:

```
        Instantiate(spawnObject, transform.position, transform.rotation);
```

## Ich möchte auf eine Kollision reagieren:
Das objekt das reagieren soll benötigt einen Collider und ein Script:

Im script: 
```
private void OnCollisionEnter(UnityEngine.Collision collision)
    {
       // code ... was soll bei collision passieren.   
    }
```


## Ich möchte wissen mit welchem Objekt A ein Objekt B kollidiert:
Das objekt das reagieren soll benötigt einen Collider und ein Script:

1. Das Objekt das ihr behandeln wollt Taggen: (Im Unity Editor)
![image](https://user-images.githubusercontent.com/4976623/179763756-de7028ea-ded9-4b2b-b04b-75f232ed306e.png)


2. Im script: 
```
private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("MyTag"))
        {
            // dieser code wird ausgeführt wenn dieses Objekt mit dem "MyTag" objekt kollidiert
        }
    }
```

## Ich möchte ein Objekt zerstören sobald es kollidiert:
Das objekt das reagieren soll benötigt einen Collider und ein Script:
1. Im script: 
```
private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Destroy(gameObject);
    }
```


# Nützliche Basiskomponenten aus dem Asset store:
### First Person Controller:
https://assetstore.unity.com/packages/3d/characters/modular-first-person-controller-189884

### Terrain Pack (für schöne Landschaften)
https://assetstore.unity.com/packages/3d/environments/landscapes/terrain-sample-asset-pack-145808

### Verschiedene Materials und Texturen für eure Objekte:
https://assetstore.unity.com/?free=true&q=materials&orderBy=1

### Sonstige Objekte: Einfach fragen, ich kann euch gerne beim suchen helfen.

### Car controller:
-> Meldet euch bei mir.
