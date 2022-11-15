using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovetowardsPlayer : MonoBehaviour
{

    public GameObject player;
    public float Movespeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 VectorToPlayer = new Vector3(player.transform.position.x - transform.position.x, player.transform.position.y - transform.position.y, player.transform.position.z - transform.position.z).normalized;

        transform.position += VectorToPlayer * Movespeed;
    }
}
