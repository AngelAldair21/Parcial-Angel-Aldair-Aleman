using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAsteroide : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;

    private void Update()
    {
        transform.Translate(0f,0f, -1f * velocidadMovimiento * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Nave"))
        {
            Destroy(this.gameObject);
        }
    }
}
