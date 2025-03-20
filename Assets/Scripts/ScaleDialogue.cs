using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScaleDialogue : MonoBehaviour
{
    public TMP_Text dialect;
    void Start()
    {
        dialect.text = "Something Anything";
        Invoke("LineOne", 4);
    }
    void LineOne()
    {
        dialect.text = "Nothing, just A Scale";
        Invoke("LineTwo", 4);
    }
    void LineTwo()
    {
        dialect.text = "A Scale Represents Measurements";
        Invoke("LineThree", 4);
    }
    void LineThree()
    {
        dialect.text = "Measurements mean Everything";
        Invoke("LineFour", 4);
    }
    void LineFour()
    {
        dialect.text = "The Scale is not Tippped to Your Favor";
        Invoke("Done", 5);
    }
    void Done()
    {
        dialect.text = string.Empty;
    }
}
