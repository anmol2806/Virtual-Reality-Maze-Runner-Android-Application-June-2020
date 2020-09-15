using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joyanim : MonoBehaviour
{
    private Joystick Joystickone;
    private int Speed = 50;
    public Rigidbody rb;
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
        //rb.velocity = new Vector3( rb.velocity.x, Joystickone.Horizontal, Joystickone.Vertical);
        GameObject.Find("Bot").transform.Rotate(0, Joystickone.Horizontal * (4f), 0);
        //|| (Input.GetKey(KeyCode.UpArrow


        if (  Input.GetKey(KeyCode.W))
        {
            GetComponent<Animator>().SetBool("Forward", true);
            GetComponent<Animator>().SetBool("idle", false);

        }
        else if (Input.GetKey(KeyCode.S) || Joystickone.Vertical <0)
        {
            SendMessage("rot");
           /* GetComponent<Animator>().SetBool("Forward", false);
            GetComponent<Animator>().SetBool("idle", false);*/

        }
        else if (Joystickone.Vertical > 0)
        {
            Debug.Log("hello");
            GetComponent<Animator>().SetBool("Run", true);
            GetComponent<Animator>().SetBool("idle", false);

        }
      /*  else if (Joystickone.Horizontal != 0)
        {
            Debug.Log("rotate");
            GameObject.Find("Bot").transform.Rotate(0, Joystickone.Horizontal * Time.deltaTime* Speed, 0);
        }*/
       
        else if (Input.GetKey(KeyCode.J))
        {
            GetComponent<Animator>().SetBool("Jump", true);
            GetComponent<Animator>().SetBool("idle", false);

        }
       /* else if (Input.GetButton("Button180"))
        {
           utton = GetComponent<Button>();
           utton.onClick.AddListener(uitGame);
            
        }*/
        else
        {
            GetComponent<Animator>().SetBool("Jump", false);
            GetComponent<Animator>().SetBool("Forward", false);
            GetComponent<Animator>().SetBool("Run", false);
            GetComponent<Animator>().SetBool("idle", true);
        }
    }

    public void rot()
    { transform.Rotate(0, 180, 0); }
}
