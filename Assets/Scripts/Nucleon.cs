using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody))]
public class Nucleon : MonoBehaviour
{

    public float attractionForce;

    Rigidbody body;

    void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //pulls the nucleon towards the origin
        body.AddForce(transform.localPosition * -attractionForce);
    }


}
