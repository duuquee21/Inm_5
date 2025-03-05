using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class fuerzas : MonoBehaviour
{
    public int contadorMoneda;

    public TMP_Text Contador;
    public float speed = 1f;
    void Start()
    {
        actualizarContador();
    }

    // Update is called once per frame
    void Update()
    {
        actualizarContador();
        if (contadorMoneda == 7)
        {

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
   
    
  

    
   
    private void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");


        Vector3 movimiento = new Vector3(movHorizontal, 0, movVertical);

        this.GetComponent<Rigidbody>().AddForce(movimiento * speed);
    }
}
