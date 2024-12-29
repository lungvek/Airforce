using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Vector3 bulletOffset = new Vector3(0, 0f, 0);
    public GameObject bulletPrefab;

    float fireDuration;
    public float minFireDuration = 1f;
    public float maxFireDuration = 3f;
    public float fire1Delay = 0.25f;
    // float fire2Delay = 5f;
    float cooldownTimer1 = 0f;
    // float cooldownTimer2 =  0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        cooldownTimer1 -= Time.deltaTime;
        fireDuration -= Time.deltaTime;
        
        if (fireDuration >= 0) {
            
            if (cooldownTimer1 <= 0) {
                cooldownTimer1 = fire1Delay;

                Vector3 offset = transform.rotation * bulletOffset;
                //Clone bullet at ship position and its rotation        
                Instantiate (bulletPrefab, transform.position + offset, transform.rotation);
            }
        }

        //Delay before another barage
        else if (fireDuration <= 0 - (Random.Range(3, 5))) {
            fireDuration = Random.Range(minFireDuration, maxFireDuration);
        }


    }
}