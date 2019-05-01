using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjecttitleForce : MonoBehaviour
{
    Rigidbody rigiB;
    public float shootForce = 500;
    // Use this for initialization
    void OnEnable()
    {
        rigiB = GetComponent<Rigidbody>();
        rigiB.velocity = Vector3.zero;
        ApplyForce();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ApplyForce()
    {
        rigiB.AddRelativeForce(Vector3.left *shootForce);
    }

}
