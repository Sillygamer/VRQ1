using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handphyics : MonoBehaviour
{

    public Transform target;
    private Rigidbody rb;
    private Collider[] handcolliders;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        handcolliders = GetComponentsInChildren<Collider>();
       
    }

    public void enableCollider()
    {
        foreach (var item in handcolliders)
        {
            item.enabled = true;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "wall")
        {
            Invoke("disableCollider", 0);
        }
    }
    public void disableCollider()
    {
        

        foreach (var item in handcolliders)
        {
            item.enabled = false;
        }
    }

    public void Enabledelay(float delay)
    {
        Invoke("enableCollider", delay);
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = (target.position - transform.position) / Time.fixedDeltaTime;
        Quaternion rotationDifference = target.rotation * Quaternion.Inverse(transform.rotation);

        rotationDifference.ToAngleAxis(out float angleindegree, out Vector3 rotationaxis);

        Vector3 RotationDifrenceindegree = angleindegree * rotationaxis;
        rb.angularVelocity = (RotationDifrenceindegree * Mathf.Deg2Rad/ Time.fixedDeltaTime);
    }
}
