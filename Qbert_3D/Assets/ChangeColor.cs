using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material color;
    public int colorStatus = 1;
    public static int tiles = 28;
    public GameObject won;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tiles == 0)
        {
            Debug.Log("Win");
            Won();
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "qbert")
        {
            colorStatus -= 1;
            if (colorStatus == 0)
            {
                GetComponent<Renderer>().material = color;
                tiles -= 1;
            }
        }
    }
    void Won()
    {
        won.SetActive(true);
        Time.timeScale = 0f;
    }
   
}
