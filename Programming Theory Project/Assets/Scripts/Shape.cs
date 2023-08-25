using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected TextMeshProUGUI textArea;
    private void Awake()
    {
        textArea = GameObject.Find("Canvas").GetComponentInChildren<TextMeshProUGUI>();

    }
    private void OnMouseDown()
    {
        TextInc();
    }
    protected virtual void TextInc() { }
}
