using UnityEngine;

public class Limit : MonoBehaviour
{
    public Score score;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            Destroy(collision.gameObject);
            score.UpdateScore(100);
        }
        else if (collision.gameObject.tag == "bonus")
        {
            Destroy(collision.gameObject);
        }
    }
}
