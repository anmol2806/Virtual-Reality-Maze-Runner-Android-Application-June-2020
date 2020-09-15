using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hmm : MonoBehaviour
{
    private Button utton;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * 40, 0);
        
        if (Input.GetKey(KeyCode.W )|| (Input.GetKey(KeyCode.UpArrow )))
        {
            GetComponent<Animator>().SetBool("Forward", true);
            GetComponent<Animator>().SetBool("idle", false);

        }
        else if (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
        {
            SendMessage("rot");
           /* GetComponent<Animator>().SetBool("Forward", false);
            GetComponent<Animator>().SetBool("idle", false);*/

        }
        else if (Input.GetKey(KeyCode.Q))
        {
            GetComponent<Animator>().SetBool("Run", true);
            GetComponent<Animator>().SetBool("idle", false);

        }
        
       
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
    /*public void uitGame()
    {
        GetComponent<Animator>().SetBool("Run", true);
        GetComponent<Animator>().SetBool("idle", false);
    }*/
}
