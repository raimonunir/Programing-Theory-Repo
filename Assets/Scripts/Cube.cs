using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        shapeName = "Cube";
        SetRandomColor(0f, 0.2f);
    }


    private void OnMouseDown()
    {
        DisplayText();
    }

    protected override void DisplayText()
    {
        infoText.text = "Cube:\n- name:" + shapeName + "\n- color:" + color;
    }
}
