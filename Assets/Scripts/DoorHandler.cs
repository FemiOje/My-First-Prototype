using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandler : MonoBehaviour
{
    public Animator entranceAnim;
    public Animator slideWindowAnim;
    public Animator firstFloorDoor1Anim;
    public Animator firstFloorDoor2Anim;
    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.name)
        {
            case "EntranceDoorTrigger":
                entranceAnim.SetTrigger("EntranceDoorTrigger");
                break;

            case "SlideWindowTrigger":
                slideWindowAnim.SetTrigger("SlideWindowTrigger");
                break;

            case "1stFloorDoor1Trigger":
                firstFloorDoor1Anim.SetTrigger("1stFloorDoor1Trigger");
                break;

            case "1stFloorDoor2Trigger":
                firstFloorDoor2Anim.SetTrigger("1stFloorDoor2Trigger");
                break;

            default:
                Debug.Log("Please confirm that trigger names are spelled correctly");
                break;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.name)
        {
            case "EntranceDoorTrigger":
                entranceAnim.SetTrigger("EntranceDoorTrigger");
                break;

            case "SlideWindowTrigger":
                slideWindowAnim.SetTrigger("SlideWindowTrigger");
                break;

            case "1stFloorDoor1Trigger":
                firstFloorDoor1Anim.SetTrigger("1stFloorDoor1Trigger");
                break;

            case "1stFloorDoor2Trigger":
                firstFloorDoor2Anim.SetTrigger("1stFloorDoor2Trigger");
                break;

            default:
                Debug.Log("Please confirm that trigger names are spelled correctly");
                break;

        }
    }
}
