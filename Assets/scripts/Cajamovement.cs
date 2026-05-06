using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cajamovement : MonoBehaviour
{
    public float speed;




    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed, 0);
    }
   
void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Caja"))
        {
            Destroy(gameObject);
        }
    }

}


