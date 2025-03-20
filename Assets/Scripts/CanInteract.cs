using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CanInteract : MonoBehaviour
{
    [SerializeField] private string interactionText = "Collectable";
    public UnityEvent OnInteract = new UnityEvent();
    public string GetInteractionText()
    {
        return interactionText;
    }
    public void Interact()
    {
        OnInteract.Invoke();
    }
}
