using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Joystick Joystickone;

 
    private int Speed = 50;
    public Rigidbody rb;
   
    public Rigidbody rb2;
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        rb = GetComponent<Rigidbody>();
        Joystickone = FindObjectOfType<Joystick>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
      //GameObject.Find("Player").transform.Translate(-verticalInput * Time.deltaTime * Speed, 0, horizontalInput * Time.deltaTime * 10);
       
     //  GameObject.Find("Player").transform.Rotate(0 , horizontalInput , 0);
     // GameObject.Find("Player").transform.Rotate(0, Joystickone.Horizontal *(4f), 0);
       //GameObject.Find("Bot").transform.Translate(-verticalInput * Time.deltaTime * Speed, 0, horizontalInput * Time.deltaTime * Speed);
       // GameObject.Find("Bot").transform.Rotate(0, horizontalInput * Time.deltaTime * Speed, 0);
        //rb.velocity = new Vector3(-Joystickone.Vertical * 20, 0, 0);
     // GameObject.Find("Player").transform.Translate(-Joystickone.Vertical*Time.deltaTime * 20, 0, 0);
        GameObject.Find("Bot").transform.Translate(0, 0, Joystickone.Vertical * Time.deltaTime * 30);
        GameObject.Find("Bot").transform.Rotate(0, Joystickone.Horizontal * (4f), 0);
        
        
        //float mousexinput = Input.GetAxis("Mouse X");
        // float mouseyinput = Input.GetAxis("Mouse Y");
        // GameObject.Find("Main Camera").transform.Rotate(0, mousexinput, 0);


    }
    private void OnCollisionEnter(Collision collision)
    {
        //GameObject.Find("Player").GetComponent<Renderer>().material.color = Color.blue;
      //  GameObject.Find("Bot").GetComponent<Renderer>().material.color = Color.blue;


        /*if (collision.gameObject.CompareTag("door"))
        {
            GameObject.Find("Door").GetComponent<Animator>().SetTrigger("start");
        }*/

    }

    private void OnCollisionExit(Collision collision)
    {

        GameObject.Find("Player").GetComponent<Renderer>().material.color = Color.red;

    }
}
