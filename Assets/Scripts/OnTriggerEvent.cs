﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEvent : MonoBehaviour
{
    public UnityEvent onEnter, onStay, onExit;
    public UnityEvent onInteract;
    public string hitTag = "Player";

    public void Interact()
    {
        // Invoke an Interact UnityEvent
        onInteract.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag(hitTag))
        {
            // Invoke Event!
            onEnter.Invoke();
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag(hitTag))
        {
            // Invoke Event!
            onStay.Invoke();
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag(hitTag))
        {
            // Invoke Event!
            onExit.Invoke();
        }
    }
}
