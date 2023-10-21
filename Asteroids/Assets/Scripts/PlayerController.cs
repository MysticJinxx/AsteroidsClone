using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rBody;
    private float hInput;
    private float vInput;
    private float rotationSpeed;

    private void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    // Function moves player
    private void MovePlayer()
    {
        vInput = Input.GetAxis("Vertical");
        rBody.velocity = new Vector2 (0, vInput) * speed;
    }

    private void RotatePlayer()
    {

    }
}
