using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameObject focalPoint;
    private float powerUpStrength = 10.0f;
    public float speed = 5.0f;
    public bool hasPowerup = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }
    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
    
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Powerup"))
        {
            hasPowerup = false ;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }
     IEnumerator PowerupCountdownRoutine()
     {
         yield return new WaitForSeconds(7);
         hasPowerup = false;
     }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy" && hasPowerup);
        {
           // Debug.Log(collision.gameObject.tag);
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = transform.position - other.gameObject.transform.position = other.gameObject.transform.position - transform.position;

            enemyRigidbody.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
            Debug.Log("Collided with: " + collision.gameObject.name + "with powerup set to" + hasPowerup);
        }
    }
}
