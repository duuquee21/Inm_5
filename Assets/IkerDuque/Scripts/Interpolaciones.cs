using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpolaciones : MonoBehaviour
{
    public Transform ObjetoAMover;
    public Vector3 posInicial = new Vector3 (0, 0, 0);
    public Vector3 posFinal = new Vector3(10, 0, 0);
    public float duracion = 5f;
    public float temporizador = 0f;

    public Light luz;
    public Color colorInicial = Color.red;
    public Color colorFinal = Color.green;
    void Start()
    {
        Invoke("MiFuncion", 3.0f);
        InvokeRepeating("MiFuncion", 3.0f, 4.0f);
    }

   
    void Update()
    {
        temporizador += Time.deltaTime;
        float t = Mathf.Clamp01(temporizador/duracion);
        ObjetoAMover.position = Vector3.Lerp(posInicial,posFinal,t);

        luz.color = Color.Lerp(colorInicial,colorFinal,t);
    }

    void MiFuncion()
    {
        Debug.Log("Mi funcion ha sido invocada");
    }

    
}
