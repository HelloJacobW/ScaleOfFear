using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    public float xAxis;
    public float yAxis;

    public float xTurn = 360f;
    public float yTurn = 360f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0f);
        Camera.main.transform.rotation = newRotation;
    }
    public void AddXAxisInput(float input)
    {
        xAxis -= input * xTurn;
        xAxis = Mathf.Clamp(xAxis, -90, 90);
    }
    public void AddYAxisInput(float input)
    {
        yAxis += input * yTurn;
    }
}
