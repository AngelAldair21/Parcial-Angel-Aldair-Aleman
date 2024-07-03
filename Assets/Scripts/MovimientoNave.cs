using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento; 

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        

        rb.velocity = new Vector2 (horizontal, 0) * velocidadMovimiento * Time.deltaTime;
    }

}
