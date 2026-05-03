using UnityEngine;

public class Ej2 : MonoBehaviour
{
    public float fuerza = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 direccion = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) direccion += transform.forward;
        if (Input.GetKey(KeyCode.S)) direccion += -transform.forward;
        if (Input.GetKey(KeyCode.A)) direccion += -transform.right;
        if (Input.GetKey(KeyCode.D)) direccion += transform.right;

        rb.AddForce(direccion * fuerza, ForceMode.Force);
    }
}
