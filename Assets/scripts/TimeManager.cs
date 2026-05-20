using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo;

    float tiempo = 0f;
    public bool juega = true;

    void Update()
    {
        if (juega)
        {
            tiempo += Time.deltaTime;
        }

        textoTiempo.text = tiempo.ToString("F2");

        
    }
    public void stop(){
        juega = false;
    }
}