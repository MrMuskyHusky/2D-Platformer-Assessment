using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEvent : MonoBehaviour
{
    public UnityEvent onEnter;

    private void OnTriggerEnter(Collider other)
    {
       onEnter.Invoke();
    }
}