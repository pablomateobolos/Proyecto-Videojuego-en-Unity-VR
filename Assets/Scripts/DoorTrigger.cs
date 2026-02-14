using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorTrigger : MonoBehaviour
{
    public Animator anim;
    private bool isOpen = false;

    public void OnActivated(ActivateEventArgs arg0)
    {
        if (!isOpen)
        {
            anim.SetTrigger("OpenDoor");
            isOpen = true;
        }
        else
        {
            anim.SetTrigger("CloseDoor");
            isOpen = false;
        }
    }
}