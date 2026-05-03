using UnityEngine;

public class Ej3 : MonoBehaviour
{
    public float aceleracion = 1000f;
    public float frenado = 500f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * aceleracion, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * frenado, ForceMode.Force);
        }
    }
}
