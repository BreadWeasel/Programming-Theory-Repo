using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehavior : MonoBehaviour
{
    protected float jumpForce;
    protected Rigidbody animalRb;
    // Start is called before the first frame update
    
    protected virtual void Jump()
    {
        animalRb.AddForce(Vector3.up * jumpForce);
    }
}
