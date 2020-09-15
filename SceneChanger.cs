using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Scene2()
    {
        SceneManager.LoadScene("character control");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("maze level1");
    }
    public void Scene4()
    {
        SceneManager.LoadScene("maze level2");
    }
    public void Scene5()
    {
        SceneManager.LoadScene("maze level3");
    }

}
