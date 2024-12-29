using UnityEngine;
public class EnemySpawner : MonoBehaviour {

    public UpdateEnemyCounts updateEnemyCount;
    public GameObject[] enemyPrefab;
    
    public float spawnDelay;
    public float spawnCooldown;
    public static int enemy1Alive;

    void Start() {
        enemy1Alive = 0; // Initialize the enemy count
    }

    public void ReduceEnemy() {
        if (enemy1Alive > 0) { // Ensure you don't go below zero
            enemy1Alive -= 1;
        }
    }

    void Update() {
        spawnCooldown -= Time.deltaTime;
        if (spawnCooldown <= 0 && enemy1Alive < 5) {
            spawnCooldown = spawnDelay;
            Instantiate(enemyPrefab[0], new Vector3(Random.Range(-5, 5), 5.5f, 0), transform.rotation);
            enemy1Alive += 1;
        }
    }
}
