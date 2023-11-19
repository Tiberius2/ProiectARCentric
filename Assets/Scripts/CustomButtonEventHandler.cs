using UnityEngine;
using UnityEngine.Events;

public class CustomButtonEventHandler : MonoBehaviour
{
    public UnityEvent onPressEvent;
    public UnityEvent onHoldEvent;
    public UnityEvent onReleaseEvent;

    public void OnPress()
    {
        onPressEvent.Invoke();
    }

    public void OnHold()
    {
        onHoldEvent.Invoke();
    }

    public void OnRelease()
    {
        onReleaseEvent.Invoke();
    }
}