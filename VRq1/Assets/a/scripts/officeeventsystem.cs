using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class officeeventsystem : MonoBehaviour
{
    public GameObject emptyrack;
    public GameObject fullhatrack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(2);
    }

    public void ChangehatTophat()
    {
        emptyrack.SetActive(true);
        fullhatrack.SetActive(false);
    }
    public void Changehathardhat()
    {
        emptyrack.SetActive(true);
        fullhatrack.SetActive(false);
    }
    public void Changehatfedora()
    {
        emptyrack.SetActive(true);
        fullhatrack.SetActive(false);
    }
    public void PutBackhat()
    {
        emptyrack.SetActive(false);
        fullhatrack.SetActive(true);
    }
}
