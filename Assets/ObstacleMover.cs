using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ObstacleMover : MonoBehaviour
{
    private Transform player;
    public float triggerDistance = 15f;
    public float forceStrength = 5f;
    private bool hasMoved = false;
    private Rigidbody rb;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!hasMoved && Vector3.Distance(transform.position, player.position) <= triggerDistance)
        {
            Vector3 randomDirection = new Vector3(
                Random.Range(-1f, 1f),
                0f, // Keep it on the ground (no vertical force)
                Random.Range(-1f, 1f)
            ).normalized;

            rb.AddForce(randomDirection * forceStrength, ForceMode.Impulse);

            hasMoved = true;
        }
    }
}
