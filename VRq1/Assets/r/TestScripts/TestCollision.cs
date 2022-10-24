using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    public bool HasCollided;
    public string TagName;
    public bool DestroyCollider;
    // Start is called before the first frame update
    void Start()
    {
        HasCollided = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        
        
        if(other.gameObject.tag == TagName)
        {
            HasCollided = true;

            if (DestroyCollider == true) Destroy(other.gameObject);
        }
    }

}
