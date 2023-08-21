using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        shapeName = "Sphe";
        SetRandomColor();
    }


    private void OnMouseDown()
    {
        DisplayText();
    }

    protected override void DisplayText()
    {
        infoText.text = "Sphere:\n- name:" + shapeName + "\n- color:" + color;
    }
}
