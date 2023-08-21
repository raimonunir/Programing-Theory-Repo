using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    //Each shape contains data, such as its name or color, which are stored as properties with getters
    // and setters (encapsulation).
    private string m_shapeName;
    public TextMeshProUGUI infoText;
    public string shapeName
    {
        get { return m_shapeName; } 
        set {
            if (value.Length > 5 || value.Length < 2)
            {
                Debug.LogError("shapeName length must be 3-4");
            }
            else
            {
                m_shapeName = value;
            }
        }
    }
    public Color color { get; protected set; }

    private void Awake()
    {
        infoText = GameObject.Find("InfoTMP").GetComponent<TextMeshProUGUI>();
    }
    protected abstract void DisplayText();

    protected void SetRandomColor()
    {
        color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        GetComponent<Renderer>().material.color = color;
    }

    protected void SetRandomColor(float min, float max)
    {
        color = new Color(Random.Range(min, max), Random.Range(min, max), Random.Range(min, max));
        GetComponent<Renderer>().material.color = color;
    }
}
