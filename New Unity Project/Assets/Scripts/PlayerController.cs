using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    public float speed;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
 
    void FixedUpdate ()
    {
        float moveHoriztonal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3 (moveHoriztonal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}
