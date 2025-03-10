using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class fuerzas : MonoBehaviour
{
    public int contadorMoneda;
    public TMP_Text Contador;
    public TMP_Text mensajeVictoria; // Texto para "YOU WIN"
    public float speed = 1f;

    private int totalMonedas; // Número total de monedas en la escena
    public Transform pelota; // Referencia a la pelota
    void Start()
    {
       
        totalMonedas = GameObject.FindGameObjectsWithTag("Moneda").Length;
        actualizarContador();
        mensajeVictoria.gameObject.SetActive(false); 
    }


    // Update is called once per frame
    void Update()
    {
        if (contadorMoneda == totalMonedas)
        {
            MostrarVictoria();
        }
    }

    public void aumentarContador()
    {
        contadorMoneda++;
        actualizarContador();
    }

    public void actualizarContador()
    {
        Contador.text = "Monedas: " + contadorMoneda;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moneda"))
        {

            Destroy(other.gameObject);
            aumentarContador();
        }
    }

    private void MostrarVictoria()
    {
        mensajeVictoria.gameObject.SetActive(true); 
        mensajeVictoria.text = "YOU WIN";

        // Hacer que el texto siga la posición de la pelota
        Vector3 posicionTexto = pelota.position + Vector3.up * 1.5f; 
        mensajeVictoria.transform.position = posicionTexto;
    }




    private void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");


        Vector3 movimiento = new Vector3(movHorizontal, 0, movVertical);

        this.GetComponent<Rigidbody>().AddForce(movimiento * speed);
    }
}
