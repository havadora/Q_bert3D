using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
         GetComponent<Rigidbody>().velocity = new Vector3(0, 2, 2);
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Plat")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            GetComponent<Transform>().position = new Vector3(1.45f, -6, -6);
        }
    }
}
