using UnityEngine;

public class Limit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            Destroy(collision.gameObject);
        }
    }
}
