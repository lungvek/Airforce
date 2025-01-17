using UnityEngine;

public class BulletMovement : MonoBehaviour {
    public float maxSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3( 0, maxSpeed * Time.deltaTime, 0 );

        pos += transform.rotation * velocity;

        transform.position = pos;
    }
}
