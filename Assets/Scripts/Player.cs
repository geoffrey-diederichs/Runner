using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int jumpForce = 800;
    private int secondJumpForce = 300;
    private bool grounded = false;
    private bool secondJump = false;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded == true)
            {
                rb.AddForce(Vector2.up*jumpForce);
                grounded = false;
            }
            else if (secondJump == true)
            {
                rb.AddForce(Vector2.up*secondJumpForce);
                secondJump = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if (grounded == false)
            {
                grounded = true;
                secondJump = true;
            }
        }
        else if (collision.gameObject.CompareTag("obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
