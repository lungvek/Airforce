using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public int health = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
    }
    
    void OnTriggerEnter2D() {
        health --;
    }

    void Die() {
        Destroy(gameObject);
    }

    void Update()
    {
        if (health <= 0) {
            Die();
        }
    }
}
