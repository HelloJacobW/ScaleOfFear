
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PushObject : MonoBehaviour
{
    public int strength;
    private Rigidbody rb;
    void Start()
    {
     rb = GetComponent<Rigidbody>();
    }
    public void Push()
    {
        Vector3 pushDirection = transform.position - Camera.main.transform.position;
        pushDirection.Normalize();

        rb.AddForce(pushDirection * strength, ForceMode.Impulse);
    }
}
