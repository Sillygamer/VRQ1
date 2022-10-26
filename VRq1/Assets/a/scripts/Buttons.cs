using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public GameObject creditpanel;
    public GameObject mainpanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeToCredits()
    {
        mainpanel.SetActive(false);
        creditpanel.SetActive(true);
    }

    public void ChangeBackToMain()
    {
        mainpanel.SetActive(true);
        creditpanel.SetActive(false);
    }

    public void End()
    {
        Application.Quit();
    }
}
