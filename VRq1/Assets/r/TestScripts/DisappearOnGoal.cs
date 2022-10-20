using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnGoal : MonoBehaviour
{

    public GameObject goal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goal.GetComponent<TestCollision>().HasCollided == true)
        {
            Destroy(this.gameObject);

        }
    }
}
