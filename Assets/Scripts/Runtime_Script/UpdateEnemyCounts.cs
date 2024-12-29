using UnityEngine;

public class UpdateEnemyCounts : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public EnemySpawner enemySpawner;

    void Start()
    {

    }

    void OnDestroy() {
        enemySpawner.ReduceEnemy();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
