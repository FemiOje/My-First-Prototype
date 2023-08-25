using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras;

    private int currentCameraIndex = 0;

    private void Start()
    {
        // Initialize cameras
        SetCameraActive(currentCameraIndex);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Disable the current camera
            SetCameraActive(currentCameraIndex, false);

            // Move to the next camera index
            currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

            // Enable the new camera
            SetCameraActive(currentCameraIndex, true);
        }
    }

    private void SetCameraActive(int index, bool isActive = true)
    {
        cameras[index].enabled = isActive;
        cameras[index].GetComponent<AudioListener>().enabled = isActive;
    }
}
