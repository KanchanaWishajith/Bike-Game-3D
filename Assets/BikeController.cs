using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    float moveInput;
    public float maxSpeed, acceleration;

    public Rigidbody sphereRB;

    // Start is called before the first frame update
    void Start()
    {
        moveInput = Input.GetAxis("vertical");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = sphereRB.transform.position;
    }

    private void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        sphereRB.velocity = Vector3.Lerp(sphereRB.velocity, maxSpeed * moveInput * transform.forward, Time.fixedDeltaTime * acceleration);
    }
}
