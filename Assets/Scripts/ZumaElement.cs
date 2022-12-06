using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZumaElement : MonoBehaviour
{
    public ZumaApplication app 
    {
        get 
        {
            return GameObject.FindObjectOfType<ZumaApplication>();
        } 
    }
}
