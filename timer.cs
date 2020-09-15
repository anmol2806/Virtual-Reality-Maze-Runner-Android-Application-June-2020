using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    public Text Timertext;
    private float starttime;
    private bool finnished = false;
    private float HighSCore;
    public Text highscore;
    // Start is called before the first frame update
    void Start()
    {
       // HighSCore = PlayerPrefs.GetFloat("highscore",0);
        starttime = Time.time;
      //  highscore.text = "Highscore"+ HighSCore;
        //highscore.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if (finnished)
            return;
        float t = Time.time - starttime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        Timertext.text = minutes + ":" + seconds;

     /*   if (t > HighSCore)
        {
            HighSCore = t;
            highscore.text = "highscores" + t;

            PlayerPrefs.SetFloat("highscore", HighSCore);
        }*/
    }
      

    public void Finnish()
    {
        finnished = true;
        Timertext.color = Color.yellow;
        //highscore.text = "Highscore =" + (Timertext.text);
        //highscore.color = Color.black;
        //HighSCore = highscore.text;
       // string j = Timertext.text - highscore.text;
    }
}
