using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ClimbAnchor : XRBaseInteractable
{
    protected override void Awake()
    {
        base.Awake();
    }

    private void FindClimbingProvider()
    {

    }
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
    }
    private void TryAdd(IXRSelectInteractor interactor)
    {

    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
    }

    private void TryRemove(IXRSelectInteractor interactor)
    {

    }
}
