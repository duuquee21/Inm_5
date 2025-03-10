using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Monedas : MonoBehaviour
{




    [SerializeField] private Vector3 velocidadRotacion = new Vector3(0f, 100f, 0f); // Velocidad de rotación en grados por segundo.

    void Update()
    {
        // Aplica rotación constante.
        transform.Rotate(velocidadRotacion * Time.deltaTime);
    }
}


