using UnityEngine;

public class ToggleBridge : MonoBehaviour
{
    public HingeJoint joint;

    private void OnTriggerEnter(Collider other)
    {
        joint.useSpring = true;
    }

    private void OnTriggerExit(Collider other)
    {
        joint.useSpring = false;
    }
}
