using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class limbprovider : MonoBehaviour
{
    public static event Action ClimbActive;
    public static event Action Climbinactive;

    public CharacterController character;
    public InputActionProperty velocityright;
    public InputActionProperty Velocityleft;

    private bool _rightactive = false;
    private bool _leftactive = false;

    private void Start()
    {
        xr_climb.ClimbhandActivated += HandActivated;
        xr_climb.ClimbhandDEActivated += HandDEActivated;

    }

    private void OnDestroy()
    {
        xr_climb.ClimbhandActivated += HandActivated;
        xr_climb.ClimbhandDEActivated += HandDEActivated;
    }

    private void HandActivated(string _controllername)
    {
        if(_controllername == "lh")
        {
            _leftactive = true;
            _rightactive = false;
        }
        else
        {
            _leftactive = false;
            _rightactive = true;
        }
        ClimbActive?.Invoke();
    }

    private void HandDEActivated(string _controllername)
    {
        if (_rightactive &&_controllername == "rh")
        {
             _rightactive = false;
            Climbinactive?.Invoke();
        }
        else if(_leftactive && _controllername =="lh")
        {
            _leftactive = false;
            Climbinactive?.Invoke();
        }

    }

    private void FixedUpdate()
    {
        if(_rightactive|| _leftactive)
        {
            Climb();

        }

    }

    private void Climb()
    {
        Vector3 velocity = _leftactive ? Velocityleft.action.ReadValue<Vector3>() : velocityright.action.ReadValue<Vector3>();

        character.Move(character.transform.rotation * -velocity * Time.fixedDeltaTime);
    }
}
