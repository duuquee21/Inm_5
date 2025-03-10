using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class fuerzas : MonoBehaviour
{
    public int contadorMoneda;
    public TMP_Text mensajeVictoria;
    public TMP_Text Contador;
    public float speed = 1f;
    private int totalMonedas;
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
            GanarJuego();
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

    private void GanarJuego()
    {
        mensajeVictoria.text = "YOU WIN"; // Mostrar mensaje de victoria
        mensajeVictoria.gameObject.SetActive(true); // Hacer visible el texto
        Time.timeScale = 0; // Detener la escena
    }




    private void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");


        Vector3 movimiento = new Vector3(movHorizontal, 0, movVertical);

        this.GetComponent<Rigidbody>().AddForce(movimiento * speed);
    }
}
