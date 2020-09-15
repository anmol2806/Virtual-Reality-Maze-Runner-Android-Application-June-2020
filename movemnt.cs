using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemnt : MonoBehaviour
{
    private Joystick Joysticktwo;
    private int Speed = 50;
    public Rigidbody rb1;
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        rb1 = GetComponent<Rigidbody>();
        Joysticktwo = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("_cyborg_base").transform.Translate(0, 0, Joysticktwo.Vertical * Time.deltaTime * 30);
        GameObject.Find("_cyborg_base").transform.Rotate(0, Joysticktwo.Horizontal * (4f), 0);

    }
}
