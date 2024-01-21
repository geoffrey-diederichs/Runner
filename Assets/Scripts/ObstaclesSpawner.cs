using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public Obstacles obstacleModel;
    private int spawnRate = 3;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), this.spawnRate, this.spawnRate);
    }

    private void Spawn()
    {
        Obstacles obstacle = Instantiate(obstacleModel, this.transform.position, new Quaternion());
    }
}
