using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearOnGoal : MonoBehaviour
{
    public GameObject goal;
    public GameObject AppearingItem;
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
        
        AppearingItem.SetActive(goal.GetComponent<TestCollision>().HasCollided);
        
        
    }
}
