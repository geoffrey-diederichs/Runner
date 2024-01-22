using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private new Rigidbody2D rb;
    private float speed = 0.2f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        int rand = Random.Range(0,4);
        if (rand == 0)
        {
            transform.localScale = new Vector3(1.0f, Random.Range(3,4), 1.0f);
        }
        else if (rand == 1)
        {
            transform.localScale = new Vector3(Random.Range(3,5), 1.0f, 1.0f);
        }
    }

    private void Update()
    {
        transform.Translate(Vector2.left*this.speed);
    }

    private void Start()
    {
    }

    public void SetSpeed(float speedInc)
    {
        this.speed += speedInc;
    }
}
