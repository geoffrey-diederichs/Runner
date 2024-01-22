using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public Obstacles obstacleModel;
    private float spawnRate = 2.0f;
    private float nextSpawn = 0.0f;
    private float speedInc = 0.0f;

    private void Update()
    {
        if (Time.time >= this.nextSpawn)
        {
            this.Spawn();
            nextSpawn = Time.time + spawnRate;

            if (spawnRate > 1.5f)
            {
                spawnRate -= 0.05f;
            }
        }
    }

    private void Spawn()
    {
        Obstacles obstacle = Instantiate(this.obstacleModel, this.transform.position, new Quaternion());
        obstacle.SetSpeed(this.speedInc);
        this.speedInc += 0.01f;
    }
}
