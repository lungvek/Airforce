using UnityEngine;

public class UpdateEnemyCounts : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ScreenShake screenShake;
    public EnemySpawner enemySpawner;
    void Start()
    {
    screenShake = FindObjectOfType<ScreenShake>();

        if (screenShake == null)
        {
            Debug.LogError("ScreenShake component not found in the scene.");
        }
    }

    void OnDestroy() {
        screenShake.TriggerShake();
        enemySpawner.ReduceEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        screenShake = FindObjectOfType<ScreenShake>();
    }
}
