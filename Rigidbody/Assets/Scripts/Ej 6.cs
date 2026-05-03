using UnityEngine;

public class Ej6 : MonoBehaviour
{
    public float aceleracion = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(h, 0, v);
        rb.AddForce(direccion * aceleracion, ForceMode.Acceleration);
    }
}
