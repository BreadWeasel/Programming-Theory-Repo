using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenBehavior : AnimalBehavior
{
    private Rigidbody chickenRb;

    private void Start()
    {
        animalRb = GetComponent<Rigidbody>();
    }
    protected override void Jump()
    {
        jumpForce = 350f;
        animalRb.AddForce(Vector3.up * jumpForce);
    }

    private void OnMouseDown()
    {
        Jump();
    }
}
