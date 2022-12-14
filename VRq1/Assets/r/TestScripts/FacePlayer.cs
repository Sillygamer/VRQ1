using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public GameObject player;
    public float DegreesRotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 VectorToPlayer = new Vector3(player.transform.position.x - transform.position.x, 0, player.transform.position.z - transform.position.z).normalized;

        DegreesRotate = Mathf.Atan2(VectorToPlayer.x, VectorToPlayer.z) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(90, DegreesRotate, 0);
        
    }
}
