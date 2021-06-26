using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinBehavior : AnimalBehavior
{
    private Rigidbody penguinRb;

    private void Start()
    {
        animalRb = GetComponent<Rigidbody>();
    }
    protected override void Jump()
    {
        jumpForce = 200f;
        animalRb.AddForce(Vector3.up * jumpForce);
    }

    private void OnMouseDown()
    {
        Jump();
    }
}
