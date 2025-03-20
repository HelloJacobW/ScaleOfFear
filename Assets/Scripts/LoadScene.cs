using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public int nextScene;
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(nextScene);
    }
}
