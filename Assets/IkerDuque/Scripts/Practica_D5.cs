using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica_D5 : MonoBehaviour
{
    public Transform ObjetoAMover;
    public Vector3 posInicial = new Vector3(0, 0, 0);
    public Vector3 posFinal = new Vector3(10, 0, 0);
    public float duracion = 5f;
    public float temporizador = 0f;
    public float suavizado = 1f;
    public Transform Destino;
    public Transform Inicio;
    private Quaternion startRot;
    private Quaternion endRot;

    void Start()
    {
        StartCoroutine(MiCorutina(Destino));
        Debug.Log("El script sigue");
    }

    // Update is called once per frame
    void Update()
    {
        float t = Mathf.Clamp01(temporizador / duracion);

    }
    IEnumerator MiCorutina(Transform Destino)
    {
        Debug.Log("Se inicia la rutina");
        while (Vector3.Distance(transform.position, Destino.position) > 0.5f)
        {
            Debug.Log("Moviendo");
            transform.position = Vector3.Lerp(transform.position, Destino.position, suavizado * Time.deltaTime);
            yield return null; // devuelve el control de pintado al hilo principal
        }
        Debug.Log("Se acaba el while");
        yield return new WaitForSeconds(1f); // pausar la ejecucion 3s
        Quaternion targetRotation= Quaternion.Euler(0f, 90f, 0f);

        
        while (Vector3.Distance(transform.position, Inicio.position) > 0.5f)
        {
            Debug.Log("Moviendo");
            transform.position = Vector3.Lerp(transform.position, Inicio.position, suavizado * Time.deltaTime);
            yield return null; // devuelve el control de pintado al hilo principal
        }
    }
   

       
    
}
