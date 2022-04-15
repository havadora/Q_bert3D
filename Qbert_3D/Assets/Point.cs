using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    // Start is called before the first frame update
    public string dead = "n";
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "point";
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == "y")
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "deadzone")
        {
            dead = "y";
        }
        if (other.tag == "qbert")
        {
            dead = "y";
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (Random.Range(0, 2) == 0)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 4, 0);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        }
        if (other.gameObject.tag == "qbert")
        {
            dead = "y";
        }
    }
}
