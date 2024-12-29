using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Vector3 bulletOffset = new Vector3(0, 0f, 0);
    public GameObject bulletPrefab;
    public float fire1Delay;
    // float fire2Delay = 5f;
    public float cooldownTimer1 = 0;
    // float cooldownTimer2 =  0f;
    [SerializeField] string inputNameFireX_1;
    // [SerializeField] string inputNameFireX_2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
     {
        cooldownTimer1 -= Time.deltaTime;
     
        if ((cooldownTimer1 <= 0) && Input.GetButton(inputNameFireX_1)) {
            cooldownTimer1 = fire1Delay;

            Vector3 offset = transform.rotation * bulletOffset;
            //Clone bullet at ship position and its rotation        
            Instantiate (bulletPrefab, transform.position + offset, transform.rotation);
        }

       
    }
}
