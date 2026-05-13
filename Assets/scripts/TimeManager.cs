using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo;

    private float tiempo = 0f;

    public bool gameOver = false;

    void Update()
    {
        if (!gameOver)
        {
            tiempo += Time.deltaTime;

            textoTiempo.text = "Tiempo: " + tiempo.ToString("F2");
        }
    }
}