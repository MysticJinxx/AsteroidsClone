using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float thrustSpeed;
    private bool isThrusting;
    private Rigidbody2D rBody;
    public float rotationDireciton;
    public float rotationSpeed;

    private void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
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
    }
    private void FixedUpdate()
    {
        if (isThrusting)
        {
            rBody.AddForce(this.transform.up * this.thrustSpeed);
        }

        if (rotationDireciton != 0.0f)
        {
            rBody.AddTorque(rotationDireciton * this.rotationSpeed);
        }
    }

}
