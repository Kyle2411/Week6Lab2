using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public float Thrust;
    public float pushForce;

   
    void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Obstical")
        {
            Vector3 publicDirection = collision.contacts[0].normal;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(-publicDirection * pushForce, ForceMode.Impulse);
        }
    }
}
