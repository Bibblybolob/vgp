using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private float speed = 20F;
    private float turnSpeed = 45F;
    private float horizontalInput = 25F;
    private float forwardInput = 0F;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Moves the car forward based on verticle input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Move the vehicle forward
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
        // turns the car so it doesnt look like it is gliding left and right
    }
}
