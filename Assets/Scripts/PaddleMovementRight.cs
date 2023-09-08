using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovementRight : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f; // Velocidad de movimiento vertical
    public float limiteSuperior = 3.0f; // Límite superior de movimiento
    public float limiteInferior = -3.0f; // Límite inferior de movimiento

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoVertical = 0f; // Inicializamos el movimiento vertical como 0

        // Verificamos si se presiona la tecla "I"
        if (Input.GetKey(KeyCode.I))
        {
            movimientoVertical = 1f; // Si se presiona "I", establecemos el movimiento vertical como 1 (hacia arriba)
        }
        // Verificamos si se presiona la tecla "K"
        else if (Input.GetKey(KeyCode.K))
        {
            movimientoVertical = -1f; // Si se presiona "K", establecemos el movimiento vertical como -1 (hacia abajo)
        }

        // Calcula la nueva posición
        Vector3 posicionNueva = transform.position + new Vector3(0, movimientoVertical * velocidadMovimiento * Time.deltaTime, 0);

        // Limita la posición dentro de los límites
        posicionNueva.y = Mathf.Clamp(posicionNueva.y, limiteInferior, limiteSuperior);

        // Aplica la nueva posición al objeto
        transform.position = posicionNueva;
    }
}
