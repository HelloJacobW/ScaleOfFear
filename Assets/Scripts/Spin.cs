
using UnityEngine;

public class Spin : MonoBehaviour
{
    public void Spun()
    {
        gameObject.transform.Rotate(Vector3.up * 3.14f);
    }
}
