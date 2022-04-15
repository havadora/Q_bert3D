using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameSys : MonoBehaviour
{
    public Transform blob;
    public Transform blue;
    public Text score;
    public static int lives = 2;
    public static float timer = 0f;
    public GameObject losing;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawnblob());
        StartCoroutine(Spawnblue());
        losing.SetActive(false);
    }

    // Update is called once per frame

    void Update()
    {
         timer += Time.deltaTime;
        score.text = timer.ToString("0");

        if(lives < 0)
        {
            losing.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    
    IEnumerator Spawnblob()
    {
        yield return new WaitForSeconds(5);
        Instantiate(blob, new Vector3(0, 2, 0), blob.rotation);
        StartCoroutine(Spawnblob());

    }

    IEnumerator Spawnblue()
    {
        yield return new WaitForSeconds(12);
        Instantiate(blue, new Vector3(0, 2, 0), blue.rotation);
        StartCoroutine(Spawnblue());

    }
}
