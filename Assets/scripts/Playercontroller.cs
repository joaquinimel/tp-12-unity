using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float[] posicionesX = { -3f, 0f, 3f };

    private int posicionActual = 1;

    void Start()
    {
        ActualizarPosicion();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (posicionActual > 0)
            {
                posicionActual--;
                ActualizarPosicion();
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (posicionActual < 2)
            {
                posicionActual++;
                ActualizarPosicion();
            }
        }
    }

    void ActualizarPosicion()
    {
        transform.position = new Vector3(
            posicionesX[posicionActual],
            transform.position.y,
            transform.position.z
        );
    }
}