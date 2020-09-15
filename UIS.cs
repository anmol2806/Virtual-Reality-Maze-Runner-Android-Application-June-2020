using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIS : MonoBehaviour
{
    private Button quitbutton;

    // Start is called before the first frame update
    void Start()
    {
        quitbutton = GetComponent<Button>();
        quitbutton.onClick.AddListener(QuitGame);
    }
    public void QuitGame()
    {
        Debug.Log("Application is quit");
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {

    }
    /*public void buttontest()
    {
        Debug.Log("Button clicked");
    }*/
    
}
