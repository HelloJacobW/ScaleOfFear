using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
    [SerializeField] private float distance = 2f;
    [SerializeField] private Text interactableName;
    private CanInteract target;

    void Update()
    {
        Vector3 origin = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        RaycastHit raycastHit = new RaycastHit();
        string objectName = "";
        target = null;

        if(Physics.Raycast(origin, direction, out raycastHit, distance))
        {
            target = raycastHit.collider.gameObject.GetComponent<CanInteract>();
        }
        if (target && target.enabled)
        {
            objectName = target.GetInteractionText();
        }
        SetText(objectName);
    }
    private void SetText(string newText)
    {
        if (interactableName)
        {
            interactableName.text = newText;
        }
    }
    public void TryInteract()
    {
        if (target && target.enabled)
        {
            target.Interact();
        }
    }
}
