using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Embedbehavior : MonoBehaviour
{
    Rigidbody rigidB;

    // Start is called before the first frame update
    void Start()
    {
        rigidB = GetComponent<Rigidbody>();
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider coll)
    {
        Embed();
    }
    void Embed()
    {
        transform.GetComponent<ProjecttitleForce>().enabled = false;
        rigidB.velocity = Vector3.zero;
        rigidB.useGravity = false;
        rigidB.isKinematic = true;
    }
}
