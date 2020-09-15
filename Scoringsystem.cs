using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scoringsystem : MonoBehaviour
{
    public GameObject ScoreText;
   public static int thescore;
   /* public int thescore;
    public AudioSource collectsound;
     void OnTriggerEnter(Collider other)
     {
         collectsound.Play();
         thescore += 50;
    ScoreText.GetComponent<Text>().text = "Score:" + thescore;
         Destroy(gameObject);
     }*/
    
    void update()
    {
        ScoreText.GetComponent<Text>().text = "Score:" + thescore;
    }
}
