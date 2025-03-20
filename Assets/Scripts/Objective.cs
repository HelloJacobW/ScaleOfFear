using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{
    [SerializeField] private Text funnyThing;

    [SerializeField] private string objectiveText = "Do this!@! NOW!@!";
    [SerializeField] private string completedText = "Awesome you Got It\\.!";
    public UnityEvent OnCompleteObjective = new UnityEvent();
    private void OnEnable()
    {
        funnyThing.text = objectiveText;
    }
    public void CompletedObjective()
    {
        if (gameObject.activeSelf)
        {
            funnyThing.text = completedText;
            OnCompleteObjective.Invoke();
            gameObject.SetActive(false);
        }
    }
}
