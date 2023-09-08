using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float velocidadMovimiento = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Obtén la entrada del teclado para mover hacia arriba o hacia abajo
        float movY = Input.GetAxis("Vertical");

        // Calcula el desplazamiento
        Transform transform = GetComponent<Transform>();
        Vector3 newPos = new Vector3(
            transform.position.x,
            Mathf.Clamp((transform.position.y + movY * velocidadMovimiento * Time.deltaTime), -3f, 3f),
            0f
            );

        // Aplica el desplazamiento al objeto
        transform.position = newPos;
    }

}
