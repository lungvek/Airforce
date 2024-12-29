using UnityEngine;

public class InvulnerableHandler : MonoBehaviour {

    int correctLayer;
    public float invulnTimer;
    void Start () {
        correctLayer = gameObject.layer;
    }

    void OnTriggerEnter2D () {
        invulnTimer = 2f;
        invuln();
    }

    void invuln () {
        gameObject.layer = 10;
    }
    void Update () {
        
        if (invulnTimer > 0) {
            invulnTimer -= Time.deltaTime;
        }
        else {
            gameObject.layer = correctLayer;
        }
    }
}