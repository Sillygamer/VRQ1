using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.XR.Interaction.Toolkit;

public class xr_climb : XRDirectInteractor
{
    public static event Action<string> ClimbhandActivated;
    public static event Action<string> ClimbhandDEActivated;

    private string _controllername;

    protected override void Start()
    {
        base.Start();
        _controllername = gameObject.name;
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        if(args.interactableObject.transform.gameObject.tag == "wall")
        {
            ClimbhandActivated?.Invoke(_controllername);
        }
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        ClimbhandDEActivated?.Invoke(_controllername);
    }
}
