using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public GameObject creditpanel;
    public GameObject creditpanel2;
    public GameObject creditpanel3;
    public GameObject creditpanel4;
    public GameObject creditpanel5;
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
        creditpanel2.SetActive(false);
        creditpanel3.SetActive(false);
        creditpanel4.SetActive(false);
        creditpanel5.SetActive(false);
    }
    public void ChangeToCredits2()
    {
        mainpanel.SetActive(false);
        creditpanel.SetActive(false);
        creditpanel2.SetActive(true);
        creditpanel3.SetActive(false);
        creditpanel4.SetActive(false);
        creditpanel5.SetActive(false);
    }
        public void ChangeToCredits3()
    {
        mainpanel.SetActive(false);
        creditpanel.SetActive(false);
        creditpanel2.SetActive(false);
        creditpanel3.SetActive(true);
        creditpanel4.SetActive(false);
        creditpanel5.SetActive(false);
    }
        public void ChangeToCredits4()
    {
        mainpanel.SetActive(false);
        creditpanel.SetActive(false);
        creditpanel2.SetActive(false);
        creditpanel3.SetActive(false);
        creditpanel4.SetActive(true);
        creditpanel5.SetActive(false);
    }
        public void ChangeToCredits5()
    {
        mainpanel.SetActive(false);
        creditpanel.SetActive(false);
        creditpanel2.SetActive(false);
        creditpanel3.SetActive(false);
        creditpanel4.SetActive(false);
        creditpanel5.SetActive(true);
    }
    
    public void ChangeBackToMain()
    {
        mainpanel.SetActive(true);
        creditpanel.SetActive(false);
        creditpanel2.SetActive(false);
        creditpanel3.SetActive(false);
        creditpanel4.SetActive(false);
        creditpanel5.SetActive(false);
    }

    public void End()
    {
        Application.Quit();
    }
}
