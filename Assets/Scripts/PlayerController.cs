using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 6f;
    private Rigidbody rb;
    private int jumpCount = 0;
    public int maxJumps = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < maxJumps)
        {
            rb.linearVelocity = new Vector3(0f, jumpForce, 0f);
            jumpCount++;
        }

        if (transform.position.y < -10f)
        {
            GameManager.Instance.GameOver();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
        }

        if (collision.gameObject.CompareTag("Trap"))
        {
            GameManager.Instance.GameOver();
        }
    }

    void OnTriggerEnter(Collider other)
    {
    
        if (other.CompareTag("Trap"))
        {
            GameManager.Instance.GameOver();
        }

        if (other.CompareTag("Coin"))
        {
            ScoreManager.Instance?.IncrementScore();
            Destroy(other.gameObject);
        }
    }
}