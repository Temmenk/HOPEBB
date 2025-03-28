using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce= 500f;
    public ParticleSystem particles;
    void Start()
    {
        
    }

 
    void FixedUpdate()
    {
        /// Speed Baby!!!
        rb.AddForce(0, 0, forwardForce *  Time.deltaTime);

        if( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (particles != null && particles.isPlaying)
            {
                particles.Stop(); // Stop particle system
            }
        }
    }
}
