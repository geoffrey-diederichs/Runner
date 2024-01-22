using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    private float speed = 0.25f;
    
    private void Update()
    {
        transform.Translate(Vector2.left*this.speed);
    }
}
