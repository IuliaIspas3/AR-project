using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    [Header("Orbit Settings")]
    public Transform orbitCenter; // usually the Sun
    public float orbitSpeed = 10f; // degrees per second
    public float rotationSpeed = 50f; // planet's own spin

    void Update()
    {
        if (orbitCenter != null)
        {
            // Orbit around the sun
            transform.RotateAround(orbitCenter.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }

        // Rotate around its own axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}