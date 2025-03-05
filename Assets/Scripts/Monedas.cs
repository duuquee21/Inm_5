using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Monedas : MonoBehaviour
{




    [SerializeField] private Vector3 velocidadRotacion = new Vector3(0f, 100f, 0f); // Velocidad de rotaci�n en grados por segundo.

    void Update()
    {
        // Aplica rotaci�n constante.
        transform.Rotate(velocidadRotacion * Time.deltaTime);
    }
}


