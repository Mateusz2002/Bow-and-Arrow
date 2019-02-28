using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjecttitleForce : MonoBehaviour {
    Rigidbody rigiB;
    public float shootForce = 2000;
	// Use this for initialization
	void Enable () {
        rigiB = GetComponent<Rigidbody>();
        rigiB.velocity = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        SpinOblectInAir();
		
	}
    void ApplyForce()
    {
        rigiB.AddRelativeForce(Vector3.forward * shootForce);
    }
    void SpinOblectInAir()
    {
        //spin arrow
    }
}
