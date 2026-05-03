using UnityEngine;

public class Ej8 : MonoBehaviour
{
    public float fuerzaExplosion = 500f;
    public float radio = 5f;
    public float upwardsModifier = 2f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Explode();
        }
    }

    void Explode()
    {
        Vector3 explosionPos = transform.position;

        Collider[] colliders = Physics.OverlapSphere(explosionPos, radio);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(fuerzaExplosion, explosionPos, radio, upwardsModifier, ForceMode.Impulse);
            }
        }
    }
}
