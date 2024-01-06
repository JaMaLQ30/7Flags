using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    // Replace with the reference to your door object
    public GameObject doorObject;

    // Reference to the door's animator component
    private Animator doorAnimator;

    private void Start()
    {
        // Get the animator component from the door object
        doorAnimator = doorObject.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        // Play the "Open" animation if the door is closed
        if (!doorAnimator.GetBool("isOpen"))
        {
            doorAnimator.SetBool("isOpen", true);
        }
    }
}