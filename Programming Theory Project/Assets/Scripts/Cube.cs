using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    protected override void TextInc()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        textArea.text = "Cube";
    }
}
