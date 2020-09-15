using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winbox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        //GameObject.Find("Player").SendMessage("Finnish");
        GameObject.Find("Bot").SendMessage("Finnish");
        /*GameObject.Find("Player").SendMessage("Finnish");
        GameObject.Find("_cyborg_base").SendMessage("Finnish");*/
        GameObject.Find("TMP) (TMP)").GetComponent<Animator>().SetTrigger("start");
        //  GameObject.Find("Text (TMP)").GetComponent<Animator>().SetTrigger("startq");
        GameObject.Find("Gold Trophy 1").GetComponent<Animator>().SetTrigger("startq");
    }
}
