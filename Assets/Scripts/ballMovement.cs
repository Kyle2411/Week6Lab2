using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public float Speed;
    public float Jump;

    // private bool isTouching = true;

    // FixedUpdate is called several times per frame which will create the illusion of smooth movement
    void FixedUpdate()
    {
        float HorizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");
        
        Vector3 MoveBall = new Vector3(-VerticalMovement,0,HorizontalMovement);
        gameObject.transform.GetComponent<Rigidbody>().AddForce(MoveBall * Speed);

        // Checks to see if the space bar was pressed and if isTouching is true 
        // if ((Input.GetKey(KeyCode.Space)) && isTouching == true)
        // {
        //      Vector3 jumpBall = new Vector3(0.0f, 6.0f, 0.0f);
        //      GetComponent<Rigidbody>().AddForce(jumpBall * Speed);
        // }
        // Makes it like that the ball cant jump twice
        // isTouching = false;
    }

    // Makes it like that the ball only jumps when it is touching something
    // private void OnCollisionStay()
    // {
    //      isTouching = true;
    // }
}
