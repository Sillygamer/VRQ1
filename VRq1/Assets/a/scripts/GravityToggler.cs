using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GravityToggler : MonoBehaviour
{
    private CharacterController _characterController;
    private bool _climbing = false;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        limbprovider.ClimbActive += ClimbActive;
        limbprovider.Climbinactive += Climbinactive;
    }

    private void OnDestroy()
    {
        limbprovider.ClimbActive -= ClimbActive;
        limbprovider.Climbinactive -= Climbinactive;
    }

    private void FixedUpdate()
    {
        if(!_characterController.isGrounded && !_climbing)
        {
            _characterController.SimpleMove(new Vector3());
        }
    }
    private void ClimbActive()
    {
        _climbing = true;
    }

    private void Climbinactive()
    {
        _climbing = false;
    }
}
