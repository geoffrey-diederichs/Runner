using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private new Rigidbody2D rb;
    private float speed = 0.25f;
    private int lifetime = 5;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        int rand = Random.Range(0,5);
        if (rand == 0)
        {
            transform.localScale = new Vector3(0.5f, 3.0f, 1.0f);
        }
        else if (rand == 1)
        {
            transform.localScale = new Vector3(5.0f, 1f, 1.0f);
        }
    }

    private void Update()
    {
        transform.Translate(Vector2.left*this.speed);
    }

    private void Start()
    {
        Destroy(this.gameObject, this.lifetime);
    }
}
