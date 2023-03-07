using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float thrust;
    public float pushForce;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, thrust * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {  
        Vector3 publicDirection = collision.contacts[0].normal;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(-publicDirection * pushForce, ForceMode.Impulse);
    }
}
