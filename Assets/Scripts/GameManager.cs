using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }

}
