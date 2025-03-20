using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandlesr : MonoBehaviour
{
    FirstPerson first;
    Movement movement;
    Interaction interaction;
    void Start()
    {
        first = GetComponent<FirstPerson>();
        movement = GetComponent<Movement>();
        interaction = GetComponent<Interaction>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCam();
        HandleMovement();
        HandelInteraction();
    }
    void HandleCam()
    {
        first.AddXAxisInput(Input.GetAxis("Mouse Y") * Time.deltaTime);
        first.AddYAxisInput(Input.GetAxis("Mouse X") * Time.deltaTime);
    }
    void HandleMovement()
    {
        float fawar = Input.GetAxis("Vertical");
        float rLC = Input.GetAxis("Horizontal");

        movement.AddMoveInput(fawar, rLC);
    }
    void HandelInteraction()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            interaction.TryInteract();
        }
    }
}
