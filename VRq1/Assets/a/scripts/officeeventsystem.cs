using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;


public class officeeventsystem : MonoBehaviour
{
    public GameObject emptyrack;
    public GameObject fullhatrack;
    public GameObject cowboyhat;
    public GameObject hardhat;
    public GameObject Tophat;
    public GameObject cowboyhatfr;
    public GameObject hardhatfr;
    public GameObject Tophatfr;
    public GameObject cowboyhater;
    public GameObject hardhater;
    public GameObject Tophater;
    public XRSocketInteractor xRSocketInteractorth;
    public XRSocketInteractor xRSocketInteractorhh;
    public XRSocketInteractor xRSocketInteractorfh;
    // Start is called before the first frame update
    void Start()
    {
        xRSocketInteractorth = GetComponent<XRSocketInteractor>();
        xRSocketInteractorhh = GetComponent<XRSocketInteractor>();
        xRSocketInteractorfh = GetComponent<XRSocketInteractor>();
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
        cowboyhatfr.SetActive(false);
        hardhatfr.SetActive(false);
        Tophatfr.SetActive(false);
        cowboyhater.SetActive(true);
        hardhater.SetActive(true);
        Tophater.SetActive(true);
        xRSocketInteractorth.enabled = true;
        xRSocketInteractorhh.enabled = true;
        xRSocketInteractorfh.enabled = true;
    }
    public void Changehathardhat()
    {
        emptyrack.SetActive(true);
        fullhatrack.SetActive(false);
        cowboyhat.SetActive(false);
        hardhat.SetActive(true);
        Tophat.SetActive(false);
        cowboyhatfr.SetActive(false);
        hardhatfr.SetActive(false);
        Tophatfr.SetActive(false);
        cowboyhater.SetActive(true);
        hardhater.SetActive(true);
        Tophater.SetActive(true);
        xRSocketInteractorth.enabled = true;
        xRSocketInteractorhh.enabled = true;
        xRSocketInteractorfh.enabled = true;
    }
    public void Changehatfedora()
    {
        emptyrack.SetActive(true);
        cowboyhat.SetActive(true);
        hardhat.SetActive(false);
        Tophat.SetActive(false);
        fullhatrack.SetActive(false);
        cowboyhatfr.SetActive(false);
        hardhatfr.SetActive(false);
        Tophatfr.SetActive(false);
        cowboyhater.SetActive(  true);
        hardhater.SetActive(true);
        Tophater.SetActive(true);
        xRSocketInteractorth.enabled = true;
        xRSocketInteractorhh.enabled = true;
        xRSocketInteractorfh.enabled = true;
    }
    public void PutBackhat()
    {
        emptyrack.SetActive(false);
        fullhatrack.SetActive(true);
        cowboyhat.SetActive(false);
        hardhat.SetActive(false);
        Tophat.SetActive(false);
        cowboyhatfr.SetActive(true);
        hardhatfr.SetActive(true);
        Tophatfr.SetActive(true);
        cowboyhater.SetActive(false);
        hardhater.SetActive(false);
        Tophater.SetActive(false);
        xRSocketInteractorth.enabled = false;
        xRSocketInteractorhh.enabled = false;
        xRSocketInteractorfh.enabled = false;
    }
}
