using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    [SerializeField] public Vector3 force;

    private bool shoot;
    private Rigidbody rb;
    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
            shoot = true;
    }

    private void FixedUpdate()
    {
        HandleShoot();
    }

    private void HandleShoot()
    {
        if (!shoot) return;
        
        rb.position = initialPosition;
        rb.velocity = force;
        shoot = false;
    }
}