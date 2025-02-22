// Example implementation of IEventReceiver
using UnityEngine;

public class TargetObject : MonoBehaviour, IRayEventReceiver
{
    bool triggered = false;
    public void OnRaycastEnter()
    {
        if (!triggered)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        Debug.Log("Ray Cast Enter");

    }

    public void OnRaycastExit()
    {
        Debug.Log("Ray Cast Exit");
    }
}
