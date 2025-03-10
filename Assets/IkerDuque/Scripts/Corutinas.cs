using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corutinas : MonoBehaviour
{
    
    public Transform Destino;
    public float suavizado = 1f;
    void Start()
    {
        StartCoroutine(MiCorutina(Destino));
        Debug.Log("El script sigue");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // interpolar hasta que llegue al destino
    IEnumerator MiCorutina(Transform Destino)
    {
        Debug.Log("Se inicia la rutina");
        while (Vector3.Distance(transform.position, Destino.position)>0.5f)
        {
            Debug.Log("Moviendo");
            transform.position = Vector3.Lerp(transform.position, Destino.position, suavizado*Time.deltaTime );
            yield return null; // devuelve el control de pintado al hilo principal
        }
        Debug.Log("Se acaba el while");
        yield return new WaitForSeconds(3f); // pausar la ejecucion 3s
        Debug.Log("Se acaba la rutina");
    }
}
