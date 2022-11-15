using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HISWrath : MonoBehaviour
{
    public string TagName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //SceneManager.LoadScene(5);



    }




    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == TagName)
        {

            SceneManager.LoadScene(5);

        }
    }
}
