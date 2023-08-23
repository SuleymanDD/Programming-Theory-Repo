using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    protected override void TextInc()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        textArea.text = "Sphere";
    }
}
