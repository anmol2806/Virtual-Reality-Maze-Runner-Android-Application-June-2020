using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdeye : MonoBehaviour
{
    public void Camera()
    {
        GetComponent<Animator>().enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform[] transform = GameObject.Find("BirdEyeView").GetComponentsInChildren<Transform>();
        for (int i = 1; i <= transform.Length - 1; i++)
        {
            GameObject.Find(transform[i].name).transform.Rotate(10, 30, 45);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        collision.gameObject.CompareTag("BirdView");
        {
            GameObject.Find("Main Camera").GetComponent<Animator>().SetTrigger("Start");
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        GameObject.Find("Main Camera").GetComponent<Animator>().enabled = true;
        GameObject.Find("Main Camera").GetComponent<Animator>().SetTrigger("Stop");

        Transform[] transform = GameObject.Find("BirdEyeView").GetComponentsInChildren<Transform>();
        for (int i = 1; i <= transform.Length - 1; i++)
        {
            Destroy(GameObject.Find(transform[i].name));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Main Camera")
        {
            GameObject.Find("Main Camera").GetComponent<Animator>().SetTrigger("Start");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Main Cmaera")
        {
            GameObject.Find("Main Camera").GetComponent<Animator>().SetTrigger("Stop");
        }
    }

}
