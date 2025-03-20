
using Unity.VisualScripting;
using UnityEngine;

public class GrowBigger : MonoBehaviour
{
    private bool grow = false;
    private float bigger = 1;
    void Update()
    {
        if (grow)
        {
            bigger++;
            transform.localScale = Vector3.one * bigger * Time.deltaTime + Vector3.one;
        }
    }
    public void StartGrow()
    {
        grow = true;
        Invoke("Shatter", 5);
    }
    void Shatter()
    {
        gameObject.SetActive(false);
    }
}
