using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class officeeventsystem : MonoBehaviour
{
    public GameObject emptyrack;
    public GameObject fullhatrack;
    public GameObject cowboyhat;
    public GameObject hardhat;
    public GameObject Tophat;
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
        cowboyhat.SetActive(false);
        hardhat.SetActive(false);
        Tophat.SetActive(true);
    }
    public void Changehathardhat()
    {
        emptyrack.SetActive(true);
        fullhatrack.SetActive(false);
        cowboyhat.SetActive(false);
        hardhat.SetActive(true);
        Tophat.SetActive(false);
    }
    public void Changehatfedora()
    {
        emptyrack.SetActive(true);
        cowboyhat.SetActive(true);
        hardhat.SetActive(false);
        Tophat.SetActive(false);
        fullhatrack.SetActive(false);
    }
    public void PutBackhat()
    {
        emptyrack.SetActive(false);
        fullhatrack.SetActive(true);
        cowboyhat.SetActive(false);
        hardhat.SetActive(false);
        Tophat.SetActive(false);
    }
}
