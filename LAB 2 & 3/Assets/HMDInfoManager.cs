using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Is device Active " + XRSettings.isDeviceActive);
        Debug.Log("Device name is : " + XRSettings.loadedDeviceName);

        if (!XRSettings.isDeviceActive)
            Debug.Log("No headset Plugged");
        else if (XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD")
            || XRSettings.loadedDeviceName == "MockHMDDisplay")
            Debug.Log("We Have a headset " + XRSettings.loadedDeviceName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
