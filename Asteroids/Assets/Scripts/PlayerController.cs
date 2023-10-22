using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float thrustSpeed;
    private bool isThrusting;
    private bool isShooting;
    private Rigidbody2D rBody;
    public float rotationDireciton;
    public float rotationSpeed;
    public GameObject _thrust;
    private void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Assigning movement keys
        isThrusting = Input.GetKey("w") || Input.GetKey("up");
        if(Input.GetKey("a") || Input.GetKey("left"))
        {
            rotationDireciton = 1.0f;
        }
        else if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rotationDireciton = -1.0f;
        }
        else
        {
            rotationDireciton = 0.0f;
        }
        // Player firing
        isShooting = Input.GetKeyDown(KeyCode.Space);
        if (isShooting)
        {

        }
    }
    private void FixedUpdate()
    {
        // If holding W, player will thrust
        if (isThrusting)
        {
            rBody.AddForce(this.transform.up * this.thrustSpeed);
            Sprite.Instantiate(_thrust);
        }
        else if (!isThrusting)
        {
            
        }
        // If a left or right key is being pressed, adds torque to rotate the player.
        if (rotationDireciton != 0.0f)
        {
            rBody.AddTorque(rotationDireciton * this.rotationSpeed);
        }
    }

}
