using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("asteroide")) 
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
