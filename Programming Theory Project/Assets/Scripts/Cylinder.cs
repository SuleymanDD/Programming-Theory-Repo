using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    protected override void TextInc()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        textArea.text = "Cylinder";
        StartCoroutine(ResetRoutine());
    }
}
