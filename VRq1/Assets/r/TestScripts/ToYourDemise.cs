using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToYourDemise : MonoBehaviour
{
    public GameObject goal;
    public GameObject Planet;
    public int Timer;
    
    //public bool AlsoCollide;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<MeshRenderer>().enabled = false;
        //gameObject.GetComponent<MeshCollider>().enabled = false;

        //this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (goal.GetComponent<TestCollision>().HasCollided == true) 
        {
            Planet.transform.position = new Vector3(Planet.transform.position.x, Planet.transform.position.y, Planet.transform.position.z+1);

            if (Timer <= 0)
            {
                SceneManager.LoadScene(4);
            }

            Timer--;
            
        }


    }
}
