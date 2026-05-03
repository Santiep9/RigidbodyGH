using UnityEngine;

public class Ej1 : MonoBehaviour
{
    public float fuerza = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * fuerza, ForceMode.Force);
        }
    }
}
