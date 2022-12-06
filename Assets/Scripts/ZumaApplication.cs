using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZumaApplication : MonoBehaviour
{
    //Launcher objects
    public LauncherController launcherController;
    public LauncherModel launcherModel;
    public LauncherView launcherView;

    private void Start()
    {
        //Getting Launcher objects
        launcherController = GameObject.FindObjectOfType<LauncherController>();
        launcherModel = GameObject.FindObjectOfType<LauncherModel>();
        launcherView = GameObject.FindObjectOfType<LauncherView>();

    
    }
}
