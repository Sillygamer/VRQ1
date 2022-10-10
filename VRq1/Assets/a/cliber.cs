using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class cliber : LocomotionProvider
{
    [SerializeField] private CharacterController characterController;

    private bool isClimbing = false;
    private List<Velocitys> activeVelocites = new List<Velocitys>();


    protected override void Awake()
    {
        base.Awake();
        FindCharacterController();
    }

    private void FindCharacterController()
    {
        if (!characterController)
        {
            characterController = system.xrOrigin.GetComponent<CharacterController>();
        }
    }

    public void AddProvider(Velocitys provider)
    {
        if (!activeVelocites.Contains(provider))
        {
            activeVelocites.Add(provider);
        }
    }

    public void RemoveProvider(Velocitys provider)
    {
        if (activeVelocites.Contains(provider))
        {
            activeVelocites.Remove(provider);
        }
    }

    private void Update()
    {
        TryBeginClimb();

        if (isClimbing)
        {
            AppyVelocity();
        }
        TryEndClimb();
    }

    private void TryBeginClimb()
    {
        if (CanClimb() && BeginLocomotion())
        {
            isClimbing = true;
        }
    }

    private void TryEndClimb()
    {
        if (!CanClimb() && EndLocomotion())
        {
            isClimbing = false;
        }
    }

    private bool CanClimb()
    {
        return activeVelocites.Count != 0;
    }

    private void AppyVelocity()
    {
        Vector3 velocity = CollectControllerVelocity();
        Transform origin = system.xrOrigin.transform;

        velocity = origin.TransformDirection(velocity);
        velocity *= Time.deltaTime;

        if (characterController)
        {
            characterController.Move(-velocity);
        }
        else
        {
            origin.position -= velocity;
        }
    }

    private Vector3 CollectControllerVelocity()
    {
        Vector3 totalvelocity = Vector3.zero;

        foreach(Velocitys container in activeVelocites)
        {
            totalvelocity += container.velocitys;
        }

        return totalvelocity;
    }
}
