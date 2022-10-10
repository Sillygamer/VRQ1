using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Velocitys : MonoBehaviour
{
    [SerializeField] private InputActionProperty velocityInput;
    public Vector3 velocitys => velocityInput.action.ReadValue<Vector3>();

}
