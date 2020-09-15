using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallstart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.name == "Bot")
        {
            newtimer.playing = true;
            Destroy(gameObject);
        }
    }
}
