using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public int health = 1;
    public float invulnTimer = 0f;
    public int correctLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        correctLayer = gameObject.layer;
    }

    // Update is called once per frame
    
    void OnTriggerEnter2D() {
        {
            health --;
            invulnTimer = 2f;    
            gameObject.layer = 10;

        }

    }

    void Die() {
        Destroy(gameObject);
    }

    void Update()
    {
        invulnTimer -= Time.deltaTime;  

        if (invulnTimer <= 0) {
            gameObject.layer = correctLayer;
        }
        if (health <= 0) {
            Die();
        }
    }
}
