using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private CajaSpawn cajaSpawn;

    void Start()
    {
        cajaSpawn = GetComponent<CajaSpawn>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cajaSpawn.gameOver = true;

            Destroy(other.gameObject);

            Debug.Log("GAME OVER");
        }
    }
}