using UnityEngine;

public class playerMovement : MonoBehaviour
{

    float maxSpeed = 5f;
    float rotSpeed = 180f;
    float shipBoundaryRadius = 0.5f;
    [SerializeField] string inputNameHorizontal;
    [SerializeField] string inputNameVertical;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ROTATE THE SHIP

        //Grab our rotation quaternion
        Quaternion rot = transform.rotation;

        //Grab the Z euler angle
        float z = rot.eulerAngles.z;

        //Change the Z angle based on input
        z -= Input.GetAxis(inputNameHorizontal) * rotSpeed * Time.deltaTime;

        //Recreate the quaternion
        rot = Quaternion.Euler( 0, 0, z );

        //Feed the quaternion into our rotation
        transform.rotation = rot;

        //MOVE THE SHIP
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3( 0, Input.GetAxis(inputNameVertical) * maxSpeed * Time.deltaTime, 0 );

        pos += rot * velocity;

        if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize) {
            pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
        }
        if (pos.y - shipBoundaryRadius < - Camera.main.orthographicSize) {
            pos.y = - Camera.main.orthographicSize + shipBoundaryRadius;
        }

        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize *  screenRatio;

        if (pos.x + shipBoundaryRadius > widthOrtho) {
            pos.x = widthOrtho - shipBoundaryRadius;
        }
        if (pos.x - shipBoundaryRadius < - widthOrtho) {
            pos.x = - widthOrtho + shipBoundaryRadius;
        }

        //Update our position
        transform.position = pos;
        // Testing only. Jenney OwO krongly daisuki.
        //Testing KRongly
    }
}
