using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonGame : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You Won The Game!!!!");
    }
}
