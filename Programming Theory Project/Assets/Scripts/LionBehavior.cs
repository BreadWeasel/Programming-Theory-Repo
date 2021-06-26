using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LionBehavior : AnimalBehavior
{
    private Rigidbody lionRb;

    private void Start()
    {
        animalRb = GetComponent<Rigidbody>();
    }
    protected override void Jump()
    {
        jumpForce = 500f;
        animalRb.AddForce(Vector3.up * jumpForce);
    }

    private void OnMouseDown()
    {
        Jump();
    }
}
