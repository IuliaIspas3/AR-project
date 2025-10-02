using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    [Header("Orbit Settings")]
    public Transform orbitCenter;          
    public float orbitSpeed = 10f;          
    [Tooltip("Direction of the orbital plane’s normal. Normalize if you set it in code.")]
    public Vector3 orbitAxis = Vector3.up;  
    [Header("Rotation Settings")]
    public float rotationSpeed = 50f;       
    [Tooltip("Planet’s axial tilt. 0 = perpendicular to orbitAxis.")]
    [Range(0f, 180f)]
    public float axialTilt = 23.5f;         
    private Vector3 spinAxis;               

    void Start()
    {
        spinAxis = Quaternion.AngleAxis(axialTilt, transform.right) * transform.up;
    }

    void Update()
    {
        if (orbitCenter != null)
        {
            transform.RotateAround(
                orbitCenter.position,
                orbitAxis.normalized,
                orbitSpeed * Time.deltaTime
            );
        }
        transform.Rotate(spinAxis, rotationSpeed * Time.deltaTime, Space.World);
    }
}