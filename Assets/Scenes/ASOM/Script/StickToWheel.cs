using UnityEngine;

public class StickToWheel : MonoBehaviour
{
    public GameObject stickObject;
    public WheelCollider wheelCollider;

    private FixedJoint fixedJoint;

    private void Start()
    {
        fixedJoint = stickObject.AddComponent<FixedJoint>();
        fixedJoint.connectedBody = wheelCollider.GetComponent<Rigidbody>();
    }
}