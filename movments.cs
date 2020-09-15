using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movments : MonoBehaviour
{
    private Joystick Joystickthree;
    private int Speed = 50;
    public Rigidbody rb2;
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        rb2 = GetComponent<Rigidbody>();
        Joystickthree = FindObjectOfType<Joystick>();

    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Player").transform.Translate(-Joystickthree.Vertical * Time.deltaTime * 30,0, 0);
        GameObject.Find("Player").transform.Rotate(0, Joystickthree.Horizontal * (4f), 0);
    }
}
