using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buttonpr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reset()
    {
        SceneManager.LoadScene(3);
    }

    public void Backtotittle()
    {
        SceneManager.LoadScene(0);
    }
}
