using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Qbert_movement : MonoBehaviour
{
    public int ToF = 0;
    public int Iframe = 0;
    
    public GameObject live1;
    public GameObject live2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKeyDown("1") && ToF == 0)
        {
            ToF = 1;
            transform.eulerAngles = new Vector3(0,-90,0);
           GetComponent<Rigidbody>().velocity = new Vector3(-1, 4, 0);
            
        }
        if (Input.GetKeyDown("3") && ToF == 0)
        {
            ToF = 1;
            transform.eulerAngles = new Vector3(0, 180, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        }
        if (Input.GetKeyDown("9") && ToF == 0)
        {
            ToF = 1;
            transform.eulerAngles = new Vector3(0, 90, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(1, 6, 0);
        }
        if (Input.GetKeyDown("7") && ToF == 0)
        {
            ToF = 1;
            transform.eulerAngles = new Vector3(0, 0, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 1);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        StartCoroutine(delay());
        if(other.gameObject.tag == "blob" && Iframe == 0 )
        {
            GameSys.lives -= 1;
            Iframe = 1;
            GetComponent<Transform>().position = new Vector3(0, 1, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            StartCoroutine(IF());
            if (GameSys.lives == 1)
            {
                Destroy(live1);
            }
            if(GameSys.lives == 0)
            {
                Destroy(live2);
            }
        }
        if(other.gameObject.tag == "point")
        {
            GameSys.timer -= 10f;
        }
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "deadzone")
        {
            GameSys.lives -= 1;
            GetComponent<Transform>().position = new Vector3(0, 1, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            StartCoroutine(IF());
            if (GameSys.lives == 1)
            {
                Destroy(live1);
            }
            if (GameSys.lives == 0)
            {
                Destroy(live2);
            }
        }
        if(other.tag == "Plat")
        {
            transform.eulerAngles = new Vector3(0, -90, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 4, 0);
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.01f);
        ToF = 0;

    }
    IEnumerator IF()
    {
        yield return new WaitForSeconds(2);
        Iframe = 0;

    }
}

