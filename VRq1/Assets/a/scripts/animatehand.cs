using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class animatehand : MonoBehaviour
{
    public InputActionProperty pinchAnimation;
    public InputActionProperty gripAnimation;

    public Animator handanimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggervalue = pinchAnimation.action.ReadValue<float>();
        handanimator.SetFloat("Trigger", triggervalue);
        float gripvalue = gripAnimation.action.ReadValue<float>();
        handanimator.SetFloat("Grip", gripvalue);
    }
}
