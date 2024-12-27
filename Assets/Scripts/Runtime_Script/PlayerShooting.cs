using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Vector3 bulletOffset = new Vector3(0, 0f, 0);
    public GameObject bulletPrefab;
    float fire1Delay = 0.2f;
    // float fire2Delay = 5f;
    float cooldownTimer1 = 0f;
    // float cooldownTimer2 =  0f;
    [SerializeField] string inputNameFireX_1;
    // [SerializeField] string inputNameFireX_2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        cooldownTimer1 -= Time.deltaTime;
        if (Input.GetButton(inputNameFireX_1) && cooldownTimer1 <= 0) {
            cooldownTimer1 = fire1Delay;

            Vector3 offset = transform.rotation * bulletOffset;
            //Clone bullet at ship position and its rotation        
            Instantiate (bulletPrefab, transform.position + offset, transform.rotation);
        }

       
    }
}
