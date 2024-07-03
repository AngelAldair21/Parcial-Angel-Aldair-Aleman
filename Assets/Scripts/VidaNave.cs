using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaNave : MonoBehaviour
{
    [SerializeField] public int vidaNave; 


   
    void Update()
    {
        if(vidaNave == 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("asteroide"))
        {
            vidaNave--;
            Destroy(collision.gameObject);
        }
    }
}
