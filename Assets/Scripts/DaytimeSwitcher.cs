using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaytimeSwitcher : MonoBehaviour
{
    [SerializeField] Light directionalLight;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            ToggleDirectionalLight();
        }
    }

    void ToggleDirectionalLight()
    {
        directionalLight.enabled = !directionalLight.enabled;
    }
}
