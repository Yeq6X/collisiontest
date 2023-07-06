using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigBehavior : MonoBehaviour
{
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.solverIterations = 30;
    }
}