using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearOnGoal : MonoBehaviour
{
    public GameObject goal;
    public bool AlsoCollide;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<MeshCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (goal.GetComponent<TestCollision>().HasCollided == true)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;

            if (AlsoCollide == true)
            {
                gameObject.GetComponent<MeshCollider>().enabled = true;
            }
        }
    }
}
