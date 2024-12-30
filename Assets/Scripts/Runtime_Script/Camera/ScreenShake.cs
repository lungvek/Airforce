using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public float shakeMagnitude = 0.1f; // Amount of shake
    public int shakeDuration = 30;     // Number of frames to shake
    private Vector3 originalPosition;  // Original position of the camera or object

    private void Start()
    {
        // Save the initial position of the object (e.g., camera)
        originalPosition = transform.localPosition;
        
    //     pos = transform.position;
    }

    // void shake(float dx, float dy){
    //     pos.x *= dx;
    //     pos.y *= dy;
    //     transformation.position 
    // }
    public void TriggerShake()
    {
        // StopAllCoroutines(); // Stop any existing shakes
        StartCoroutine(ShakeCoroutine());
        Debug.Log("Shake called");
    }

    private System.Collections.IEnumerator ShakeCoroutine()
    {
        for (int i = 0; i < shakeDuration; i++)
        {
            // Generate random offsets for X and Y within the range
            float offsetX = Random.Range(-shakeMagnitude, shakeMagnitude);
            float offsetY = Random.Range(-shakeMagnitude, shakeMagnitude);

            // Apply the offset
            transform.localPosition = originalPosition + new Vector3(offsetX, offsetY, 0);

            // Wait for the next frame
            yield return null;
            yield return null;
        }

        // Reset position to the original
      transform.localPosition = originalPosition;
    }
}

