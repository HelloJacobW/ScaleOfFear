using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    CharacterController characterController;
    public float moveSpeed = 3f;
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float farwar = Input.GetAxis("Vertical");
        float lRC = Input.GetAxis("Horizontal");


        move.Normalize();
        move.y = -0.5f;

        characterController.Move(move*moveSpeed*Time.deltaTime);
    }
    public void AddMoveInput(float farwar, float lRC)
    {
        Vector3 camFarwar = Camera.main.transform.forward;
        Vector3 camlRC = Camera.main.transform.right;

        camFarwar.y = 0f;
        camlRC.y = 0f;

        camFarwar.Normalize();
        camlRC.Normalize();
        move = (farwar * camFarwar) + (lRC * camlRC);

    }
}
