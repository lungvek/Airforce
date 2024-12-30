using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigger : MonoBehaviour {

    // public ParticleSystem explosion;
    public CamShake camShake;

    void Start () {

    }
    void OnDestroy() {
        // explosion.Play();
        StartCoroutine(camShake.Shake(.15f, .4f));
    }
    void Update () {
        
    }
}