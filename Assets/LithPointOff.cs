using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LithPointOff : MonoBehaviour {

    

    public Light FlashLightObject;
    private bool LightEnabled = false;

    void Update()
    {
        if (LightEnabled == false)
        {
            LightEnabled = true;
            FlashLightObject.enabled = LightEnabled;
        }
        if (LightEnabled == false )
        {
            LightEnabled = false;
            FlashLightObject.enabled = LightEnabled;
        }
    }
}