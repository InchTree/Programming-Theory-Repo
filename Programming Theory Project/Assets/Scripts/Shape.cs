using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] private Text displayText;
    
    protected Color color { get; private set; }
    protected string kindName { get; set; }

    protected virtual void Start()
    {
        color = GetComponent<Renderer>().material.color;
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    private void DisplayText()
    {
        displayText.text = "Kind: " + kindName + "\nColorData: " + color;
    }

}
