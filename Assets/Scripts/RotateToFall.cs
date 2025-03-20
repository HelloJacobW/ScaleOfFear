using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToFall : MonoBehaviour
{

    void Update()
    {
        gameObject.transform.Rotate(Vector3.forward * -1 * Time.deltaTime);
    }
}
