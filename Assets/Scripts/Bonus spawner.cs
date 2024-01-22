using UnityEngine;

public class Bonusspawner : MonoBehaviour
{
    public Bonus bonusModel;
    private float spawnRate = 5.0f;
    private float nextSpawn = 0.0f;

    private void Update()
    {
        if (Time.time >= this.nextSpawn)
        {
            this.Spawn();
            nextSpawn = Time.time + spawnRate;
        }
    }

    private void Spawn()
    {
        Bonus bonus = Instantiate(this.bonusModel, this.transform.position, new Quaternion());
    }
}
