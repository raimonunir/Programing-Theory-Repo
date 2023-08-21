using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        shapeName = "Caps";
        SetRandomColor();
    }


    private void OnMouseDown()
    {
        DisplayText();
    }

    protected override void DisplayText() 
    {
        infoText.text = "Capsule:\n- name:" + shapeName + "\n- color:" + color;
    } 
}
