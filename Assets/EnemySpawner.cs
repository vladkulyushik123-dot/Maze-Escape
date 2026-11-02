using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    void Start()
    {
        Instantiate(enemyPrefab, new Vector3(5, 1, 5), Quaternion.identity);
        Instantiate(enemyPrefab, new Vector3(-5, 1, 8), Quaternion.identity);
        Instantiate(enemyPrefab, new Vector3(10, 1, -5), Quaternion.identity);
        Instantiate(enemyPrefab, new Vector3(-10, 1, -8), Quaternion.identity);
        Instantiate(enemyPrefab, new Vector3(0, 1, 12), Quaternion.identity);
    }
}