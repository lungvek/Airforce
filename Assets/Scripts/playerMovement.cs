using UnityEngine;

public class playerMovement : MonoBehaviour {

//initialization
float maxSpeed = 3.0f;
void Start() {

}

void Update() {
    // return a FLOAT from -1.0 to +1.0
    
    Vector3 pos = transform.position;

    pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
    // pos.y += Input.GetAxis("Vertical");
    transform.position = pos;
    // transform.position.y = 
}
}


