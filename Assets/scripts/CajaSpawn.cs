using UnityEngine;

public class CajaSpawn : MonoBehaviour
{
    public float velocidadCaida = 5f;

    private float[] posicionesX = { -3f, 0f, 3f };

    public bool gameOver = false;

    void Start()
    {
        Respawn();
    }

    void Update()
    {
        if (gameOver)
            return;

        transform.Translate(Vector3.down * velocidadCaida * Time.deltaTime);

        if (transform.position.y < -5f)
        {
            velocidadCaida += 2f;

            Respawn();
        }
    }

    void Respawn()
    {
        int randomX = Random.Range(0, posicionesX.Length);

        transform.position = new Vector3(
            posicionesX[randomX],
            6f,
            0f
        );
    }
}